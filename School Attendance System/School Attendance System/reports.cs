using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace School_Attendance_System
{
    public partial class Reports : UserControl
    {
        private const string Connection = "server=165.140.202.88;database=school;uid=school;password=Administrator";
        private readonly int teacherId;
        private DateTime rangeFrom = DateTime.Today;
        private DateTime rangeTo = DateTime.Today;
        private bool loadingFilters;

        private sealed record ReportRow(string Student, string Course, int Year, int Semester, string Section, DateTime Date, string Status);

        public Reports(int teacherId)
        {
            this.teacherId = teacherId;
            InitializeComponent();
            AppTheme.Page(this);
            AppTheme.Title(label1);
            AppTheme.FieldLabel(label2);
            AppTheme.FieldLabel(label3);
            AppTheme.FieldLabel(label4);
            AppTheme.FieldLabel(label5);
            AppTheme.FieldLabel(label7);
            AppTheme.FieldLabel(label8);
            AppTheme.Action(exportbtn, "DownloadOutlined", primary: true);
            AppTheme.Grid(recentAttendanceGrid);
            poisonDateTime1.Value = DateTime.Today;
            poisonDateTime2.Value = DateTime.Today;

          
            LoadCourses();
            LoadYears();
            LoadSemesters();
            LoadSections();

            aloneComboBox1.SelectedIndexChanged += courseCombo_SelectedIndexChanged;
            yearcombo.SelectedIndexChanged += academicFilterChanged;
            semestercombo.SelectedIndexChanged += academicFilterChanged;
            aloneComboBox2.SelectedIndexChanged += filterChanged;
            poisonDateTime1.ValueChanged += filterChanged;
            poisonDateTime2.ValueChanged += filterChanged;
            LoadReport();
        }

        private void LoadCourses()
        {
            const string query = "SELECT ID, COURSE_NAME FROM course ORDER BY COURSE_NAME;";
            LoadComboBox(aloneComboBox1, query, "COURSE_NAME");
        }

        private void LoadSections()
        {
            if (!AppTheme.TryGetIntValue(yearcombo.SelectedValue, out int year) ||
                !AppTheme.TryGetIntValue(semestercombo.SelectedValue, out int semester))
            {
                bool wasLoading = loadingFilters;
                loadingFilters = true;
                aloneComboBox2.DataSource = null;
                loadingFilters = wasLoading;
                return;
            }

            const string query = @"SELECT ID, SECTION_NAME FROM section
                WHERE SECTION_NAME NOT LIKE 'ARCHIVED-%'
                  AND YEAR_LEVEL = @YearLevel
                  AND SEMESTER = @Semester
                ORDER BY SECTION_NAME;";
            LoadComboBox(aloneComboBox2, query, "SECTION_NAME",
                ("@YearLevel", year),
                ("@Semester", semester));
        }

        private void LoadYears() => LoadComboBox(yearcombo,
            "SELECT DISTINCT CAST(YEAR_LEVEL AS SIGNED) AS ID, CONCAT('Year ', YEAR_LEVEL) AS Label FROM section WHERE SECTION_NAME NOT LIKE 'ARCHIVED-%' ORDER BY ID;", "Label");

        private void LoadSemesters() => LoadComboBox(semestercombo,
            "SELECT CAST(1 AS SIGNED) AS ID, 'Semester 1' AS Label UNION ALL SELECT CAST(2 AS SIGNED), 'Semester 2';", "Label");

        private void LoadComboBox(ComboBox comboBox, string query, string displayMember,
            params (string Name, object Value)[] parameters)
        {
           
            loadingFilters = true;
            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                using MySqlCommand command = new MySqlCommand(query, connection);
                foreach ((string name, object value) in parameters) command.Parameters.AddWithValue(name, value);

                using MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                comboBox.DataSource = table;
                comboBox.DisplayMember = displayMember;
                comboBox.ValueMember = "ID";
                comboBox.SelectedIndex = -1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to load report filters: " + ex.Message, "Reports", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadingFilters = false;
            }
        }

        private void courseCombo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (loadingFilters) return;
            LoadSections();
            LoadReport();
        }

        private void filterChanged(object? sender, EventArgs e)
        {
            if (loadingFilters) return;
            LoadReport();
        }

        private void academicFilterChanged(object? sender, EventArgs e)
        {
            if (loadingFilters) return;
            LoadSections();
            LoadReport();
        }

        private void exportbtn_Click(object? sender, EventArgs e)
        {
            if (recentAttendanceGrid.Rows.Count == 0)
            {
                MessageBox.Show("There are no report rows to export for the selected filters.", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "CSV file (Excel)|*.csv",
                FileName = $"Attendance Report {poisonDateTime1.Value:yyyy-MM-dd} to {poisonDateTime2.Value:yyyy-MM-dd}.csv"
            };
            if (dialog.ShowDialog() != DialogResult.OK) return;

            List<DataGridViewColumn> columns = recentAttendanceGrid.Columns.Cast<DataGridViewColumn>()
                .Where(c => c.Visible).OrderBy(c => c.DisplayIndex).ToList();
            StringBuilder csv = new StringBuilder();
            csv.AppendLine(string.Join(",", columns.Select(c => CsvField(c.HeaderText))));
            foreach (DataGridViewRow row in recentAttendanceGrid.Rows)
                csv.AppendLine(string.Join(",", columns.Select(c => CsvField(row.Cells[c.Index].Value?.ToString()))));

            try
            {
              
                File.WriteAllText(dialog.FileName, csv.ToString(), new UTF8Encoding(true));
                MessageBox.Show("Report exported to:\n" + dialog.FileName, "Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                MessageBox.Show("Unable to export: " + ex.Message, "Reports", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static string CsvField(string? value)
        {
            value ??= string.Empty;
           
            if (value.Length > 0 && "=+-@".Contains(value[0])) value = "'" + value;
            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }

        private void LoadReport()
        {
            recentAttendanceGrid.Rows.Clear();

            rangeFrom = poisonDateTime1.Value.Date;
            rangeTo = poisonDateTime2.Value.Date;
          
            if (rangeFrom > rangeTo) (rangeFrom, rangeTo) = (rangeTo, rangeFrom);

            const string query = @"
                SELECT s.full_name AS StudentName, c.COURSE_NAME AS Course, sec.YEAR_LEVEL AS YearLevel,
                    sec.SEMESTER AS Semester, sec.SECTION_NAME AS Section,
                    ar.ATTENDANCE_DATE AS AttendanceDate, ar.STATUS AS AttendanceStatus
                FROM attendance_records ar
                INNER JOIN students s ON s.id = ar.STUDENT_ID
                INNER JOIN class_codes cc ON cc.ID = ar.CLASS_CODE_ID
                INNER JOIN course c ON c.ID = cc.COURSE_ID
                INNER JOIN section sec ON sec.ID = cc.SECTION_ID
                WHERE cc.TEACHER_ID = @TeacherID AND ar.ATTENDANCE_DATE BETWEEN @DateFrom AND @DateTo
                    AND (@CourseID IS NULL OR cc.COURSE_ID = @CourseID)
                    AND (@YearLevel IS NULL OR sec.YEAR_LEVEL = @YearLevel)
                    AND (@Semester IS NULL OR sec.SEMESTER = @Semester)
                    AND (@SectionID IS NULL OR cc.SECTION_ID = @SectionID)
                ORDER BY ar.ATTENDANCE_DATE DESC, c.COURSE_NAME, sec.SECTION_NAME, s.full_name;";

            List<ReportRow> rows = new List<ReportRow>();
            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                using MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeacherID", teacherId);
                command.Parameters.AddWithValue("@DateFrom", rangeFrom);
                command.Parameters.AddWithValue("@DateTo", rangeTo);
                command.Parameters.AddWithValue("@CourseID", aloneComboBox1.SelectedValue is int courseId ? courseId : (object)DBNull.Value);
                command.Parameters.AddWithValue("@YearLevel", AppTheme.TryGetIntValue(yearcombo.SelectedValue, out int year) ? year : (object)DBNull.Value);
                command.Parameters.AddWithValue("@Semester", AppTheme.TryGetIntValue(semestercombo.SelectedValue, out int semester) ? semester : (object)DBNull.Value);
                command.Parameters.AddWithValue("@SectionID", aloneComboBox2.SelectedValue is int sectionId ? sectionId : (object)DBNull.Value);
                connection.Open();
                using MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rows.Add(new ReportRow(
                        reader["StudentName"]?.ToString() ?? string.Empty,
                        reader["Course"]?.ToString() ?? string.Empty,
                        Convert.ToInt32(reader["YearLevel"]),
                        Convert.ToInt32(reader["Semester"]),
                        reader["Section"]?.ToString() ?? string.Empty,
                        Convert.ToDateTime(reader["AttendanceDate"]),
                        reader["AttendanceStatus"]?.ToString() ?? string.Empty));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to generate report: " + ex.Message, "Reports", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RenderDetailed(rows);
        }

      
        private void RenderDetailed(List<ReportRow> rows)
        {
            ResetColumns(("Student Name", 180), ("Course", 220), ("Year", 55), ("Semester", 70), ("Section", 60), ("Date", 120), ("Status", 80));
            foreach (ReportRow row in rows)
            {
                recentAttendanceGrid.Rows.Add(row.Student, row.Course, row.Year, row.Semester, row.Section,
                    row.Date.ToString("MMMM dd, yyyy"), row.Status);
            }
        }

        private void ResetColumns(params (string Header, int FillWeight)[] columns)
        {
            recentAttendanceGrid.Columns.Clear();
            foreach ((string header, int fillWeight) in columns)
                recentAttendanceGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = header, FillWeight = fillWeight });
        }
    }
}
