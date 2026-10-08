using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Attendance_System
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
            LoadUserControl(new manueldashboard());
            
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new manueldashboard());
        }
        private void LoadUserControl(UserControl userControl)
        {
            contentPanel.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            contentPanel.Controls.Add(userControl);
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            LoadUserControl(new manuelstudents());
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            LoadUserControl(new attendance());
        }

        private void btnClasscode_Click(object sender, EventArgs e)
        {
            LoadUserControl(new classcode());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadUserControl(new reports());
        }

        private void contentPanel_Click(object sender, EventArgs e)
        {

        }
    }
}

