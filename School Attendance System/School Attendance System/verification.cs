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
            mail.IsBodyHtml = true;
            
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(
                "saitoxworld@gmail.com",
                "hfdnbkoumhekwndj"

                );
            smtp.EnableSsl = true;
            mail.Body = $@"<!doctype html>
<html>
  <head>
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
  </head>

  <body
    style=""
      margin: 0;
      padding: 0;
      background-color: #f4f4f5;
      font-family: Arial, Helvetica, sans-serif;
    ""
  >
    <table
      width=""100%""
      cellpadding=""0""
      cellspacing=""0""
      style=""padding: 40px 15px""
    >
      <tr>
        <td align=""center"">
          <table
            width=""100%""
            cellpadding=""0""
            cellspacing=""0""
            style=""
              max-width: 500px;
              background-color: #ffffff;
              border-radius: 12px;
              overflow: hidden;
            ""
          >
            <tr>
              <td
                style=""
                  background-color: #0066cc;
                  padding: 25px;
                  text-align: center;
                ""
              >
                <h1 style=""margin: 0; color: #ffffff; font-size: 24px"">
                  School Attendance System
                </h1>
              </td>
            </tr>

           
            <tr>
              <td style=""padding: 35px 30px"">
                <h2 style=""margin: 0 0 15px 0; color: #222222; font-size: 22px"">
                  Email Verification
                </h2>

                <p
                  style=""
                    margin: 0 0 25px 0;
                    color: #666666;
                    font-size: 15px;
                    line-height: 1.6;
                  ""
                >
                  Please verify your email address by entering the verification code below to complete your registration.

                </p>

               
                <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
                  <tr>
                    <td
                      align=""center""
                      style=""
                        background-color: #f3f4f6;
                        border-radius: 10px;
                        padding: 20px;
                      ""
                    >
                      <div
                        style=""
                          color: #111111;
                          font-size: 32px;
                          font-weight: bold;
                          letter-spacing: 8px;
                        ""
                      >
                        {otp}
                      </div>
                    </td>
                  </tr>
                </table>

                <p
                  style=""
                    margin: 25px 0 0 0;
                    color: #777777;
                    font-size: 13px;
                    text-align: center;
                  ""
                >
                  Enter this code in the verification screen.
                </p>

                <p
                  style=""
                    margin: 25px 0 0 0;
                    color: #999999;
                    font-size: 12px;
                    line-height: 1.5;
                  ""
                >
                  If you did not request this verification code, you can safely
                  ignore this email.
                </p>
              </td>
            </tr>

           
            <tr>
              <td
                style=""
                  background-color: #f9fafb;
                  padding: 20px;
                  text-align: center;
                ""
              >
                <p style=""margin: 0; color: #999999; font-size: 12px"">
                  © 2026 BSCS. All rights reserved.
                </p>
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
  </body>
</html>
";
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
