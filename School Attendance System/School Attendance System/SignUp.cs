using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Attendance_System
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.PlaceholderText = "Email";
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PlaceholderText = "Password";
        }

        private void bntSign_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPass.Text == "" || txtConfirm.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            else if (txtPass.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            else
            {
                MessageBox.Show("Account created successfully!");
            }
        }
    }
}
