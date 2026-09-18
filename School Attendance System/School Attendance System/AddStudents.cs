using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
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
            string ParentEmail = txtParentEmail.Text;

            if (string.IsNullOrWhiteSpace(StudentID))
            {
                MessageBox.Show("Student ID is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                MessageBox.Show("First Name is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(MiddleName))
            {
                MessageBox.Show("Middle Name is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(LastName))
            {
                MessageBox.Show("Last Name is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(GradeSection))
            {
                MessageBox.Show("Grade / Section is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(ParentEmail))
            {
                MessageBox.Show("Parent Email is required.");
                return;
            }

            if (!Regex.IsMatch(StudentID, @"^[0-9]+$"))
            {
                MessageBox.Show("Student ID must contain numbers only.");
                return;
            }

            ParentEmail = ParentEmail.ToLower();

            if (!Regex.IsMatch(ParentEmail, @"^[a-z0-9._%+-]+@[+a-z0-9.-]+\.[a-z]{2,}$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }


            string query = @"INSERT INTO addstudent (student_id, first_name, middle_name, last_name, grade_section, parent_email) VALUES
                           (@StudentID, @FirstName, @MiddleName, @LastName, @GradeSection, @ParentEmail)";

            string checkQuery = "SELECT COUNT(*) FROM addstudent WHERE student_id = @StudentID";


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
            try
            {
                conn.Open();

                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@StudentID", StudentID);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Student ID already exists.");
                        return;
                    }
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@MiddleName", MiddleName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@GradeSection", GradeSection);
                    cmd.Parameters.AddWithValue("@ParentEmail", ParentEmail);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Student saved successfully!");

                    txtStudentID.Clear();
                    txtFirstName.Clear();
                    txtMiddleName.Clear();
                    txtLastName.Clear();
                    cbGradeSection.SelectedIndex = -1;
                    txtParentEmail.Clear();
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
