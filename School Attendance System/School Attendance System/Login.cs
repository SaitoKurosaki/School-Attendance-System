using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;




namespace School_Attendance_System
{
    public partial class Login : Form
    {
        private const string MysqlConnection = "server=165.140.202.88;database=school;uid=school;password=Administrator";
        public string email = string.Empty;
        public string password = string.Empty;
        public Login()
        {
            InitializeComponent();
            AuthWindowPlacement.Apply(this);
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthWindowPlacement.Remember(this);
            this.Hide();
            SignUp SignUp = new SignUp();
            SignUp.Show();
        }




        internal static void ShowLogin()
        {
            Login login = Application.OpenForms.OfType<Login>().FirstOrDefault() ?? new Login();
            login.ResetForNewSignIn();
            login.Show();
            login.BringToFront();
            login.Activate();
        }

        private void ResetForNewSignIn()
        {
            email = string.Empty;
            password = string.Empty;
            emailbox.Text = string.Empty;
            passwordbox.Text = string.Empty;
            showpass.Checked = false;
            passwordbox.PasswordChar = '*';
        }

        private void emailbox_TextChanged_1(object sender, EventArgs e)
        {
            email = emailbox.Text;
        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {
            password = passwordbox.Text;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            email = emailbox.Text.Trim();
            password = passwordbox.Text;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter both your email and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(MysqlConnection))
            {
                try
                {
                    conn.Open();
                    const string query = @"
                        SELECT t.ID, t.password, r.ROLE_NAME
                        FROM teachers t INNER JOIN roles r ON r.ID = t.ROLE_ID
                        WHERE t.email = @email LIMIT 1;";
                    using MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@email", email);

                    int teacherId;
                    string storedHash;
                    string role;
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Invalid email or password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        teacherId = reader.GetInt32(0);
                        storedHash = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                        role = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    }

                    if (!VerifyPassword(password, storedHash))
                    {
                        MessageBox.Show("Invalid email or password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    MainDashboard mainDashboard = new MainDashboard(teacherId, role, email);
                    mainDashboard.Show();
                    Hide();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Unable to connect to the school database. Please try again later.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static bool VerifyPassword(string password, string storedHash)
        {
            if (string.IsNullOrEmpty(storedHash))
            {
                return false;
            }

            try
            {
                return BCrypt.Net.BCrypt.Verify(password, storedHash);
            }
            catch (BCrypt.Net.SaltParseException)
            {
                
                return false;
            }
        }

        private void showpass_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            if (showpass.Checked)
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
