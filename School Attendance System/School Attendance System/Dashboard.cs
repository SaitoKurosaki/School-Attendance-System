using AntdUI;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace School_Attendance_System
{
    public partial class Dashboard : UserControl
    {
        private const string MysqlConnection = "server=165.140.202.88;database=school;uid=school;password=Administrator";
        private readonly int teacherId;

        public Dashboard(int teacherId)
        {
            this.teacherId = teacherId;
            InitializeComponent();
            AppTheme.Grid(recentAttendanceGrid);
            colStudentName.FillWeight = 100;
            colCourse.FillWeight = 100;
            colYear.FillWeight = 100;
            colSemester.FillWeight = 100;
            colSection.FillWeight = 100;
            colStatus.FillWeight = 100;
            colTime.FillWeight = 100;
            colRemarks.FillWeight = 100;
            LoadDashboard();
        }

        internal static string Abbreviate(string courseName)
        {
            string[] skip = { "of", "in", "and", "the" };
            string initials = string.Concat(courseName.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(word => !skip.Contains(word.ToLowerInvariant()))
                .Select(word => char.ToUpperInvariant(word[0])));
            return initials.Length > 1 ? initials : courseName;
        }

       
        public void LoadDashboard()
        {
            
            const string totalsQuery = @"
                SELECT
                    COUNT(DISTINCT CONCAT(s.id, '-', cc.ID)) AS TotalStudents,
                    COUNT(DISTINCT CASE WHEN ar.STATUS = 'Present' THEN CONCAT(s.id, '-', cc.ID) END) AS PresentToday,
                    COUNT(DISTINCT CASE WHEN ar.STATUS = 'Late' THEN CONCAT(s.id, '-', cc.ID) END) AS LateToday,
                    COUNT(DISTINCT CASE WHEN ar.STATUS = 'Absent' THEN CONCAT(s.id, '-', cc.ID) END) AS AbsentToday
                FROM students s
                INNER JOIN class_codes cc
                    ON JSON_CONTAINS(s.classcode, JSON_QUOTE(cc.CLASS_CODE))
                LEFT JOIN attendance_records ar
                    ON ar.STUDENT_ID = s.id
                    AND ar.CLASS_CODE_ID = cc.ID
                    AND ar.ATTENDANCE_DATE = CURDATE()
                WHERE cc.TEACHER_ID = @TeacherID;";

            const string recentAttendanceQuery = @"
                SELECT
                    s.full_name AS StudentName,
                    c.COURSE_NAME AS CourseName,
                    sec.YEAR_LEVEL AS YearLevel,
                    sec.SEMESTER AS Semester,
                    sec.SECTION_NAME AS SectionName,
                    ar.STATUS AS AttendanceStatus,
                    DATE_FORMAT(ar.TIME_IN, '%h:%i %p') AS AttendanceTime,
                    ar.REMARKS AS Remarks
                FROM attendance_records ar
                INNER JOIN students s ON s.id = ar.STUDENT_ID
                INNER JOIN class_codes cc ON cc.ID = ar.CLASS_CODE_ID
                INNER JOIN course c ON c.ID = cc.COURSE_ID
                INNER JOIN section sec ON sec.ID = cc.SECTION_ID
                WHERE cc.TEACHER_ID = @TeacherID
                    AND ar.ATTENDANCE_DATE = CURDATE()
                ORDER BY ar.ATTENDANCE_DATE DESC, ar.TIME_IN DESC, ar.ID DESC;";

            try
            {
                using MySqlConnection connection = new MySqlConnection(MysqlConnection);
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(totalsQuery, connection))
                {
                    command.Parameters.AddWithValue("@TeacherID", teacherId);

                    using MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        label7.Text = reader["TotalStudents"].ToString();
                        label5.Text = reader["PresentToday"].ToString();
                        label4.Text = reader["LateToday"].ToString();
                        label6.Text = reader["AbsentToday"].ToString();
                    }
                }

                using MySqlCommand recentCommand = new MySqlCommand(recentAttendanceQuery, connection);
                recentCommand.Parameters.AddWithValue("@TeacherID", teacherId);

                using (MySqlDataReader recentReader = recentCommand.ExecuteReader())
                {
                    recentAttendanceGrid.Rows.Clear();
                    while (recentReader.Read())
                    {
                       
                        recentAttendanceGrid.Rows.Add(
                            recentReader["StudentName"],
                            Abbreviate(recentReader["CourseName"].ToString() ?? string.Empty),
                            recentReader["YearLevel"],
                            recentReader["Semester"],
                            recentReader["SectionName"],
                            recentReader["AttendanceStatus"],
                            recentReader["AttendanceTime"],
                            recentReader["Remarks"]);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Unable to load dashboard data: " + ex.Message,
                    "Dashboard",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
