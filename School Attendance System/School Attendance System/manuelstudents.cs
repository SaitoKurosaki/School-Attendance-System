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
    public partial class manuelstudents : UserControl
    {
        public int TeacherID { get; private set; }
        public string Connection = "server=localhost;database=school;uid=school;password=Administrator";
        public manuelstudents(int teacherID)
        {
            TeacherID = teacherID;
            InitializeComponent();

            studentlist();


        }

        private void sectioncombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentlist()
        {
            MySqlConnection conn = new MySqlConnection(Connection);
            MySqlDataAdapter adapter = null;
            MySqlCommand cmd = null;

            try
            {
                string query = @"
            SELECT DISTINCT
    s.full_name,
    s.email,
    s.parent_email,
    s.student_number
FROM students s
INNER JOIN class_codes cc
    ON JSON_CONTAINS(
        s.classcode,
        JSON_QUOTE(cc.CLASS_CODE)
    )
WHERE cc.TEACHER_ID = @TeacherID;
        ";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TeacherID", TeacherID);

                adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                studentlistcontent.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load students: " + ex.Message);
            }
            finally
            {
                if (adapter != null)
                    adapter.Dispose();

                if (cmd != null)
                    cmd.Dispose();

                conn.Dispose();
            }
        }
        private void studentlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void studentlist(string searchText = "")
        {
            MySqlConnection conn = new MySqlConnection(Connection);
            MySqlDataAdapter adapter = null;
            MySqlCommand cmd = null;

            try
            {
                string query = @"
            SELECT DISTINCT
                s.full_name,
                s.email,
                s.parent_email,
                s.student_number
            FROM students s
            INNER JOIN class_codes cc
                ON JSON_CONTAINS(
                    s.classcode,
                    JSON_QUOTE(cc.CLASS_CODE)
                )
            INNER JOIN course c
                ON cc.COURSE_ID = c.ID
            INNER JOIN section sec
                ON cc.SECTION_ID = sec.ID
            WHERE cc.TEACHER_ID = @TeacherID
            AND (
                @SearchText = ''
                OR s.full_name LIKE @SearchPattern
                OR s.student_number LIKE @SearchPattern
                OR CAST(s.id AS CHAR) LIKE @SearchPattern
                OR c.COURSE_NAME LIKE @SearchPattern
                OR sec.SECTION_NAME LIKE @SearchPattern
            )
        ";

                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@TeacherID", TeacherID);
                cmd.Parameters.AddWithValue("@SearchText", searchText);
                cmd.Parameters.AddWithValue(
                    "@SearchPattern",
                    "%" + searchText + "%"
                );

                adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                studentlistcontent.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load students: " + ex.Message);
            }
            finally
            {
                if (adapter != null)
                    adapter.Dispose();

                if (cmd != null)
                    cmd.Dispose();

                conn.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentlist(searchtext.Text.Trim());
        }

        private void searchall_Click(object sender, EventArgs e)
        {
            studentlist(); 
        }
    }
}
