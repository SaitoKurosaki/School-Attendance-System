using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Attendance_System
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            CenterToScreen();
            


        }

        private void emailbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpform SignUp = new SignUpform();
            SignUp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
