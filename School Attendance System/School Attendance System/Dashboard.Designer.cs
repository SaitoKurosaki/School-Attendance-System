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
            label6 = new AntdUI.Label();
            label11 = new AntdUI.Label();
            panel2 = new AntdUI.Panel();
            label20 = new AntdUI.Label();
            recentAttendanceGrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            colStudentName = new DataGridViewTextBoxColumn();
            colCourse = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colSemester = new DataGridViewTextBoxColumn();
            colSection = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colRemarks = new DataGridViewTextBoxColumn();
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
            label1.ForeColor = AppTheme.Navy;
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            //
            // tlstudents
            //
            tlstudents.BackColor = AppTheme.Tint;
            tlstudents.Back = AppTheme.Tint;
            tlstudents.BorderColor = AppTheme.TintStrong;
            tlstudents.BorderWidth = 1F;
            tlstudents.Controls.Add(label7);
            tlstudents.Controls.Add(label8);
            tlstudents.Location = new Point(16, 60);
            tlstudents.Name = "tlstudents";
            tlstudents.Radius = 10;
            tlstudents.Size = new Size(267, 108);
            tlstudents.TabIndex = 3;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = AppTheme.Navy;
            label7.Location = new Point(16, 20);
            label7.Name = "label7";
            label7.Size = new Size(200, 34);
            label7.TabIndex = 10;
            label7.Text = "0";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = AppTheme.Muted;
            label8.Location = new Point(16, 66);
            label8.Name = "label8";
            label8.PrefixColor = AppTheme.Primary;
            label8.IconGap = 6;
            label8.IconRatio = 1.25F;
            label8.PrefixSvg = "TeamOutlined";
            label8.Size = new Size(235, 20);
            label8.TabIndex = 4;
            label8.Text = "Total Students";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // present
            // 
            present.BackColor = AppTheme.Tint;
            present.Back = AppTheme.Tint;
            present.BorderColor = AppTheme.TintStrong;
            present.BorderWidth = 1F;
            present.Controls.Add(label5);
            present.Controls.Add(label9);
            present.Location = new Point(295, 60);
            present.Name = "present";
            present.Radius = 10;
            present.Size = new Size(267, 108);
            present.TabIndex = 4;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = AppTheme.Navy;
            label5.Location = new Point(16, 20);
            label5.Name = "label5";
            label5.Size = new Size(200, 34);
            label5.TabIndex = 9;
            label5.Text = "0";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = AppTheme.Muted;
            label9.Location = new Point(16, 66);
            label9.Name = "label9";
            label9.PrefixColor = AppTheme.Primary;
            label9.IconGap = 6;
            label9.IconRatio = 1.25F;
            label9.PrefixSvg = "CheckCircleOutlined";
            label9.Size = new Size(235, 20);
            label9.TabIndex = 5;
            label9.Text = "Present Today";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // late
            // 
            late.BackColor = AppTheme.Tint;
            late.Back = AppTheme.Tint;
            late.BorderColor = AppTheme.TintStrong;
            late.BorderWidth = 1F;
            late.Controls.Add(label4);
            late.Controls.Add(label10);
            late.Location = new Point(574, 60);
            late.Name = "late";
            late.Radius = 10;
            late.Size = new Size(267, 108);
            late.TabIndex = 5;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = AppTheme.Navy;
            label4.Location = new Point(16, 20);
            label4.Name = "label4";
            label4.Size = new Size(200, 34);
            label4.TabIndex = 8;
            label4.Text = "0";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = AppTheme.Muted;
            label10.Location = new Point(16, 66);
            label10.Name = "label10";
            label10.PrefixColor = AppTheme.Primary;
            label10.IconGap = 6;
            label10.IconRatio = 1.25F;
            label10.PrefixSvg = "ClockCircleOutlined";
            label10.Size = new Size(235, 20);
            label10.TabIndex = 6;
            label10.Text = "Late Today";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // absent
            // 
            absent.BackColor = AppTheme.Tint;
            absent.Back = AppTheme.Tint;
            absent.BorderColor = AppTheme.TintStrong;
            absent.BorderWidth = 1F;
            absent.Controls.Add(label6);
            absent.Controls.Add(label11);
            absent.Location = new Point(853, 60);
            absent.Name = "absent";
            absent.Radius = 10;
            absent.Size = new Size(267, 108);
            absent.TabIndex = 6;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = AppTheme.Navy;
            label6.Location = new Point(16, 20);
            label6.Name = "label6";
            label6.Size = new Size(200, 34);
            label6.TabIndex = 7;
            label6.Text = "0";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = AppTheme.Muted;
            label11.Location = new Point(16, 66);
            label11.Name = "label11";
            label11.PrefixColor = AppTheme.Primary;
            label11.IconGap = 6;
            label11.IconRatio = 1.25F;
            label11.PrefixSvg = "ExclamationCircleOutlined";
            label11.Size = new Size(235, 20);
            label11.TabIndex = 8;
            label11.Text = "Absent Today";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Back = Color.White;
            panel2.BorderColor = AppTheme.Line;
            panel2.BorderWidth = 1F;
            panel2.Controls.Add(label20);
            panel2.Controls.Add(recentAttendanceGrid);
            panel2.Location = new Point(16, 184);
            panel2.Name = "panel2";
            panel2.Radius = 10;
            panel2.Size = new Size(1104, 560);
            panel2.TabIndex = 7;
            // 
            // label20
            // 
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = AppTheme.Ink;
            label20.Location = new Point(16, 12);
            label20.Name = "label20";
            label20.Size = new Size(320, 26);
            label20.TabIndex = 7;
            label20.Text = "Recent Attendance Today";
            // 
            // recentAttendanceGrid
            // 
            recentAttendanceGrid.AllowUserToAddRows = false;
            recentAttendanceGrid.AllowUserToDeleteRows = false;
            recentAttendanceGrid.AllowUserToResizeColumns = false;
            recentAttendanceGrid.AllowUserToResizeRows = false;
            recentAttendanceGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            recentAttendanceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            recentAttendanceGrid.BackgroundColor = Color.White;
            recentAttendanceGrid.BorderStyle = BorderStyle.None;
            recentAttendanceGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            recentAttendanceGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = AppTheme.Primary;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = AppTheme.Primary;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            recentAttendanceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            recentAttendanceGrid.ColumnHeadersHeight = 38;
            recentAttendanceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            recentAttendanceGrid.Columns.AddRange(new DataGridViewColumn[] { colStudentName, colCourse, colYear, colSemester, colSection, colStatus, colTime, colRemarks });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = AppTheme.Ink;
            dataGridViewCellStyle2.SelectionBackColor = AppTheme.Tint;
            dataGridViewCellStyle2.SelectionForeColor = AppTheme.Navy;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            recentAttendanceGrid.DefaultCellStyle = dataGridViewCellStyle2;
            recentAttendanceGrid.EnableHeadersVisualStyles = false;
            recentAttendanceGrid.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recentAttendanceGrid.GridColor = AppTheme.Line;
            recentAttendanceGrid.Location = new Point(16, 44);
            recentAttendanceGrid.Name = "recentAttendanceGrid";
            recentAttendanceGrid.ReadOnly = true;
            recentAttendanceGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = AppTheme.Primary;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = AppTheme.Primary;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            recentAttendanceGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            recentAttendanceGrid.RowHeadersVisible = false;
            recentAttendanceGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            recentAttendanceGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            recentAttendanceGrid.Size = new Size(1072, 500);
            recentAttendanceGrid.TabIndex = 9;
            recentAttendanceGrid.UseCustomBackColor = true;
            recentAttendanceGrid.UseCustomForeColor = true;
            recentAttendanceGrid.UseStyleColors = true;
            // 
            // colStudentName
            // 
            colStudentName.HeaderText = "Student Name";
            colStudentName.Name = "colStudentName";
            colStudentName.ReadOnly = true;
            // 
            // colCourse
            // 
            colCourse.HeaderText = "Course";
            colCourse.Name = "colCourse";
            colCourse.ReadOnly = true;
            // colYear
            colYear.HeaderText = "Year";
            colYear.Name = "colYear";
            colYear.ReadOnly = true;
            // colSemester
            colSemester.HeaderText = "Semester";
            colSemester.Name = "colSemester";
            colSemester.ReadOnly = true;
            // colSection
            colSection.HeaderText = "Section";
            colSection.Name = "colSection";
            colSection.ReadOnly = true;
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
            // colRemarks
            // 
            colRemarks.HeaderText = "Remarks";
            colRemarks.Name = "colRemarks";
            colRemarks.ReadOnly = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = AppTheme.Canvas;
            Controls.Add(panel2);
            Controls.Add(absent);
            Controls.Add(late);
            Controls.Add(present);
            Controls.Add(tlstudents);
            Controls.Add(label1);
            Name = "Dashboard";
            Size = new Size(1136, 760);
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
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colCourse;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colSemester;
        private DataGridViewTextBoxColumn colSection;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colRemarks;
    }
}
