using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Attendance_System
{
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter your Username.");
                return;
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Please enter your Password");
                return;
            }
            else
            {
                MessageBox.Show("You're successfully login!");
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void lnkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
