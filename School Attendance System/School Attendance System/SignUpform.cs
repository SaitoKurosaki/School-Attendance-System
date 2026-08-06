using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System.Net;
using System.Net.Mail;
namespace School_Attendance_System
{
    public partial class SignUpform : Form
    {
        public string MysqlConnection = "server=165.140.202.88;database=school;uid=school;password=Administrator";
        public string first_name;
        public string last_name;
        public string email;
        public string password;

        public string confirm;

        public string otp;

        public SignUpform()
        {
            InitializeComponent();
            CenterToScreen();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            mainform MainForm = new mainform();
            MainForm.Show();
        }

        private void emailbox_TextChanged(object sender, EventArgs e)
        {
            first_name = firstnamebox.Text;
        }

        private void lastnamebox_TextChanged(object sender, EventArgs e)
        {
            last_name = lastnamebox.Text;
        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {
            password = passwordbox.Text;
        }

        private void emailbox_TextChanged_1(object sender, EventArgs e)
        {
            email = emailbox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(MysqlConnection);




            try
            {
                if (firstnamebox.Text == "" || lastnamebox.Text == "" || emailbox.Text == "" || passwordbox.Text == "" || confirmbox.Text == "")
                {
                    MessageBox.Show("Please make sure you fill in all the fields.");
                }
                else
                {
                    if (passwordbox.Text != confirmbox.Text)
                    {
                        MessageBox.Show("Password and confirm password do not match.");
                    }
                    else
                    {
                        try
                        {
                            conn.Open();
                            string query = $"SELECT email FROM teachers WHERE email = '{email}'";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            MySqlDataReader reader = cmd.ExecuteReader();

                            if (reader.Read())
                            {
                                MessageBox.Show("The email address you entered is already associated with an existing account");
                            }
                            else
                            {


                                verification veriform = new verification(first_name, last_name, email, password);
                                this.Hide();
                                veriform.Show();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void confirmbox_TextChanged(object sender, EventArgs e)
        {
            confirm = confirmbox.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
