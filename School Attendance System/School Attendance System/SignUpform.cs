using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Attendance_System
{
    public partial class SignUpform : Form
    {
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
    }
}
