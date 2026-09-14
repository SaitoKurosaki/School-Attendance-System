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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string StudentID = txtStudentID.Text;
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string GradeSection = cbGradeSection.Text;
            string Parentemail = txtParentEmail.Text;

            //MySQL code here:

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
