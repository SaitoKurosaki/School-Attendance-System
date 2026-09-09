using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Attendance_System
{
    public partial class Dashboard : Form
    {
        private Button currentButton = null;

        public Dashboard()
        {
            InitializeComponent();
            sidebar.BackColor = Color.FromArgb(15, 23, 42);
            SelectButton(btnDashboard);
            btnDashboard.Image = new Bitmap(btnDashboard.Image, new Size(32, 32));
            btnStudents.Image = new Bitmap(btnStudents.Image, new Size(32, 32));
            btnDashboard.Image = new Bitmap(btnAttendance.Image, new Size(32, 32));
            btnStudents.Image = new Bitmap(btnLogout.Image, new Size(32, 32));
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectButton(btnStudents);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SelectButton(btnDashboard);
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != currentButton)
                btn.BackColor = Color.FromArgb(30, 41, 59);
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != currentButton)
                btn.BackColor = Color.FromArgb(15, 23, 42);
        }
        private void SelectButton(Button btn)
        {

            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(15, 23, 42);
                currentButton.ForeColor = Color.RoyalBlue;
            }

            currentButton = btn;
            currentButton.BackColor = Color.FromArgb(59, 130, 246);
            currentButton.ForeColor = Color.White;
        }

        private void btnStudents_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != currentButton)
                btn.BackColor = Color.FromArgb(30, 41, 59);
        }

        private void btnStudents_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != currentButton)
                btn.BackColor = Color.FromArgb(15, 23, 42);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            SelectButton(btnAttendance);
        }

        private void btnAttendance_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != currentButton)
                btn.BackColor = Color.FromArgb(30, 41, 59);
        }

        private void btnAttendance_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != currentButton)
                btn.BackColor = Color.FromArgb(15, 23, 42);
        }
    }
}
