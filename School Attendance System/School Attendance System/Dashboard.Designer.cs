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
            label6 = new Label();
            label4 = new Label();
            btnLogout = new Button();
            label3 = new Label();
            btnAttendance = new Button();
            btnDashboard = new Button();
            btnStudents = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            Maindashboard = new Panel();
            label2 = new Label();
            label1 = new Label();
            linelabel = new Label();
            button7 = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            toolTip1 = new ToolTip(components);
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Maindashboard.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.Control;
            sidebar.Controls.Add(label6);
            sidebar.Controls.Add(label4);
            sidebar.Controls.Add(btnLogout);
            sidebar.Controls.Add(label3);
            sidebar.Controls.Add(btnAttendance);
            sidebar.Controls.Add(btnDashboard);
            sidebar.Controls.Add(btnStudents);
            sidebar.Controls.Add(pictureBox1);
            sidebar.Controls.Add(label5);
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(247, 606);
            sidebar.TabIndex = 0;
            sidebar.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(91, 34);
            label6.Name = "label6";
            label6.Size = new Size(135, 25);
            label6.TabIndex = 13;
            label6.Text = "ATTENDANCE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(113, 59);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 12;
            label4.Text = "SYSTEM";
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogout.ForeColor = SystemColors.HotTrack;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(14, 548);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(217, 46);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Log-out";
            btnLogout.TextAlign = ContentAlignment.BottomCenter;
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
            label3.Location = new Point(114, 9);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 11;
            label3.Text = "SCHOOL";
            // 
            // btnAttendance
            // 
            btnAttendance.BackgroundImageLayout = ImageLayout.Zoom;
            btnAttendance.Cursor = Cursors.Hand;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAttendance.ForeColor = SystemColors.HotTrack;
            btnAttendance.Image = (Image)resources.GetObject("btnAttendance.Image");
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Location = new Point(14, 242);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(216, 46);
            btnAttendance.TabIndex = 5;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextAlign = ContentAlignment.BottomCenter;
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
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.HotTrack;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(14, 138);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(216, 46);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.BottomCenter;
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
            btnStudents.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStudents.ForeColor = SystemColors.HotTrack;
            btnStudents.Image = (Image)resources.GetObject("btnStudents.Image");
            btnStudents.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudents.Location = new Point(14, 190);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(216, 46);
            btnStudents.TabIndex = 3;
            btnStudents.Text = "Students";
            btnStudents.TextAlign = ContentAlignment.BottomCenter;
            btnStudents.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(btnStudents, "Students");
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            btnStudents.MouseEnter += btnStudents_MouseEnter;
            btnStudents.MouseLeave += btnStudents_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(27, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 47);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 72);
            label5.Name = "label5";
            label5.Size = new Size(217, 15);
            label5.TabIndex = 11;
            label5.Text = "__________________________________________";
            // 
            // Maindashboard
            // 
            Maindashboard.Controls.Add(label2);
            Maindashboard.Controls.Add(label1);
            Maindashboard.Controls.Add(linelabel);
            Maindashboard.Location = new Point(253, 9);
            Maindashboard.Name = "Maindashboard";
            Maindashboard.Size = new Size(819, 544);
            Maindashboard.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(16, 28);
            label2.Name = "label2";
            label2.Size = new Size(199, 47);
            label2.TabIndex = 3;
            label2.Text = "Dashboard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(550, 36);
            label1.Name = "label1";
            label1.Size = new Size(258, 37);
            label1.TabIndex = 9;
            label1.Text = "Welcome, Teacher!";
            label1.Click += label1_Click;
            // 
            // linelabel
            // 
            linelabel.AutoSize = true;
            linelabel.Location = new Point(11, 62);
            linelabel.Name = "linelabel";
            linelabel.Size = new Size(797, 15);
            linelabel.TabIndex = 10;
            linelabel.Text = "______________________________________________________________________________________________________________________________________________________________";
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(577, 559);
            button7.Name = "button7";
            button7.RightToLeft = RightToLeft.No;
            button7.Size = new Size(158, 35);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 606);
            Controls.Add(button7);
            Controls.Add(Maindashboard);
            Controls.Add(sidebar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Maindashboard.ResumeLayout(false);
            Maindashboard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnLogout;
        private Button btnAttendance;
        private Button btnStudents;
        private Panel Maindashboard;
        private Label label2;
        private Label label1;
        private Button button7;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ToolTip toolTip1;
        private Label label4;
        private Label label3;
        private Label linelabel;
        private Label label5;
        private Label label6;
    }
}