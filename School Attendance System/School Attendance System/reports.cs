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
            yearcombo.SelectedIndexChanged += yearFilterChanged;
            semestercombo.SelectedIndexChanged += semesterFilterChanged;
            aloneComboBox2.SelectedIndexChanged += filterChanged;
            poisonDateTime1.ValueChanged += filterChanged;
            poisonDateTime2.ValueChanged += filterChanged;
            LoadReport();
        }

        private void LoadCourses()
        {
            const string query = @"
                SELECT DISTINCT c.ID, c.COURSE_NAME
                FROM course c
                INNER JOIN class_codes cc ON cc.COURSE_ID = c.ID AND cc.TEACHER_ID = @TeacherID
                INNER JOIN section sec ON sec.ID = cc.SECTION_ID
                WHERE sec.IS_ARCHIVED = 0
                    AND sec.SECTION_NAME NOT LIKE 'ARCHIVED-%'
                ORDER BY c.COURSE_NAME;";
            LoadComboBox(aloneComboBox1, query, "COURSE_NAME", ("@TeacherID", teacherId));
        }

        private void LoadSections()
        {
            object courseId = AppTheme.TryGetIntValue(aloneComboBox1.SelectedValue, out int selectedCourse)
                ? selectedCourse : DBNull.Value;
            object year = AppTheme.TryGetIntValue(yearcombo.SelectedValue, out int selectedYear)
                ? selectedYear : DBNull.Value;
            object semester = AppTheme.TryGetIntValue(semestercombo.SelectedValue, out int selectedSemester)
                ? selectedSemester : DBNull.Value;
            const string query = @"
                SELECT DISTINCT sec.ID, sec.SECTION_NAME
                FROM section sec
                INNER JOIN class_codes cc ON cc.SECTION_ID = sec.ID AND cc.TEACHER_ID = @TeacherID
                WHERE sec.IS_ARCHIVED = 0 AND sec.SECTION_NAME NOT LIKE 'ARCHIVED-%'
                    AND (@CourseID IS NULL OR cc.COURSE_ID = @CourseID)
                    AND (@YearLevel IS NULL OR sec.YEAR_LEVEL = @YearLevel)
                    AND (@Semester IS NULL OR sec.SEMESTER = @Semester)
                ORDER BY sec.SECTION_NAME;";
            LoadComboBox(aloneComboBox2, query, "SECTION_NAME",
                ("@TeacherID", teacherId),
                ("@CourseID", courseId),
                ("@YearLevel", year),
                ("@Semester", semester));
        }

        private void LoadYears()
        {
            object courseId = AppTheme.TryGetIntValue(aloneComboBox1.SelectedValue, out int selectedCourse)
                ? selectedCourse : DBNull.Value;
            const string query = @"
                SELECT DISTINCT CAST(sec.YEAR_LEVEL AS SIGNED) AS ID,
                    CONCAT('Year ', sec.YEAR_LEVEL) AS Label
                FROM section sec
                INNER JOIN class_codes cc ON cc.SECTION_ID = sec.ID AND cc.TEACHER_ID = @TeacherID
                WHERE sec.IS_ARCHIVED = 0 AND sec.SECTION_NAME NOT LIKE 'ARCHIVED-%'
                    AND (@CourseID IS NULL OR cc.COURSE_ID = @CourseID)
                ORDER BY ID;";
            LoadComboBox(yearcombo, query, "Label",
                ("@TeacherID", teacherId), ("@CourseID", courseId));
        }

        private void LoadSemesters()
        {
            object courseId = AppTheme.TryGetIntValue(aloneComboBox1.SelectedValue, out int selectedCourse)
                ? selectedCourse : DBNull.Value;
            object year = AppTheme.TryGetIntValue(yearcombo.SelectedValue, out int selectedYear)
                ? selectedYear : DBNull.Value;
            const string query = @"
                SELECT DISTINCT CAST(sec.SEMESTER AS SIGNED) AS ID,
                    CONCAT('Semester ', sec.SEMESTER) AS Label
                FROM section sec
                INNER JOIN class_codes cc ON cc.SECTION_ID = sec.ID AND cc.TEACHER_ID = @TeacherID
                WHERE sec.IS_ARCHIVED = 0 AND sec.SECTION_NAME NOT LIKE 'ARCHIVED-%'
                    AND (@CourseID IS NULL OR cc.COURSE_ID = @CourseID)
                    AND (@YearLevel IS NULL OR sec.YEAR_LEVEL = @YearLevel)
                ORDER BY ID;";
            LoadComboBox(semestercombo, query, "Label",
                ("@TeacherID", teacherId), ("@CourseID", courseId), ("@YearLevel", year));
        }

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
            LoadYears();
            LoadSemesters();
            LoadSections();
            LoadReport();
        }

        private void filterChanged(object? sender, EventArgs e)
        {
            if (loadingFilters) return;
            LoadReport();
        }

        private void yearFilterChanged(object? sender, EventArgs e)
        {
            if (loadingFilters) return;
            LoadSemesters();
            LoadSections();
            LoadReport();
        }

        private void semesterFilterChanged(object? sender, EventArgs e)
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
            ResetColumns("Student Name", "Course", "Year", "Semester", "Section", "Date", "Status");
            foreach (ReportRow row in rows)
            {
                recentAttendanceGrid.Rows.Add(row.Student, row.Course, row.Year, row.Semester, row.Section,
                    row.Date.ToString("MMMM dd, yyyy"), row.Status);
            }
        }

        private void ResetColumns(params string[] headers)
        {
            recentAttendanceGrid.Columns.Clear();
            foreach (string header in headers)
                recentAttendanceGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = header, FillWeight = 100 });
        }
    }
}
