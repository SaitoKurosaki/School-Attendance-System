using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace School_Attendance_System
{
    public partial class Students : UserControl
    {
        private const string Connection = "server=165.140.202.88;database=school;uid=school;password=Administrator";
        public int TeacherID { get; }

        public Students(int teacherID)
        {
            TeacherID = teacherID;
            InitializeComponent();
            AppTheme.Input(searchtext, "Search name, number or email", "SearchOutlined");
            AppTheme.Grid(studentlistcontent);
            studentlist();
        }

      
        private void studentlist()
        {
            const string query = @"
                SELECT
                    s.full_name AS `Student Name`,
                    s.student_number AS `Student Number`,
                    s.email AS Email,
                    s.parent_email AS `Parent Email`,
                    c.COURSE_NAME AS Course,
                    sec.SECTION_NAME AS Section,
                    COALESCE(t.Present, 0) AS Present,
                    COALESCE(t.Late, 0) AS Late,
                    COALESCE(t.Absent, 0) AS Absent
                FROM students s
                INNER JOIN class_codes cc ON JSON_CONTAINS(s.classcode, JSON_QUOTE(cc.CLASS_CODE))
                INNER JOIN course c ON c.ID = cc.COURSE_ID
                INNER JOIN section sec ON sec.ID = cc.SECTION_ID
                LEFT JOIN (
                    SELECT ar.STUDENT_ID, ar.CLASS_CODE_ID,
                        SUM(ar.STATUS = 'Present') AS Present,
                        SUM(ar.STATUS = 'Late') AS Late,
                        SUM(ar.STATUS = 'Absent') AS Absent
                    FROM attendance_records ar
                    INNER JOIN class_codes own ON own.ID = ar.CLASS_CODE_ID AND own.TEACHER_ID = @TeacherID
                    WHERE ar.ATTENDANCE_DATE >= DATE_FORMAT(CURDATE(), '%Y-%m-01') AND ar.ATTENDANCE_DATE <= CURDATE()
                    GROUP BY ar.STUDENT_ID, ar.CLASS_CODE_ID
                ) t ON t.STUDENT_ID = s.id AND t.CLASS_CODE_ID = cc.ID
                WHERE cc.TEACHER_ID = @TeacherID
                ORDER BY c.COURSE_NAME, sec.SECTION_NAME, s.full_name;";

            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                using MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeacherID", TeacherID);

                using MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                studentlistcontent.DataSource = new DataView(table);
                if (studentlistcontent.Columns.Contains("Course"))
                {
                    studentlistcontent.Columns["Course"]!.FillWeight = 180;
                }
                if (studentlistcontent.Columns.Contains("Section"))
                {
                    studentlistcontent.Columns["Section"]!.FillWeight = 80;
                }

                ApplyStudentFilter();

               
                foreach (string column in new[] { "Present", "Late", "Absent" })
                {
                    if (studentlistcontent.Columns.Contains(column))
                    {
                        studentlistcontent.Columns[column]!.FillWeight = 90;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to load website student data: " + ex.Message, "Students", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void ApplyStudentFilter()
        {
            if (studentlistcontent.DataSource is not DataView view) return;

            string term = SearchFilter.Literal(searchtext.Text.Trim());
            view.RowFilter = term.Length == 0
                ? string.Empty
                : string.Join(" OR ", new[] { "[Student Name]", "[Student Number]", "Email", "[Parent Email]", "Course", "Section" }
                    .Select(column => $"{column} LIKE '%{term}%'"));
        }

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
            ApplyStudentFilter();
        }
    }
}
