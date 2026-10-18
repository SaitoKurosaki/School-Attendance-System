using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace School_Attendance_System
{
    public partial class Attendance : UserControl
    {
        private const string Connection = "server=165.140.202.88;database=school;uid=school;password=Administrator";
        private readonly int teacherId;
        private int selectedClassCodeId;
        private DateTime selectedDate = DateTime.Today;
        private bool gridDirty;
        private bool revertingSelection;
        private int? lastCourseId;
        private int? lastSectionId;

        private sealed record StudentRow(int Id, string Name, string ParentEmail);

        public Attendance(int teacherId)
        {
            this.teacherId = teacherId;
            InitializeComponent();
            AppTheme.Page(this);
            AppTheme.Title(label1);
            AppTheme.FieldLabel(label2);
            AppTheme.FieldLabel(label3);
            AppTheme.FieldLabel(label4);
            AppTheme.Action(btnDashboard, "CheckOutlined", primary: true);
            AppTheme.Action(markallbtn, "SelectOutlined");
            ConfigureGrid();
            AppTheme.Grid(recentAttendanceGrid);
            attendanceDate.Value = DateTime.Today;

           
            LoadCourses();

            btnDashboard.Click += saveAttendanceButton_Click;
            coursecombo.SelectedIndexChanged += coursecombo_SelectedIndexChanged;
            sectioncombo.SelectedIndexChanged += sectioncombo_SelectedIndexChanged;
            attendanceDate.ValueChanged += attendanceDate_ValueChanged;
            recentAttendanceGrid.EditingControlShowing += recentAttendanceGrid_EditingControlShowing;
            recentAttendanceGrid.CellValidating += recentAttendanceGrid_CellValidating;
            recentAttendanceGrid.CurrentCellDirtyStateChanged += recentAttendanceGrid_CurrentCellDirtyStateChanged;
            recentAttendanceGrid.CellValueChanged += recentAttendanceGrid_CellValueChanged;
        }

        private void ConfigureGrid()
        {
            recentAttendanceGrid.ReadOnly = false;
            colStudentName.Width = 160;
            colTimeIn.Width = 90;
            colTimeOut.Width = 90;
            colPresent.Width = 75;
            colLate.Width = 65;
            colAbsent.Width = 75;
            colRemarks.Width = 130;
            colStudentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (DataGridViewColumn column in recentAttendanceGrid.Columns)
                column.ReadOnly = column == colStudentName;

            foreach (DataGridViewColumn column in new DataGridViewColumn[] { colPresent, colLate, colAbsent })
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void LoadCourses()
        {
            const string query = "SELECT ID, COURSE_NAME FROM course ORDER BY COURSE_NAME;";
            LoadComboBox(coursecombo, query);
        }

        private void LoadSections()
        {
            const string query = "SELECT ID, SECTION_NAME FROM section ORDER BY SECTION_NAME;";
            LoadComboBox(sectioncombo, query);
        }

        private void LoadComboBox(ComboBox comboBox, string query)
        {
            
            revertingSelection = true;
            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                using MySqlCommand command = new MySqlCommand(query, connection);

                using MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                comboBox.DataSource = table;
                comboBox.DisplayMember = table.Columns.Contains("COURSE_NAME") ? "COURSE_NAME" : "SECTION_NAME";
                comboBox.ValueMember = "ID";
                comboBox.SelectedIndex = -1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to load attendance options: " + ex.Message, "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                revertingSelection = false;
            }
        }

        private void coursecombo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (revertingSelection) return;
            if (!ConfirmDiscardEdits())
            {
                RestoreSelection(nameof(coursecombo));
                return;
            }
            ClearAttendanceGrid();
            selectedClassCodeId = 0;
            lastCourseId = coursecombo.SelectedValue as int?;
            lastSectionId = null;
            LoadSections();
        }

        private void sectioncombo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (revertingSelection) return;
            if (!ConfirmDiscardEdits())
            {
                RestoreSelection(nameof(sectioncombo));
                return;
            }
            ClearAttendanceGrid();
            selectedClassCodeId = 0;
            if (coursecombo.SelectedValue is int courseId && sectioncombo.SelectedValue is int sectionId)
                LoadStudents(courseId, sectionId);
        }

        private void attendanceDate_ValueChanged(object? sender, EventArgs e)
        {
            if (revertingSelection) return;
            if (attendanceDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Attendance can be entered for today or an earlier date.", "Attendance",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                RestoreSelection(nameof(attendanceDate));
                return;
            }
            if (!ConfirmDiscardEdits())
            {
                RestoreSelection(nameof(attendanceDate));
                return;
            }
            selectedClassCodeId = 0;
            if (coursecombo.SelectedValue is int courseId && sectioncombo.SelectedValue is int sectionId)
                LoadStudents(courseId, sectionId);
            else
            {
                selectedDate = attendanceDate.Value.Date;
                ClearAttendanceGrid();
            }
        }

        private void markallbtn_Click(object? sender, EventArgs e)
        {
            foreach (DataGridViewRow row in recentAttendanceGrid.Rows)
                row.Cells["colPresent"].Value = true;
        }

       
        internal bool ConfirmDiscardEdits() => !gridDirty || MessageBox.Show(
                "Discard the attendance you have entered but not saved?",
                "Attendance",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes;

       
        private void RestoreSelection(string fieldName)
        {
            revertingSelection = true;
            switch (fieldName)
            {
                case nameof(coursecombo) when lastCourseId is int courseId:
                    coursecombo.SelectedValue = courseId;
                    break;
                case nameof(sectioncombo) when lastSectionId is int sectionId:
                    sectioncombo.SelectedValue = sectionId;
                    break;
                case nameof(attendanceDate):
                    attendanceDate.Value = selectedDate;
                    break;
            }
            revertingSelection = false;
        }

        private void LoadStudents(int courseId, int sectionId)
        {
            ClearAttendanceGrid();
            selectedDate = attendanceDate.Value.Date;
            lastCourseId = courseId;
            lastSectionId = sectionId;

            const string classCodeQuery = @"
                SELECT ID FROM class_codes
                WHERE TEACHER_ID = @TeacherID AND COURSE_ID = @CourseID AND SECTION_ID = @SectionID LIMIT 1;";
            const string studentsQuery = @"
                SELECT s.id AS StudentId, s.student_number AS StudentNumber, s.full_name AS StudentName,
                    s.parent_email AS ParentEmail,
                    ar.STATUS, DATE_FORMAT(ar.TIME_IN, '%h:%i %p') AS TimeIn,
                    DATE_FORMAT(ar.TIME_OUT, '%h:%i %p') AS TimeOut, ar.REMARKS AS Remarks
                FROM students s
                INNER JOIN class_codes cc ON JSON_CONTAINS(s.classcode, JSON_QUOTE(cc.CLASS_CODE))
                LEFT JOIN attendance_records ar ON ar.STUDENT_ID = s.id AND ar.CLASS_CODE_ID = cc.ID
                    AND ar.ATTENDANCE_DATE = @Date
                WHERE cc.ID = @ClassCodeID ORDER BY s.full_name;";

            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                connection.Open();
                using (MySqlCommand classCodeCommand = new MySqlCommand(classCodeQuery, connection))
                {
                    classCodeCommand.Parameters.AddWithValue("@TeacherID", teacherId);
                    classCodeCommand.Parameters.AddWithValue("@CourseID", courseId);
                    classCodeCommand.Parameters.AddWithValue("@SectionID", sectionId);
                    object? result = classCodeCommand.ExecuteScalar();
                    if (result == null) return;
                    selectedClassCodeId = Convert.ToInt32(result);
                }

                using MySqlCommand studentsCommand = new MySqlCommand(studentsQuery, connection);
                studentsCommand.Parameters.AddWithValue("@ClassCodeID", selectedClassCodeId);
                studentsCommand.Parameters.AddWithValue("@Date", selectedDate);
                using MySqlDataReader reader = studentsCommand.ExecuteReader();
                while (reader.Read())
                {
                    string status = reader["STATUS"]?.ToString() ?? string.Empty;
                    int rowIndex = recentAttendanceGrid.Rows.Add(
                        reader["StudentName"],
                        reader["TimeIn"] == DBNull.Value ? string.Empty : reader["TimeIn"],
                        reader["TimeOut"] == DBNull.Value ? string.Empty : reader["TimeOut"],
                        status == "Present", status == "Late", status == "Absent",
                        reader["Remarks"] == DBNull.Value ? string.Empty : reader["Remarks"]);
                    recentAttendanceGrid.Rows[rowIndex].Tag = new StudentRow(
                        Convert.ToInt32(reader["StudentId"]),
                        reader["StudentName"]?.ToString() ?? string.Empty,
                        reader["ParentEmail"]?.ToString()?.Trim() ?? string.Empty);
                }

                lastCourseId = courseId;
                lastSectionId = sectionId;
                gridDirty = false;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to load students: " + ex.Message, "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void saveAttendanceButton_Click(object? sender, EventArgs e)
        {
            if (selectedClassCodeId == 0 || recentAttendanceGrid.Rows.Count == 0)
            {
                MessageBox.Show("Select a course and section with students before saving.", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (DataGridViewRow row in recentAttendanceGrid.Rows)
                if (GetStatus(row) == null)
                {
                    MessageBox.Show("Choose Present, Late, or Absent for every student before saving.", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            const string saveQuery = @"
                INSERT INTO attendance_records (STUDENT_ID, CLASS_CODE_ID, ATTENDANCE_DATE, STATUS, TIME_IN, TIME_OUT, REMARKS)
                VALUES (@StudentID, @ClassCodeID, @Date, @Status, @TimeIn, @TimeOut, @Remarks)
                ON DUPLICATE KEY UPDATE STATUS = VALUES(STATUS), TIME_IN = VALUES(TIME_IN),
                    TIME_OUT = VALUES(TIME_OUT), REMARKS = VALUES(REMARKS);";
            List<AttendanceNotice> notices = new List<AttendanceNotice>();
            string courseName = coursecombo.Text;
            string sectionName = sectioncombo.Text;
            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                connection.Open();
                using MySqlTransaction transaction = connection.BeginTransaction();
                using MySqlCommand command = new MySqlCommand(saveQuery, connection, transaction);
                command.Parameters.Add("@StudentID", MySqlDbType.Int32);
                command.Parameters.Add("@ClassCodeID", MySqlDbType.Int32);
                command.Parameters.Add("@Date", MySqlDbType.Date).Value = selectedDate;
                command.Parameters.Add("@Status", MySqlDbType.VarChar);
                command.Parameters.Add("@TimeIn", MySqlDbType.DateTime);
                command.Parameters.Add("@TimeOut", MySqlDbType.DateTime);
                command.Parameters.Add("@Remarks", MySqlDbType.VarChar);

                foreach (DataGridViewRow row in recentAttendanceGrid.Rows)
                {
                    StudentRow student = (StudentRow)row.Tag!;
                    string status = GetStatus(row)!;
                    string remarks = row.Cells["colRemarks"].Value?.ToString()?.Trim() ?? string.Empty;
                    command.Parameters["@StudentID"].Value = student.Id;
                    command.Parameters["@ClassCodeID"].Value = selectedClassCodeId;
                    command.Parameters["@Status"].Value = status;
                    command.Parameters["@TimeIn"].Value = ParseTime(row.Cells["colTimeIn"].Value?.ToString(), selectedDate) ?? (object)DBNull.Value;
                    command.Parameters["@TimeOut"].Value = ParseTime(row.Cells["colTimeOut"].Value?.ToString(), selectedDate) ?? (object)DBNull.Value;
                    command.Parameters["@Remarks"].Value = remarks.Length == 0 ? DBNull.Value : remarks;
                    command.ExecuteNonQuery();

                    
                    if (student.ParentEmail.Length > 0)
                        notices.Add(new AttendanceNotice(student.Id, selectedClassCodeId, selectedDate,
                            student.ParentEmail, student.Name, status, courseName, sectionName, remarks));
                }
                transaction.Commit();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to save attendance: " + ex.Message, "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (notices.Count > 0)
                _ = Task.Run(() => notices.ForEach(ParentNotifier.Send));

            MessageBox.Show("Attendance saved successfully.", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (coursecombo.SelectedValue is int courseId && sectioncombo.SelectedValue is int sectionId)
                LoadStudents(courseId, sectionId);
        }

        private static string? GetStatus(DataGridViewRow row)
        {
            if (IsChecked(row, "colPresent")) return "Present";
            if (IsChecked(row, "colLate")) return "Late";
            if (IsChecked(row, "colAbsent")) return "Absent";
            return null;
        }

        private static bool IsChecked(DataGridViewRow row, string columnName) => Convert.ToBoolean(row.Cells[columnName].Value ?? false);

      
        private static DateTime? ParseTime(string? value, DateTime? anchorDate = null)
        {
            if (string.IsNullOrWhiteSpace(value)) return null;
            return DateTime.TryParseExact(value.Trim(), new[] { "h:mm tt", "hh:mm tt", "h:mmtt", "hh:mmtt" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime time)
                ? (anchorDate ?? DateTime.Today).Add(time.TimeOfDay) : null;
        }

        private void ClearAttendanceGrid()
        {
            recentAttendanceGrid.Rows.Clear();
            gridDirty = false;
        }

        private void recentAttendanceGrid_EditingControlShowing(object? sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (recentAttendanceGrid.CurrentCell?.OwningColumn?.Name is "colTimeIn" or "colTimeOut" && e.Control is TextBox textBox)
            {
                textBox.KeyPress -= Time_KeyPress;
                textBox.KeyPress += Time_KeyPress;
            }
        }

        private static void Time_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':' && !"AMPamp".Contains(e.KeyChar)) e.Handled = true;
        }

        private void recentAttendanceGrid_CellValidating(object? sender, DataGridViewCellValidatingEventArgs e)
        {
            if (recentAttendanceGrid.Columns[e.ColumnIndex].Name is not ("colTimeIn" or "colTimeOut") || string.IsNullOrWhiteSpace(e.FormattedValue?.ToString())) return;
            if (ParseTime(e.FormattedValue?.ToString()) == null)
            {
                MessageBox.Show("Enter a valid time, such as 7:30 AM or 5:00 PM.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void recentAttendanceGrid_CurrentCellDirtyStateChanged(object? sender, EventArgs e)
        {
            if (recentAttendanceGrid.IsCurrentCellDirty) recentAttendanceGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void recentAttendanceGrid_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            gridDirty = true;
            if (recentAttendanceGrid.Columns[e.ColumnIndex].Name is not ("colPresent" or "colLate" or "colAbsent")) return;
            DataGridViewRow row = recentAttendanceGrid.Rows[e.RowIndex];
            string selectedColumn = recentAttendanceGrid.Columns[e.ColumnIndex].Name;
            if (!IsChecked(row, selectedColumn)) return;
            foreach (string columnName in new[] { "colPresent", "colLate", "colAbsent" })
                if (columnName != selectedColumn) row.Cells[columnName].Value = false;

            if (selectedColumn == "colAbsent")
            {
                row.Cells["colTimeIn"].Value = string.Empty;
                row.Cells["colTimeOut"].Value = string.Empty;
            }
           
            else if (selectedDate == DateTime.Today && string.IsNullOrWhiteSpace(row.Cells["colTimeIn"].Value?.ToString()))
                row.Cells["colTimeIn"].Value = DateTime.Now.ToString("h:mm tt", CultureInfo.InvariantCulture);
        }
    }
}
