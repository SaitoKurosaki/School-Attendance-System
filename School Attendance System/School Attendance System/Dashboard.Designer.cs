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
            label4 = new Label();
            btnLogout = new Button();
            label3 = new Label();
            btnAttendance = new Button();
            btnStudents = new Button();
            btnDashboard = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            button7 = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            toolTip1 = new ToolTip(components);
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.Control;
            sidebar.Controls.Add(label4);
            sidebar.Controls.Add(btnLogout);
            sidebar.Controls.Add(label3);
            sidebar.Controls.Add(btnAttendance);
            sidebar.Controls.Add(btnStudents);
            sidebar.Controls.Add(btnDashboard);
            sidebar.Controls.Add(pictureBox1);
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(3, 4, 3, 4);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(282, 721);
            sidebar.TabIndex = 0;
            sidebar.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(87, 135);
            label4.Name = "label4";
            label4.Size = new Size(105, 32);
            label4.TabIndex = 12;
            label4.Text = "SYSTEM";
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnLogout.ForeColor = SystemColors.HotTrack;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(10, 629);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(240, 76);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Log-out";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(btnLogout, "Log-out");
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(3, 101);
            label3.Name = "label3";
            label3.Size = new Size(272, 32);
            label3.TabIndex = 11;
            label3.Text = "SCHOOL ATTENDANCE";
            // 
            // btnAttendance
            // 
            btnAttendance.BackgroundImageLayout = ImageLayout.Zoom;
            btnAttendance.Cursor = Cursors.Hand;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnAttendance.ForeColor = SystemColors.HotTrack;
            btnAttendance.Image = (Image)resources.GetObject("btnAttendance.Image");
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Location = new Point(10, 421);
            btnAttendance.Margin = new Padding(3, 4, 3, 4);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(240, 76);
            btnAttendance.TabIndex = 5;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(btnAttendance, "View Attendance");
            btnAttendance.UseVisualStyleBackColor = true;
            btnAttendance.Click += btnAttendance_Click;
            btnAttendance.MouseEnter += btnAttendance_MouseEnter;
            btnAttendance.MouseLeave += btnAttendance_MouseLeave;
            // 
            // btnStudents
            // 
            btnStudents.BackgroundImageLayout = ImageLayout.Zoom;
            btnStudents.Cursor = Cursors.Hand;
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnStudents.ForeColor = SystemColors.HotTrack;
            btnStudents.Image = (Image)resources.GetObject("btnStudents.Image");
            btnStudents.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudents.Location = new Point(10, 309);
            btnStudents.Margin = new Padding(3, 4, 3, 4);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(240, 76);
            btnStudents.TabIndex = 3;
            btnStudents.Text = "Students";
            btnStudents.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(btnStudents, "Students");
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += button2_Click;
            btnStudents.MouseEnter += btnStudents_MouseEnter;
            btnStudents.MouseLeave += btnStudents_MouseLeave;
            // 
            // btnDashboard
            // 
            btnDashboard.BackgroundImageLayout = ImageLayout.Zoom;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.HotTrack;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(10, 196);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(240, 76);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(btnDashboard, "Dashboard");
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.MouseEnter += btnDashboard_MouseEnter;
            btnDashboard.MouseLeave += btnDashboard_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(99, 25);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 72);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(288, 351);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(923, 288);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(1154, 25);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 72);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(367, 51);
            label2.Name = "label2";
            label2.Size = new Size(249, 60);
            label2.TabIndex = 3;
            label2.Text = "Dashboard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(853, 36);
            label1.Name = "label1";
            label1.Size = new Size(317, 46);
            label1.TabIndex = 9;
            label1.Text = "Welcome, Teacher!";
            label1.Click += label1_Click;
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(672, 659);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.RightToLeft = RightToLeft.No;
            button7.Size = new Size(181, 47);
            button7.TabIndex = 10;
            button7.Text = "Manage Student";
            button7.UseVisualStyleBackColor = true;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 721);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(sidebar);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidebar;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnLogout;
        private Button btnAttendance;
        private Button btnStudents;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Button button7;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ToolTip toolTip1;
        private Label label4;
        private Label label3;
    }
}