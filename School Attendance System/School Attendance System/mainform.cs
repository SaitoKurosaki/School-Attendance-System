using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;


namespace School_Attendance_System
{
    public partial class mainform : Form
    {
        public string email;
        string password;
        public mainform()
        {
            InitializeComponent();
            CenterToScreen();

            string MysqlConnection = "server=localhost;database=school;uid=school;password=Administrator";

            MySqlConnection conn = new MySqlConnection(MysqlConnection);

            try
            {
                conn.Open();
            }

            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void emailbox_TextChanged(object sender, EventArgs e)
        {
            email = emailbox.Text;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpform SignUp = new SignUpform();
            SignUp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            password = passwordbox.Text;        }
    }
}
