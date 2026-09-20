using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.Xml.XPath;

namespace School_Attendance_System
{
    public partial class Dashboard : Form
    {
        private Button currentButton = null;
        private bool sidebarCollapse = false;

        private void OpenForm(Form form)
        {
            Content.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            Content.Controls.Add(form);
            form.Show();
        }

        public Dashboard()
        {
            InitializeComponent();
            sidebar.BackColor = Color.FromArgb(243, 246, 250);
            SelectButton(btnDashboard);
            btnDashboard.Image = new Bitmap(btnDashboard.Image!, new Size(50, 50));
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudents.Image = new Bitmap(btnStudents.Image!, new Size(50, 50));
            btnStudents.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Image = new Bitmap(btnAttendance.Image!, new Size(50, 50));
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Image = new Bitmap(btnLogout.Image!, new Size(50, 50));
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;

            btnDashboard.BackColor = Color.FromArgb(243, 246, 250);
            btnDashboard.ForeColor = Color.FromArgb(38, 50, 56);
            btnStudents.BackColor = Color.FromArgb(243, 246, 250);
            btnStudents.ForeColor = Color.FromArgb(38, 50, 56);
            btnAttendance.BackColor = Color.FromArgb(243, 246, 250);
            btnAttendance.ForeColor = Color.FromArgb(38, 50, 56);
            btnCollapse.Image = new Bitmap(btnCollapse.Image!, new Size(50, 50));

            DSBHeader.BackColor = Color.FromArgb(23, 37, 84);
            Content.BackColor = Color.FromArgb(244, 247, 251);
        }
        private void SelectButton(Button btn)
        {

            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(243, 246, 250);
                currentButton.ForeColor = Color.FromArgb(38, 50, 56);
            }

            currentButton = btn;
            currentButton.BackColor = Color.FromArgb(210, 231, 255);
            currentButton.ForeColor = Color.FromArgb(0, 74, 143);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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
                btn.BackColor = Color.FromArgb(227, 240, 255);
            btn.ForeColor = Color.FromArgb(0, 87, 168);
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != currentButton)
                btn.BackColor = Color.FromArgb(243, 246, 250);
            btn.ForeColor = Color.FromArgb(38, 50, 56);
        }

        private void btnStudents_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != currentButton)
                btn.BackColor = Color.FromArgb(227, 240, 255);
            btn.ForeColor = Color.FromArgb(0, 87, 168);
        }

        private void btnStudents_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != currentButton)
                btn.BackColor = Color.FromArgb(243, 246, 250);
            btn.ForeColor = Color.FromArgb(38, 50, 56);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            OpenForm(new AttendanceForm());
            SelectButton(btnAttendance);
        }

        private void btnAttendance_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != currentButton)
                btn.BackColor = Color.FromArgb(227, 240, 255);
            btn.ForeColor = Color.FromArgb(0, 87, 168);
        }

        private void btnAttendance_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != currentButton)
                btn.BackColor = Color.FromArgb(243, 246, 250);
            btn.ForeColor = Color.FromArgb(38, 50, 56);
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            OpenForm(new Students());
            SelectButton(btnStudents);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnCollapse.Image != null)
            {
                Bitmap flipped = new Bitmap(btnCollapse.Image);
                flipped.RotateFlip(RotateFlipType.RotateNoneFlipX);
                btnCollapse.Image = flipped;
            }
            if (sidebarCollapse)
            {
                sidebar.Width = 214;
                btnAttendance.Text = "Attendance";
                btnStudents.Text = "Students";
                btnDashboard.Text = "Dashboard";
                btnLogout.Text = "Logout";
                btnCollapse.Location = new Point(166, 6);
                sidebarCollapse = false;
                Content.Width = 871;
                Content.Location = new Point(213, 53);
            }
            else
            {
                sidebar.Width = 65;
                btnAttendance.Text = "";
                btnStudents.Text = "";
                btnDashboard.Text = "";
                btnLogout.Text = "";
                btnCollapse.Location = new Point(15,6);
                sidebarCollapse = true;
                Content.Width = 1020;
                Content.Location = new Point(64, 53);
            }
        }
    }
}
