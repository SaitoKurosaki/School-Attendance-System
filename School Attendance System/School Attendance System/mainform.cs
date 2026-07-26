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
        public string MysqlConnection = "server=localhost;database=school;uid=school;password=Administrator";
        public string email;
        public string password;
        public mainform()
        {
            InitializeComponent();
            CenterToScreen();


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
            MySqlConnection conn = new MySqlConnection(MysqlConnection);
            try
            {
                conn.Open();
                string querycmd = $"SELECT email FROM teachers WHERE email = '{email}'";
                MySqlCommand cmd = new MySqlCommand(querycmd, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();
                    string emailandpass = $"SELECT email FROM teachers WHERE email = '{email}' AND password = '{password}'";
                    cmd = new MySqlCommand(emailandpass, conn);
                    reader = cmd.ExecuteReader();

                    if (reader.Read()) 
                    {
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }
                }
                else
                {
                    MessageBox.Show("Email not found");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            password = passwordbox.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                passwordbox.PasswordChar = '\0';
            }
            else
            {
                passwordbox.PasswordChar = '*';
            }
        }
    }
}
