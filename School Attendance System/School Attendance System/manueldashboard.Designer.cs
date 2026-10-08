namespace School_Attendance_System
{
    partial class manueldashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            tlstudents = new AntdUI.Panel();
            label7 = new AntdUI.Label();
            label8 = new AntdUI.Label();
            present = new AntdUI.Panel();
            label5 = new AntdUI.Label();
            label9 = new AntdUI.Label();
            late = new AntdUI.Panel();
            label4 = new AntdUI.Label();
            label10 = new AntdUI.Label();
            absent = new AntdUI.Panel();
            label11 = new AntdUI.Label();
            label6 = new AntdUI.Label();
            panel2 = new AntdUI.Panel();
            label20 = new AntdUI.Label();
            recentAttendanceGrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colStudentName = new DataGridViewTextBoxColumn();
            colSection = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            tlstudents.SuspendLayout();
            present.SuspendLayout();
            late.SuspendLayout();
            absent.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recentAttendanceGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(117, 35);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(712, 13);
            label2.Name = "label2";
            label2.Size = new Size(117, 35);
            label2.TabIndex = 1;
            label2.Text = "Welcome";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(806, 13);
            label3.Name = "label3";
            label3.Size = new Size(117, 35);
            label3.TabIndex = 2;
            label3.Text = "Manuel";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlstudents
            // 
            tlstudents.BackColor = SystemColors.Control;
            tlstudents.Controls.Add(label7);
            tlstudents.Controls.Add(label8);
            tlstudents.ForeColor = SystemColors.ControlText;
            tlstudents.Location = new Point(15, 68);
            tlstudents.Name = "tlstudents";
            tlstudents.Size = new Size(190, 107);
            tlstudents.TabIndex = 3;
            tlstudents.Text = "panel1";
            tlstudents.Click += panel1_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(42, 40);
            label7.Name = "label7";
            label7.Size = new Size(86, 23);
            label7.TabIndex = 10;
            label7.Text = "2";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(42, 69);
            label8.Name = "label8";
            label8.Size = new Size(86, 23);
            label8.TabIndex = 4;
            label8.Text = "Total Students";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // present
            // 
            present.Controls.Add(label5);
            present.Controls.Add(label9);
            present.Location = new Point(246, 68);
            present.Name = "present";
            present.Size = new Size(190, 107);
            present.TabIndex = 4;
            present.Text = "panel2";
            present.Click += panel2_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(53, 40);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 9;
            label5.Text = "2";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(53, 69);
            label9.Name = "label9";
            label9.Size = new Size(86, 23);
            label9.TabIndex = 5;
            label9.Text = "Present Today";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // late
            // 
            late.Controls.Add(label4);
            late.Controls.Add(label10);
            late.Location = new Point(485, 68);
            late.Name = "late";
            late.Size = new Size(190, 107);
            late.TabIndex = 4;
            late.Text = "panel3";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 40);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 8;
            label4.Text = "2";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(51, 69);
            label10.Name = "label10";
            label10.Size = new Size(86, 23);
            label10.TabIndex = 6;
            label10.Text = "Late Today";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // absent
            // 
            absent.Controls.Add(label11);
            absent.Controls.Add(label6);
            absent.Location = new Point(723, 68);
            absent.Name = "absent";
            absent.Size = new Size(190, 107);
            absent.TabIndex = 4;
            absent.Text = "panel4";
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(57, 69);
            label11.Name = "label11";
            label11.Size = new Size(86, 23);
            label11.TabIndex = 7;
            label11.Text = "Absent Today";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(57, 40);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 6;
            label6.Text = "2";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label20);
            panel2.Controls.Add(recentAttendanceGrid);
            panel2.Location = new Point(15, 192);
            panel2.Name = "panel2";
            panel2.Size = new Size(898, 382);
            panel2.TabIndex = 8;
            panel2.Text = "panel2";
            // 
            // label20
            // 
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(13, 3);
            label20.Name = "label20";
            label20.Size = new Size(203, 35);
            label20.TabIndex = 7;
            label20.Text = "Recent Attendance Today";
            // 
            // recentAttendanceGrid
            // 
            recentAttendanceGrid.AllowUserToAddRows = false;
            recentAttendanceGrid.AllowUserToDeleteRows = false;
            recentAttendanceGrid.AllowUserToResizeColumns = false;
            recentAttendanceGrid.AllowUserToResizeRows = false;
            recentAttendanceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            recentAttendanceGrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            recentAttendanceGrid.BorderStyle = BorderStyle.None;
            recentAttendanceGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            recentAttendanceGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            recentAttendanceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            recentAttendanceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recentAttendanceGrid.Columns.AddRange(new DataGridViewColumn[] { colNo, colStudentName, colSection, colStatus, colTime });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            recentAttendanceGrid.DefaultCellStyle = dataGridViewCellStyle2;
            recentAttendanceGrid.EnableHeadersVisualStyles = false;
            recentAttendanceGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            recentAttendanceGrid.GridColor = Color.FromArgb(255, 255, 255);
            recentAttendanceGrid.Location = new Point(3, 44);
            recentAttendanceGrid.Name = "recentAttendanceGrid";
            recentAttendanceGrid.ReadOnly = true;
            recentAttendanceGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            recentAttendanceGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            recentAttendanceGrid.RowHeadersVisible = false;
            recentAttendanceGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            recentAttendanceGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            recentAttendanceGrid.Size = new Size(892, 346);
            recentAttendanceGrid.TabIndex = 9;
            recentAttendanceGrid.UseCustomBackColor = true;
            recentAttendanceGrid.UseCustomForeColor = true;
            recentAttendanceGrid.UseStyleColors = true;
            recentAttendanceGrid.CellContentClick += poisonDataGridView1_CellContentClick;
            // 
            // colNo
            // 
            colNo.HeaderText = "#";
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colStudentName
            // 
            colStudentName.HeaderText = "Student Name";
            colStudentName.Name = "colStudentName";
            colStudentName.ReadOnly = true;
            // 
            // colSection
            // 
            colSection.HeaderText = "Grade / Section";
            colSection.Name = "colSection";
            colSection.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colTime
            // 
            colTime.HeaderText = "Time";
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            // 
            // manueldashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panel2);
            Controls.Add(absent);
            Controls.Add(late);
            Controls.Add(present);
            Controls.Add(tlstudents);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "manueldashboard";
            Size = new Size(926, 586);
            tlstudents.ResumeLayout(false);
            present.ResumeLayout(false);
            late.ResumeLayout(false);
            absent.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)recentAttendanceGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Panel tlstudents;
        private AntdUI.Panel present;
        private AntdUI.Panel late;
        private AntdUI.Panel absent;
        private AntdUI.Label label8;
        private AntdUI.Label label9;
        private AntdUI.Label label10;
        private AntdUI.Label label11;
        private AntdUI.Label label6;
        private AntdUI.Label label7;
        private AntdUI.Label label5;
        private AntdUI.Label label4;
        private AntdUI.Panel panel2;
        private AntdUI.Label label20;
        private ReaLTaiizor.Controls.PoisonDataGridView recentAttendanceGrid;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colSection;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colTime;
    }
}
