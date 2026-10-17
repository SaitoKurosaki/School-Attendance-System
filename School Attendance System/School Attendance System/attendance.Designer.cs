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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new AntdUI.Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            recentAttendanceGrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnDashboard = new AntdUI.ButtonShadow();
            label3 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            aloneComboBox2 = new ReaLTaiizor.Controls.AloneComboBox();
            aloneComboBox1 = new ReaLTaiizor.Controls.AloneComboBox();
            colNo = new DataGridViewTextBoxColumn();
            colID = new DataGridViewTextBoxColumn();
            colStudentName = new DataGridViewTextBoxColumn();
            colTimeIn = new DataGridViewTextBoxColumn();
            colTimeOut = new DataGridViewTextBoxColumn();
            colPresent = new DataGridViewCheckBoxColumn();
            colLate = new DataGridViewCheckBoxColumn();
            colAbsent = new DataGridViewCheckBoxColumn();
            colRemarks = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)recentAttendanceGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 4);
            label1.Margin = new Padding(3, 4, 3, 4);
            label1.Name = "label1";
            label1.Size = new Size(134, 47);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            recentAttendanceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            recentAttendanceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recentAttendanceGrid.Columns.AddRange(new DataGridViewColumn[] { colNo, colID, colStudentName, colTimeIn, colTimeOut, colPresent, colLate, colAbsent, colRemarks });
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
            recentAttendanceGrid.Location = new Point(19, 129);
            recentAttendanceGrid.Margin = new Padding(3, 4, 3, 4);
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
            recentAttendanceGrid.Size = new Size(1019, 633);
            recentAttendanceGrid.TabIndex = 11;
            recentAttendanceGrid.UseCustomBackColor = true;
            recentAttendanceGrid.UseCustomForeColor = true;
            recentAttendanceGrid.UseStyleColors = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(785, 51);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(248, 56);
            btnDashboard.TabIndex = 12;
            btnDashboard.Text = "Save Attendance";
            // 
            // label3
            // 
            label3.Location = new Point(344, 48);
            label3.Margin = new Padding(3, 4, 3, 4);
            label3.Name = "label3";
            label3.Size = new Size(106, 31);
            label3.TabIndex = 21;
            label3.Text = "Section";
            // 
            // label2
            // 
            label2.Location = new Point(14, 48);
            label2.Margin = new Padding(3, 4, 3, 4);
            label2.Name = "label2";
            label2.Size = new Size(106, 31);
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
            aloneComboBox2.Location = new Point(344, 87);
            aloneComboBox2.Margin = new Padding(3, 4, 3, 4);
            aloneComboBox2.Name = "aloneComboBox2";
            aloneComboBox2.Size = new Size(289, 26);
            aloneComboBox2.TabIndex = 19;
            // 
            // aloneComboBox1
            // 
            aloneComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            aloneComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            aloneComboBox1.EnabledCalc = true;
            aloneComboBox1.FormattingEnabled = true;
            aloneComboBox1.ItemHeight = 20;
            aloneComboBox1.Location = new Point(14, 87);
            aloneComboBox1.Margin = new Padding(3, 4, 3, 4);
            aloneComboBox1.Name = "aloneComboBox1";
            aloneComboBox1.Size = new Size(289, 26);
            aloneComboBox1.TabIndex = 18;
            // 
            // colNo
            // 
            colNo.HeaderText = "#";
            colNo.MinimumWidth = 6;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
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
            // attendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(aloneComboBox2);
            Controls.Add(aloneComboBox1);
            Controls.Add(btnDashboard);
            Controls.Add(recentAttendanceGrid);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "attendance";
            Size = new Size(1058, 781);
            ((System.ComponentModel.ISupportInitialize)recentAttendanceGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ReaLTaiizor.Controls.PoisonDataGridView recentAttendanceGrid;
        private AntdUI.ButtonShadow btnDashboard;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox2;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox1;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colTimeIn;
        private DataGridViewTextBoxColumn colTimeOut;
        private DataGridViewCheckBoxColumn colPresent;
        private DataGridViewCheckBoxColumn colLate;
        private DataGridViewCheckBoxColumn colAbsent;
        private DataGridViewTextBoxColumn colRemarks;
    }
}
