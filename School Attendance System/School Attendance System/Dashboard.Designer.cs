namespace School_Attendance_System
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            sidebar = new Panel();
            btnCollapse = new Button();
            btnLogout = new Button();
            btnAttendance = new Button();
            btnDashboard = new Button();
            btnStudents = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            Content = new Panel();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            toolTip1 = new ToolTip(components);
            DSBHeader = new Panel();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            DSBHeader.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.Control;
            sidebar.Controls.Add(btnCollapse);
            sidebar.Controls.Add(btnLogout);
            sidebar.Controls.Add(btnAttendance);
            sidebar.Controls.Add(btnDashboard);
            sidebar.Controls.Add(btnStudents);
            sidebar.Location = new Point(0, -1);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(214, 607);
            sidebar.TabIndex = 0;
            sidebar.Paint += panel1_Paint;
            // 
            // btnCollapse
            // 
            btnCollapse.Cursor = Cursors.Hand;
            btnCollapse.FlatAppearance.BorderSize = 0;
            btnCollapse.FlatStyle = FlatStyle.Flat;
            btnCollapse.Image = (Image)resources.GetObject("btnCollapse.Image");
            btnCollapse.Location = new Point(166, 6);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new Size(45, 46);
            btnCollapse.TabIndex = 8;
            btnCollapse.UseVisualStyleBackColor = true;
            btnCollapse.Click += button1_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.HotTrack;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(3, 549);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(184, 46);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Log-out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(btnLogout, "Log-out");
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button6_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackgroundImageLayout = ImageLayout.Zoom;
            btnAttendance.Cursor = Cursors.Hand;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttendance.ForeColor = SystemColors.HotTrack;
            btnAttendance.Image = (Image)resources.GetObject("btnAttendance.Image");
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Location = new Point(3, 242);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(184, 46);
            btnAttendance.TabIndex = 5;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(btnAttendance, "View Attendance");
            btnAttendance.UseVisualStyleBackColor = true;
            btnAttendance.Click += btnAttendance_Click;
            btnAttendance.MouseEnter += btnAttendance_MouseEnter;
            btnAttendance.MouseLeave += btnAttendance_MouseLeave;
            // 
            // btnDashboard
            // 
            btnDashboard.BackgroundImageLayout = ImageLayout.Zoom;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.HotTrack;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 138);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(184, 46);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(btnDashboard, "Dashboard");
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.MouseEnter += btnDashboard_MouseEnter;
            btnDashboard.MouseLeave += btnDashboard_MouseLeave;
            // 
            // btnStudents
            // 
            btnStudents.BackgroundImageLayout = ImageLayout.Zoom;
            btnStudents.Cursor = Cursors.Hand;
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudents.ForeColor = SystemColors.HotTrack;
            btnStudents.Image = (Image)resources.GetObject("btnStudents.Image");
            btnStudents.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudents.Location = new Point(3, 190);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(184, 46);
            btnStudents.TabIndex = 3;
            btnStudents.Text = "Students";
            btnStudents.TextAlign = ContentAlignment.MiddleLeft;
            btnStudents.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(btnStudents, "Students");
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            btnStudents.MouseEnter += btnStudents_MouseEnter;
            btnStudents.MouseLeave += btnStudents_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(277, 14);
            label3.Name = "label3";
            label3.Size = new Size(294, 25);
            label3.TabIndex = 11;
            label3.Text = "SCHOOL ATTENDANCE SYSTEM";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(220, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 47);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Content
            // 
            Content.BackColor = SystemColors.Control;
            Content.Location = new Point(213, 53);
            Content.Name = "Content";
            Content.Size = new Size(871, 553);
            Content.TabIndex = 4;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // DSBHeader
            // 
            DSBHeader.Controls.Add(pictureBox1);
            DSBHeader.Controls.Add(label3);
            DSBHeader.Location = new Point(0, -1);
            DSBHeader.Name = "DSBHeader";
            DSBHeader.Size = new Size(1084, 55);
            DSBHeader.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 606);
            Controls.Add(sidebar);
            Controls.Add(DSBHeader);
            Controls.Add(Content);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            DSBHeader.ResumeLayout(false);
            DSBHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnLogout;
        private Button btnAttendance;
        private Button btnStudents;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ToolTip toolTip1;
        private Label label3;
        private Panel Content;
        private Panel DSBHeader;
        private Button btnCollapse;
    }
}