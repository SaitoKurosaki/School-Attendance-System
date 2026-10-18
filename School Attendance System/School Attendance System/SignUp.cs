using MySql.Data.MySqlClient;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace School_Attendance_System
{
    public partial class SignUp : Form
    {
        private const string MysqlConnection = "server=165.140.202.88;database=school;uid=school;password=Administrator";

        public SignUp()
        {
            InitializeComponent();
            AuthWindowPlacement.Apply(this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthWindowPlacement.Remember(this);
            Hide();
            Login.ShowLogin();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string fullName = fullnamebox.Text.Trim();
            string email = emailbox.Text.Trim();
            string password = passwordbox.Text;
            string confirmPassword = confirmpassbox.Text;

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please complete every field.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Enter a valid email address.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and confirm password do not match.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] names = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (names.Length < 2)
            {
                MessageBox.Show("Enter both your first name and last name.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using MySqlConnection connection = new MySqlConnection(MysqlConnection);
                using MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM teachers WHERE email = @email;", connection);
                command.Parameters.AddWithValue("@email", email);
                connection.Open();
                if (Convert.ToInt32(command.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("That email address is already registered.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Unable to connect to the school database. Please try again later.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string firstName = names[0];
            string lastName = string.Join(" ", names, 1, names.Length - 1);
            Verification verificationForm = new Verification(firstName, lastName, email, password);
            AuthWindowPlacement.Remember(this);
            Hide();
            verificationForm.Show();
        }

        private static bool IsValidEmail(string email)
        {
            try { _ = new MailAddress(email); return true; }
            catch (FormatException) { return false; }
        }

        private void showpass_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            char mask = showpass.Checked ? '\0' : '*';
            passwordbox.PasswordChar = mask;
            confirmpassbox.PasswordChar = mask;
        }
    }
}
