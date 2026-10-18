namespace School_Attendance_System
{
    partial class Attendance
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
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            recentAttendanceGrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            colStudentName = new DataGridViewTextBoxColumn();
            colTimeIn = new DataGridViewTextBoxColumn();
            colTimeOut = new DataGridViewTextBoxColumn();
            colPresent = new DataGridViewCheckBoxColumn();
            colLate = new DataGridViewCheckBoxColumn();
            colAbsent = new DataGridViewCheckBoxColumn();
            colRemarks = new DataGridViewTextBoxColumn();
            btnDashboard = new AntdUI.Button();
            markallbtn = new AntdUI.Button();
            label3 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            attendanceDate = new ReaLTaiizor.Controls.PoisonDateTime();
            sectioncombo = new ReaLTaiizor.Controls.AloneComboBox();
            coursecombo = new ReaLTaiizor.Controls.AloneComboBox();
            ((System.ComponentModel.ISupportInitialize)recentAttendanceGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(117, 35);
            label1.TabIndex = 2;
            label1.Text = "Attendance";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
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
            recentAttendanceGrid.Columns.AddRange(new DataGridViewColumn[] { colStudentName, colTimeIn, colTimeOut, colPresent, colLate, colAbsent, colRemarks });
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
            recentAttendanceGrid.Location = new Point(17, 117);
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
            recentAttendanceGrid.RowHeadersWidth = 51;
            recentAttendanceGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            recentAttendanceGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            recentAttendanceGrid.Size = new Size(1126, 627);
            recentAttendanceGrid.TabIndex = 11;
            recentAttendanceGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            recentAttendanceGrid.UseCustomBackColor = true;
            recentAttendanceGrid.UseCustomForeColor = true;
            recentAttendanceGrid.UseStyleColors = true;
            // 
            // colStudentName
            // 
            colStudentName.HeaderText = "Student Name";
            colStudentName.MinimumWidth = 6;
            colStudentName.Name = "colStudentName";
            colStudentName.ReadOnly = true;
            // 
            // colTimeIn
            // 
            colTimeIn.HeaderText = "Time In";
            colTimeIn.MinimumWidth = 6;
            colTimeIn.Name = "colTimeIn";
            colTimeIn.ReadOnly = true;
            // 
            // colTimeOut
            // 
            colTimeOut.HeaderText = "Time Out";
            colTimeOut.MinimumWidth = 6;
            colTimeOut.Name = "colTimeOut";
            colTimeOut.ReadOnly = true;
            // 
            // colPresent
            // 
            colPresent.HeaderText = "Present";
            colPresent.MinimumWidth = 6;
            colPresent.Name = "colPresent";
            colPresent.ReadOnly = true;
            // 
            // colLate
            // 
            colLate.HeaderText = "Late";
            colLate.MinimumWidth = 6;
            colLate.Name = "colLate";
            colLate.ReadOnly = true;
            // 
            // colAbsent
            // 
            colAbsent.HeaderText = "Absent";
            colAbsent.MinimumWidth = 6;
            colAbsent.Name = "colAbsent";
            colAbsent.ReadOnly = true;
            // 
            // colRemarks
            // 
            colRemarks.HeaderText = "Remarks";
            colRemarks.MinimumWidth = 6;
            colRemarks.Name = "colRemarks";
            colRemarks.ReadOnly = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(926, 21);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(217, 42);
            btnDashboard.TabIndex = 12;
            btnDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDashboard.Text = "Save Attendance";
            // 
            // markallbtn
            // 
            markallbtn.Location = new Point(926, 69);
            markallbtn.Name = "markallbtn";
            markallbtn.Size = new Size(217, 42);
            markallbtn.TabIndex = 22;
            markallbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            markallbtn.Text = "Mark All Present";
            markallbtn.Click += markallbtn_Click;
            // 
            // label3
            // 
            label3.Location = new Point(328, 36);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 21;
            label3.Text = "Section";
            // 
            // label2
            // 
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 20;
            label2.Text = "Course";
            // 
            // sectioncombo
            // 
            sectioncombo.DrawMode = DrawMode.OwnerDrawFixed;
            sectioncombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sectioncombo.EnabledCalc = true;
            sectioncombo.FormattingEnabled = true;
            sectioncombo.ItemHeight = 20;
            sectioncombo.Location = new Point(328, 65);
            sectioncombo.Name = "sectioncombo";
            sectioncombo.Size = new Size(217, 26);
            sectioncombo.TabIndex = 19;
            // 
            // coursecombo
            // 
            coursecombo.DrawMode = DrawMode.OwnerDrawFixed;
            coursecombo.DropDownStyle = ComboBoxStyle.DropDownList;
            coursecombo.EnabledCalc = true;
            coursecombo.FormattingEnabled = true;
            coursecombo.ItemHeight = 20;
            coursecombo.Location = new Point(12, 65);
            coursecombo.Name = "coursecombo";
            coursecombo.Size = new Size(293, 26);
            coursecombo.TabIndex = 18;
            // 
            // label4
            // 
            label4.Location = new Point(620, 36);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 23;
            label4.Text = "Date";
            // 
            // attendanceDate
            // 
            attendanceDate.CustomFormat = "MMMM dd, yyyy";
            attendanceDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Small;
            attendanceDate.Format = DateTimePickerFormat.Custom;
            attendanceDate.Location = new Point(620, 65);
            attendanceDate.MinimumSize = new Size(0, 25);
            attendanceDate.Name = "attendanceDate";
            attendanceDate.Size = new Size(200, 26);
            attendanceDate.TabIndex = 24;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(sectioncombo);
            Controls.Add(coursecombo);
            Controls.Add(btnDashboard);
            Controls.Add(markallbtn);
            Controls.Add(attendanceDate);
            Controls.Add(label4);
            Controls.Add(recentAttendanceGrid);
            Controls.Add(label1);
            Name = "Attendance";
            Size = new Size(1160, 760);
            ((System.ComponentModel.ISupportInitialize)recentAttendanceGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ReaLTaiizor.Controls.PoisonDataGridView recentAttendanceGrid;
        private AntdUI.Button btnDashboard;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private ReaLTaiizor.Controls.AloneComboBox sectioncombo;
        private ReaLTaiizor.Controls.AloneComboBox coursecombo;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colTimeIn;
        private DataGridViewTextBoxColumn colTimeOut;
        private DataGridViewCheckBoxColumn colPresent;
        private DataGridViewCheckBoxColumn colLate;
        private DataGridViewCheckBoxColumn colAbsent;
        private DataGridViewTextBoxColumn colRemarks;
        private AntdUI.Button markallbtn;
        private AntdUI.Label label4;
        private ReaLTaiizor.Controls.PoisonDateTime attendanceDate;
    }
}
