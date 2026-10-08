namespace School_Attendance_System
{
    partial class manuelstudents
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new AntdUI.Panel();
            recentAttendanceGrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colStudentName = new DataGridViewTextBoxColumn();
            colSection = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            label1 = new AntdUI.Label();
            smallTextBox1 = new ReaLTaiizor.Controls.SmallTextBox();
            label3 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            aloneComboBox2 = new ReaLTaiizor.Controls.AloneComboBox();
            aloneComboBox1 = new ReaLTaiizor.Controls.AloneComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recentAttendanceGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(recentAttendanceGrid);
            panel1.Location = new Point(13, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 481);
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            recentAttendanceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            recentAttendanceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recentAttendanceGrid.Columns.AddRange(new DataGridViewColumn[] { colNo, colStudentName, colSection, colStatus, colTime });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            recentAttendanceGrid.DefaultCellStyle = dataGridViewCellStyle5;
            recentAttendanceGrid.EnableHeadersVisualStyles = false;
            recentAttendanceGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            recentAttendanceGrid.GridColor = Color.FromArgb(255, 255, 255);
            recentAttendanceGrid.Location = new Point(4, 3);
            recentAttendanceGrid.Name = "recentAttendanceGrid";
            recentAttendanceGrid.ReadOnly = true;
            recentAttendanceGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            recentAttendanceGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            recentAttendanceGrid.RowHeadersVisible = false;
            recentAttendanceGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            recentAttendanceGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            recentAttendanceGrid.Size = new Size(892, 475);
            recentAttendanceGrid.TabIndex = 10;
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
            // 
            // colTime
            // 
            colTime.HeaderText = "Time";
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 3);
            label1.Name = "label1";
            label1.Size = new Size(117, 35);
            label1.TabIndex = 1;
            label1.Text = "Students";
            // 
            // smallTextBox1
            // 
            smallTextBox1.BackColor = Color.Transparent;
            smallTextBox1.BorderColor = Color.FromArgb(180, 180, 180);
            smallTextBox1.CustomBGColor = Color.White;
            smallTextBox1.Font = new Font("Tahoma", 11F);
            smallTextBox1.ForeColor = Color.DimGray;
            smallTextBox1.Location = new Point(576, 57);
            smallTextBox1.MaxLength = 32767;
            smallTextBox1.Multiline = false;
            smallTextBox1.Name = "smallTextBox1";
            smallTextBox1.ReadOnly = false;
            smallTextBox1.Size = new Size(337, 28);
            smallTextBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            smallTextBox1.TabIndex = 2;
            smallTextBox1.Text = "Search by name,student ID, course or section...";
            smallTextBox1.TextAlignment = HorizontalAlignment.Left;
            smallTextBox1.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.Location = new Point(306, 32);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 25;
            label3.Text = "Section";
            // 
            // label2
            // 
            label2.Location = new Point(17, 32);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 24;
            label2.Text = "Course";
            // 
            // aloneComboBox2
            // 
            aloneComboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            aloneComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            aloneComboBox2.EnabledCalc = true;
            aloneComboBox2.FormattingEnabled = true;
            aloneComboBox2.ItemHeight = 20;
            aloneComboBox2.Location = new Point(306, 61);
            aloneComboBox2.Name = "aloneComboBox2";
            aloneComboBox2.Size = new Size(253, 26);
            aloneComboBox2.TabIndex = 23;
            // 
            // aloneComboBox1
            // 
            aloneComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            aloneComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            aloneComboBox1.EnabledCalc = true;
            aloneComboBox1.FormattingEnabled = true;
            aloneComboBox1.ItemHeight = 20;
            aloneComboBox1.Location = new Point(17, 61);
            aloneComboBox1.Name = "aloneComboBox1";
            aloneComboBox1.Size = new Size(253, 26);
            aloneComboBox1.TabIndex = 22;
            // 
            // manuelstudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(aloneComboBox2);
            Controls.Add(aloneComboBox1);
            Controls.Add(smallTextBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "manuelstudents";
            Size = new Size(926, 586);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)recentAttendanceGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.Label label1;
        private ReaLTaiizor.Controls.PoisonDataGridView recentAttendanceGrid;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colSection;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colTime;
        private ReaLTaiizor.Controls.SmallTextBox smallTextBox1;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox2;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox1;
    }
}
