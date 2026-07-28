using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace School_Attendance_System
{

    public partial class verification : Form
    {
        public string MysqlConnection = "server=165.140.202.88;database=school;uid=school;password=Administrator";
        public string otp;
        public string firstname;
        public string lastname;
        public string email;
        public string password;

        public verification(string firstname, string lastname, string email, string password)
        {
            InitializeComponent();
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.password = password;

            generateotp();
            smtpgmail();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void verification_Load(object sender, EventArgs e)
        {

        }

        private void emailbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(MysqlConnection);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();

                if (verificationbox.Text == otp)
                {

                    string querycmd = $"INSERT INTO teachers(first_name,last_name,email,password,register_date) VALUES ('{firstname}','{lastname}','{email}','{password}',now())";

                    cmd = new MySqlCommand(querycmd, conn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successful");
                    mainform mainform = new mainform();
                    this.Hide();
                    mainform.Show();

                }
                else
                {
                    MessageBox.Show("The OTP you entered is incorrect. Please try again.", "Invalid OTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void generateotp()
        {
            Random random = new Random();
            string num1 = random.Next(1, 9).ToString();
            string num2 = random.Next(1, 9).ToString(); ;
            string num3 = random.Next(1, 9).ToString(); ;
            string num4 = random.Next(1, 9).ToString(); ;
            string num5 = random.Next(1, 9).ToString(); ;
            string num6 = random.Next(1, 9).ToString(); ;

            otp = $"{num1}{num2}{num3}{num4}{num5}{num6}";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            generateotp();
            smtpgmail();
        }

        private void smtpgmail()
        {
            emaillabel.Text = email;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("saitoxworld@gmail.com");
            mail.To.Add(email);
            mail.Subject = "Email Verification";
            mail.Body = "Your OTP is: " + otp;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(
                "saitoxworld@gmail.com",
                "hfdnbkoumhekwndj"

                );
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpform signupform = new SignUpform();
            this.Hide();
            signupform.Show();

        }
    }


}
