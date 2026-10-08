namespace School_Attendance_System
{
    partial class MainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new AntdUI.Panel();
            buttonShadow5 = new AntdUI.ButtonShadow();
            btnReports = new AntdUI.ButtonShadow();
            btnClasscode = new AntdUI.ButtonShadow();
            btnAttendance = new AntdUI.ButtonShadow();
            btnStudents = new AntdUI.ButtonShadow();
            btnDashboard = new AntdUI.ButtonShadow();
            contentPanel = new AntdUI.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonShadow5);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnClasscode);
            panel1.Controls.Add(btnAttendance);
            panel1.Controls.Add(btnStudents);
            panel1.Controls.Add(btnDashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 586);
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            // 
            // buttonShadow5
            // 
            buttonShadow5.Location = new Point(12, 532);
            buttonShadow5.Name = "buttonShadow5";
            buttonShadow5.Size = new Size(98, 42);
            buttonShadow5.TabIndex = 5;
            buttonShadow5.Text = "Logout";
            // 
            // btnReports
            // 
            btnReports.Location = new Point(29, 365);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(140, 42);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.Click += btnReports_Click;
            // 
            // btnClasscode
            // 
            btnClasscode.Location = new Point(29, 305);
            btnClasscode.Name = "btnClasscode";
            btnClasscode.Size = new Size(140, 42);
            btnClasscode.TabIndex = 3;
            btnClasscode.Text = "Class Code";
            btnClasscode.Click += btnClasscode_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.Location = new Point(29, 234);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(140, 42);
            btnAttendance.TabIndex = 2;
            btnAttendance.Text = "Attendance";
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnStudents
            // 
            btnStudents.Location = new Point(29, 171);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(140, 42);
            btnStudents.TabIndex = 1;
            btnStudents.Text = "Students";
            btnStudents.Click += btnStudents_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(29, 110);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(140, 42);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.Click += btnDashboard_Click;
            // 
            // contentPanel
            // 
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(200, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(926, 586);
            contentPanel.TabIndex = 1;
            contentPanel.Text = "panel2";
            contentPanel.Click += contentPanel_Click;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 586);
            Controls.Add(contentPanel);
            Controls.Add(panel1);
            Name = "MainDashboard";
            Text = "DashboardManuel";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.Panel contentPanel;
        private AntdUI.ButtonShadow buttonShadow5;
        private AntdUI.ButtonShadow btnReports;
        private AntdUI.ButtonShadow btnClasscode;
        private AntdUI.ButtonShadow btnAttendance;
        private AntdUI.ButtonShadow btnStudents;
        private AntdUI.ButtonShadow btnDashboard;
    }
}