using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace School_Attendance_System
{
    public partial class classcode : UserControl
    {
        public int TeacherID { get; private set; }
        private string classCode;
        private Random random = new Random();

        public string Connection = "server=localhost;database=school;uid=school;password=Administrator";
        public classcode(int teacherID)
        {
            InitializeComponent();
            LoadCourse();
            LoadSection();
            TeacherID = teacherID;
            codelist();

        }

        private void recentAttendanceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void LoadSection()
        {
            MySqlConnection conn = new MySqlConnection(Connection);
            MySqlDataAdapter adapter = null;

            try
            {
                string query = "SELECT * FROM section";

                adapter = new MySqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                sectioncombo.DataSource = dt;
                sectioncombo.DisplayMember = "SECTION_NAME";
                sectioncombo.ValueMember = "ID";
                sectioncombo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load courses: " + ex.Message);
            }
            finally
            {
                if (adapter != null)
                {
                    adapter.Dispose();
                }

                conn.Dispose();
            }

        }

        private void LoadCourse()
        {
            MySqlConnection conn = new MySqlConnection(Connection);
            MySqlDataAdapter adapter = null;

            try
            {
                string query = "SELECT * FROM Course";

                adapter = new MySqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                coursecombo.DataSource = dt;
                coursecombo.DisplayMember = "COURSE_NAME";
                coursecombo.ValueMember = "ID";
                coursecombo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load courses: " + ex.Message);
            }
            finally
            {
                if (adapter != null)
                {
                    adapter.Dispose();
                }

                conn.Dispose();
            }
        }

        private void codelist()
        {
            MySqlConnection conn = new MySqlConnection(Connection);
            MySqlDataAdapter adapter = null;
            MySqlCommand cmd = null;

            try
            {
                string query = @"
            SELECT
                cc.ID,
                CONCAT(t.FIRST_NAME, ' ', t.LAST_NAME) AS TEACHER_NAME,
                c.COURSE_NAME,
                s.SECTION_NAME,
                cc.CLASS_CODE
            FROM class_codes cc
            INNER JOIN teachers t ON cc.TEACHER_ID = t.ID
            INNER JOIN course c ON cc.COURSE_ID = c.ID
            INNER JOIN section s ON cc.SECTION_ID = s.ID
            WHERE cc.TEACHER_ID = @TeacherID
        ";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TeacherID", TeacherID);

                adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                listcodecontent.DataSource = dt;
                foreach (DataGridViewColumn column in listcodecontent.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                listcodecontent.Columns["COURSE_NAME"].FillWeight = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load courses: " + ex.Message);
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
        private void generateCode()
        {
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string char1 = letters[random.Next(letters.Length)].ToString();
            string char2 = letters[random.Next(letters.Length)].ToString();
            string char3 = letters[random.Next(letters.Length)].ToString();
            string char4 = letters[random.Next(letters.Length)].ToString();
            string char5 = letters[random.Next(letters.Length)].ToString();
            string char6 = letters[random.Next(letters.Length)].ToString();

            classCode = $"{char1}{char2}{char3}{char4}{char5}{char6}";
        }

        private void codebtn_Click(object sender, EventArgs e)
        {
            if (coursecombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            if (sectioncombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a section.");
                return;
            }

            int courseID = Convert.ToInt32(coursecombo.SelectedValue);
            int sectionID = Convert.ToInt32(sectioncombo.SelectedValue);

            MySqlConnection conn = new MySqlConnection(Connection);

            try
            {
                conn.Open();

                bool isUnique = false;

                while (!isUnique)
                {
                    generateCode();

                    string checkQuery =
                        "SELECT COUNT(*) FROM class_codes WHERE CLASS_CODE = @code";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@code", classCode);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        isUnique = true;
                    }
                }

                string insertQuery = @"
            INSERT INTO class_codes
            (TEACHER_ID, COURSE_ID, SECTION_ID, CLASS_CODE)
            VALUES
            (@teacherID, @courseID, @sectionID, @classCode)";

                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);

                insertCmd.Parameters.AddWithValue("@teacherID", TeacherID);
                insertCmd.Parameters.AddWithValue("@courseID", courseID);
                insertCmd.Parameters.AddWithValue("@sectionID", sectionID);
                insertCmd.Parameters.AddWithValue("@classCode", classCode);

                insertCmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Class code generated successfully!\n\n" +
                    "Class Code: " + classCode,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate class code: " + ex.Message);
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}
