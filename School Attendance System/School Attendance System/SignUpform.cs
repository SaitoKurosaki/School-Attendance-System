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
        public string full_name, email, password, confirm, otp;


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

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(MysqlConnection);




            try
            {
                if (fullnamebox.Text == "" || emailbox.Text == "" || passwordbox.Text == "" || confirmpassbox.Text == "")
                {
                    MessageBox.Show("Please make sure you fill in all the fields.");
                }
                else
                {
                    if (passwordbox.Text != confirmpassbox.Text)
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


                                /*verification veriform = new verification(full_name, email, password);
                                this.Hide();
                                veriform.Show();*/
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void showpass_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            if (showpass.Checked)
            {
                passwordbox.PasswordChar = '\0';
                confirmpassbox.PasswordChar = '\0';
            }
            else
            {
                passwordbox.PasswordChar = '*';
                confirmpassbox.PasswordChar = '\0';
            }
        }

        private void input2_TextChanged(object sender, EventArgs e)
        {
            full_name = fullnamebox.Text;
        }

        private void emailbox_TextChanged(object sender, EventArgs e)
        {
            email = emailbox.Text;
        }

        private void passwordbox_TextChanged_1(object sender, EventArgs e)
        {
            password = passwordbox.Text;
        }

        private void confirmpassbox_TextChanged(object sender, EventArgs e)
        {
            confirm = confirmpassbox.Text;
        }
    }
}
