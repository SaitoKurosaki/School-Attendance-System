using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Threading.Tasks;
namespace School_Attendance_System
{

    public partial class Verification : Form
    {
        private const string Connection = "server=165.140.202.88;database=school;uid=school;password=Administrator";
        public string otp = string.Empty;
        public string firstname = string.Empty;
        public string lastname = string.Empty;
        public string email = string.Empty;
        public string password = string.Empty;
        private DateTime otpExpiresAt;

       
        private volatile string? mailError;

        public Verification(string firstname, string lastname, string email, string password)
        {
            InitializeComponent();
            AuthWindowPlacement.Apply(this);
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.password = password;

            Shown += (_, _) => ReportMailError();
            generateotp();
            smtpgmail();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.UtcNow > otpExpiresAt)
                {
                    MessageBox.Show("This verification code has expired. Request a new code and try again.", "Verification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!string.Equals(verificationbox.Text.Trim(), otp, StringComparison.Ordinal))
                {
                    MessageBox.Show("The OTP you entered is incorrect. Please try again.", "Invalid OTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using MySqlConnection conn = new MySqlConnection(Connection);
                conn.Open();
                const string query = @"INSERT INTO teachers(first_name, last_name, email, password, register_date)
                    VALUES (@firstName, @lastName, @email, @password, NOW());";
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstName", firstname);
                cmd.Parameters.AddWithValue("@lastName", lastname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword(password));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration successful.", "Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AuthWindowPlacement.Remember(this);
                Hide();
                Login.ShowLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void generateotp()
        {
            otp = RandomNumberGenerator.GetInt32(100000, 1000000).ToString();
            otpExpiresAt = DateTime.UtcNow.AddMinutes(10);
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
           
            _ = Task.Run(() =>
            {
                try
                {
                    using SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                    {
                        Credentials = new NetworkCredential("saitoxworld@gmail.com", "rhbxxnbfhvrftxik"),
                        EnableSsl = true
                    };
                    smtp.Send(mail);
                }
                catch (Exception ex)
                {
                    mailError = ex.Message;
                    if (IsHandleCreated) BeginInvoke(new Action(ReportMailError));
                }
                finally
                {
                    mail.Dispose();
                }
            });
        }

        private void ReportMailError()
        {
            string? error = mailError;
            if (error == null) return;
            mailError = null;
            MessageBox.Show(this, "The verification email could not be sent: " + error, "Verification",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signupform = new SignUp();
            AuthWindowPlacement.Remember(this);
            this.Hide();
            signupform.Show();

        }
    }


}
