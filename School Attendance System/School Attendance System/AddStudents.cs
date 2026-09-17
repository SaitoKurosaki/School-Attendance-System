using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace School_Attendance_System
{
    public partial class AddStudents : Form
    {
        string connectionString = "Server=localhost;Database=addstudent;Uid=root;Pwd=123456;";
        public AddStudents()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddStudents_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string StudentID = txtStudentID.Text;
            string FirstName = txtFirstName.Text;
            string MiddleName = txtMiddleName.Text;
            string LastName = txtLastName.Text;
            string GradeSection = cbGradeSection.Text;
            string Parentemail = txtParentEmail.Text;

            string query = @"INSERT INTO addstudent (student_id, first_name, middle_name, last_name, grade_section, parent_email) VALUES
                           (@StudentID, @FirstName, @MiddleName, @LastName, @GradeSection, @ParentEmail)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", StudentID);
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@MiddleName", MiddleName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@GradeSection", GradeSection);
                        cmd.Parameters.AddWithValue("@ParentEmail", Parentemail);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Student saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
