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

        private sealed record ReportRow(string Student, string Course, string Section, DateTime Date, string Status);

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
            AppTheme.FieldLabel(label6);
            AppTheme.Action(exportbtn, "DownloadOutlined", primary: true);
            AppTheme.Grid(recentAttendanceGrid);
            poisonDateTime1.Value = DateTime.Today;
            poisonDateTime2.Value = DateTime.Today;

          
            LoadCourses();
            LoadSections();
            LoadStudents();

            aloneComboBox1.SelectedIndexChanged += courseCombo_SelectedIndexChanged;
            aloneComboBox2.SelectedIndexChanged += filterChanged;
            studentcombo.SelectedIndexChanged += filterChanged;
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
            const string query = "SELECT ID, SECTION_NAME FROM section ORDER BY SECTION_NAME;";
            LoadComboBox(aloneComboBox2, query, "SECTION_NAME");
        }

        private void LoadStudents()
        {
            const string query = @"
                SELECT 0 AS ID, 'All Students' AS StudentLabel
                UNION ALL
                SELECT DISTINCT s.id AS ID,
                    CONCAT(s.full_name, IF(s.student_number IS NULL, '', CONCAT(' (', s.student_number, ')'))) AS StudentLabel
                FROM students s
                INNER JOIN class_codes cc ON JSON_CONTAINS(s.classcode, JSON_QUOTE(cc.CLASS_CODE))
                WHERE cc.TEACHER_ID = @TeacherID
                ORDER BY ID <> 0, StudentLabel;";
            LoadComboBox(studentcombo, query, "StudentLabel", ("@TeacherID", teacherId));
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
            LoadSections();
            LoadReport();
        }

        private void filterChanged(object? sender, EventArgs e)
        {
            if (loadingFilters) return;
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
                SELECT s.full_name AS StudentName, c.COURSE_NAME AS Course, sec.SECTION_NAME AS Section,
                    ar.ATTENDANCE_DATE AS AttendanceDate, ar.STATUS AS AttendanceStatus
                FROM attendance_records ar
                INNER JOIN students s ON s.id = ar.STUDENT_ID
                INNER JOIN class_codes cc ON cc.ID = ar.CLASS_CODE_ID
                INNER JOIN course c ON c.ID = cc.COURSE_ID
                INNER JOIN section sec ON sec.ID = cc.SECTION_ID
                WHERE cc.TEACHER_ID = @TeacherID AND ar.ATTENDANCE_DATE BETWEEN @DateFrom AND @DateTo
                    AND (@CourseID IS NULL OR cc.COURSE_ID = @CourseID)
                    AND (@SectionID IS NULL OR cc.SECTION_ID = @SectionID)
                    AND (@StudentID IS NULL OR ar.STUDENT_ID = @StudentID)
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
                command.Parameters.AddWithValue("@SectionID", aloneComboBox2.SelectedValue is int sectionId ? sectionId : (object)DBNull.Value);
                command.Parameters.AddWithValue("@StudentID", SelectedStudentId() ?? (object)DBNull.Value);
                connection.Open();
                using MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rows.Add(new ReportRow(
                        reader["StudentName"]?.ToString() ?? string.Empty,
                        reader["Course"]?.ToString() ?? string.Empty,
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

      
        private int? SelectedStudentId()
        {
            if (studentcombo.SelectedValue is null || studentcombo.SelectedValue is DBNull) return null;
            int id = Convert.ToInt32(studentcombo.SelectedValue);
            return id == 0 ? null : id;
        }

        private void RenderDetailed(List<ReportRow> rows)
        {
            ResetColumns(("Student Name", 180), ("Course", 260), ("Section", 60), ("Date", 120), ("Status", 80));
            foreach (ReportRow row in rows)
            {
                recentAttendanceGrid.Rows.Add(row.Student, row.Course, row.Section,
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
