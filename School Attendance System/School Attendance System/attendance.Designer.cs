namespace School_Attendance_System
{
    partial class attendance
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            label1 = new AntdUI.Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            recentAttendanceGrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colStudentName = new DataGridViewTextBoxColumn();
            colSection = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewComboBoxColumn();
            btnDashboard = new AntdUI.ButtonShadow();
            label3 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            aloneComboBox2 = new ReaLTaiizor.Controls.AloneComboBox();
            aloneComboBox1 = new ReaLTaiizor.Controls.AloneComboBox();
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
            label1.Click += label1_Click;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            recentAttendanceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            recentAttendanceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recentAttendanceGrid.Columns.AddRange(new DataGridViewColumn[] { colNo, colStudentName, colSection, colStatus });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            recentAttendanceGrid.DefaultCellStyle = dataGridViewCellStyle8;
            recentAttendanceGrid.EnableHeadersVisualStyles = false;
            recentAttendanceGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            recentAttendanceGrid.GridColor = Color.FromArgb(255, 255, 255);
            recentAttendanceGrid.Location = new Point(12, 97);
            recentAttendanceGrid.Name = "recentAttendanceGrid";
            recentAttendanceGrid.ReadOnly = true;
            recentAttendanceGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            recentAttendanceGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            recentAttendanceGrid.RowHeadersVisible = false;
            recentAttendanceGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            recentAttendanceGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            recentAttendanceGrid.Size = new Size(892, 475);
            recentAttendanceGrid.TabIndex = 11;
            recentAttendanceGrid.UseCustomBackColor = true;
            recentAttendanceGrid.UseCustomForeColor = true;
            recentAttendanceGrid.UseStyleColors = true;
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
            colStatus.Resizable = DataGridViewTriState.True;
            colStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(687, 38);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(217, 42);
            btnDashboard.TabIndex = 12;
            btnDashboard.Text = "Save Attendance";
            // 
            // label3
            // 
            label3.Location = new Point(301, 36);
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
            // aloneComboBox2
            // 
            aloneComboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            aloneComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            aloneComboBox2.EnabledCalc = true;
            aloneComboBox2.FormattingEnabled = true;
            aloneComboBox2.ItemHeight = 20;
            aloneComboBox2.Location = new Point(301, 65);
            aloneComboBox2.Name = "aloneComboBox2";
            aloneComboBox2.Size = new Size(253, 26);
            aloneComboBox2.TabIndex = 19;
            // 
            // aloneComboBox1
            // 
            aloneComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            aloneComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            aloneComboBox1.EnabledCalc = true;
            aloneComboBox1.FormattingEnabled = true;
            aloneComboBox1.ItemHeight = 20;
            aloneComboBox1.Location = new Point(12, 65);
            aloneComboBox1.Name = "aloneComboBox1";
            aloneComboBox1.Size = new Size(253, 26);
            aloneComboBox1.TabIndex = 18;
            // 
            // attendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(aloneComboBox2);
            Controls.Add(aloneComboBox1);
            Controls.Add(btnDashboard);
            Controls.Add(recentAttendanceGrid);
            Controls.Add(label1);
            Name = "attendance";
            Size = new Size(926, 586);
            ((System.ComponentModel.ISupportInitialize)recentAttendanceGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ReaLTaiizor.Controls.PoisonDataGridView recentAttendanceGrid;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colSection;
        private DataGridViewComboBoxColumn colStatus;
        private AntdUI.ButtonShadow btnDashboard;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox2;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox1;
    }
}
