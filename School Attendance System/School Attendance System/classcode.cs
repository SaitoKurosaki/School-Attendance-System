using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace School_Attendance_System
{
    public partial class ClassCode : UserControl
    {
        public int TeacherID { get; private set; }
        private string classCode = string.Empty;

        public string Connection = "server=165.140.202.88;database=school;uid=school;password=Administrator";
        public ClassCode(int teacherID)
        {
            TeacherID = teacherID;
            InitializeComponent();
            AppTheme.Page(this);
            AppTheme.Title(label1);
            AppTheme.FieldLabel(label2);
            AppTheme.FieldLabel(label3);
            AppTheme.Action(codebtn, "PlusOutlined", primary: true);
            AppTheme.Action(deletebtn, "DeleteOutlined");
            AppTheme.Grid(listcodecontent);
            LoadCourse();
            LoadSection();
            codelist();

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
                listcodecontent.Columns["ID"]!.Visible = false;
                listcodecontent.Columns["COURSE_NAME"].FillWeight = 200;
                foreach ((string column, string header) in new[]
                {
                    ("TEACHER_NAME", "Teacher"), ("COURSE_NAME", "Course"),
                    ("SECTION_NAME", "Section"), ("CLASS_CODE", "Class Code")
                })
                {
                    if (listcodecontent.Columns.Contains(column))
                    {
                        listcodecontent.Columns[column]!.HeaderText = header;
                    }
                }
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
            char[] code = new char[6];
            for (int index = 0; index < code.Length; index++)
            {
                code[index] = letters[RandomNumberGenerator.GetInt32(letters.Length)];
            }

            classCode = new string(code);
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

            try
            {
                using MySqlConnection conn = new MySqlConnection(Connection);
                conn.Open();

                const string existingCodeQuery = @"
                    SELECT CLASS_CODE FROM class_codes
                    WHERE TEACHER_ID = @teacherID AND COURSE_ID = @courseID AND SECTION_ID = @sectionID;";
                using (MySqlCommand existingCodeCommand = new MySqlCommand(existingCodeQuery, conn))
                {
                    existingCodeCommand.Parameters.AddWithValue("@teacherID", TeacherID);
                    existingCodeCommand.Parameters.AddWithValue("@courseID", courseID);
                    existingCodeCommand.Parameters.AddWithValue("@sectionID", sectionID);
                    object? existingCode = existingCodeCommand.ExecuteScalar();
                    if (existingCode != null)
                    {
                        MessageBox.Show(
                            "A class code already exists for this course and section.\n\nClass Code: " + existingCode,
                            "Existing Class Code",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }
                }

                const string codeExistsQuery = "SELECT COUNT(*) FROM class_codes WHERE CLASS_CODE = @code;";
                bool codeIsAvailable = false;
                for (int attempt = 0; attempt < 20; attempt++)
                {
                    generateCode();
                    using MySqlCommand codeExistsCommand = new MySqlCommand(codeExistsQuery, conn);
                    codeExistsCommand.Parameters.AddWithValue("@code", classCode);
                    if (Convert.ToInt32(codeExistsCommand.ExecuteScalar()) == 0)
                    {
                        codeIsAvailable = true;
                        break;
                    }
                }

                if (!codeIsAvailable)
                {
                    throw new InvalidOperationException("Could not generate a unique class code. Please try again.");
                }

                const string insertQuery = @"
                    INSERT INTO class_codes (TEACHER_ID, COURSE_ID, SECTION_ID, CLASS_CODE)
                    VALUES (@teacherID, @courseID, @sectionID, @classCode);";
                using MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn);
                insertCommand.Parameters.AddWithValue("@teacherID", TeacherID);
                insertCommand.Parameters.AddWithValue("@courseID", courseID);
                insertCommand.Parameters.AddWithValue("@sectionID", sectionID);
                insertCommand.Parameters.AddWithValue("@classCode", classCode);
                insertCommand.ExecuteNonQuery();
                codelist();

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
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (listcodecontent.CurrentRow == null)
            {
                MessageBox.Show("Select a class code to remove.", "Class Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int classCodeId = Convert.ToInt32(listcodecontent.CurrentRow.Cells["ID"].Value);
            string classCode = listcodecontent.CurrentRow.Cells["CLASS_CODE"].Value?.ToString() ?? string.Empty;

            DialogResult confirm = MessageBox.Show(
                "Remove class code " + classCode + "?\n\nStudents enrolled with this code will be unenrolled and its attendance records will be deleted.",
                "Remove Class Code",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            const string unenrollQuery = @"
                UPDATE students
                SET classcode = JSON_REMOVE(classcode, JSON_UNQUOTE(JSON_SEARCH(classcode, 'one', @code)))
                WHERE JSON_CONTAINS(classcode, JSON_QUOTE(@code));";
            const string deleteQuery = "DELETE FROM class_codes WHERE ID = @id AND TEACHER_ID = @teacherID;";

            try
            {
                using MySqlConnection conn = new MySqlConnection(Connection);
                conn.Open();
                using MySqlTransaction transaction = conn.BeginTransaction();

                using (MySqlCommand unenroll = new MySqlCommand(unenrollQuery, conn, transaction))
                {
                    unenroll.Parameters.AddWithValue("@code", classCode);
                    unenroll.ExecuteNonQuery();
                }

                int affected;
                using (MySqlCommand delete = new MySqlCommand(deleteQuery, conn, transaction))
                {
                    delete.Parameters.AddWithValue("@id", classCodeId);
                    delete.Parameters.AddWithValue("@teacherID", TeacherID);
                    affected = delete.ExecuteNonQuery();
                }

                if (affected == 0)
                {
                    transaction.Rollback();
                    codelist();
                    MessageBox.Show("That class code no longer belongs to you.", "Remove Class Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                transaction.Commit();
                codelist();
                MessageBox.Show("Class code " + classCode + " removed.", "Remove Class Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to remove class code: " + ex.Message);
            }
        }
    }
}
