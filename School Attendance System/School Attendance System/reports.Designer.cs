namespace School_Attendance_System
{
    partial class reports
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
            label3 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            aloneComboBox1 = new ReaLTaiizor.Controls.AloneComboBox();
            poisonDateTime1 = new ReaLTaiizor.Controls.PoisonDateTime();
            poisonDateTime2 = new ReaLTaiizor.Controls.PoisonDateTime();
            label4 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            aloneComboBox2 = new ReaLTaiizor.Controls.AloneComboBox();
            btnDashboard = new AntdUI.ButtonShadow();
            recentAttendanceGrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colStudentName = new DataGridViewTextBoxColumn();
            colSection = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)recentAttendanceGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(117, 35);
            label1.TabIndex = 4;
            label1.Text = "Reports";
            // 
            // label3
            // 
            label3.Location = new Point(230, 54);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 21;
            label3.Text = "Section";
            // 
            // label2
            // 
            label2.Location = new Point(17, 54);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 20;
            label2.Text = "Course";
            // 
            // aloneComboBox1
            // 
            aloneComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            aloneComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            aloneComboBox1.EnabledCalc = true;
            aloneComboBox1.FormattingEnabled = true;
            aloneComboBox1.ItemHeight = 20;
            aloneComboBox1.Location = new Point(17, 83);
            aloneComboBox1.Name = "aloneComboBox1";
            aloneComboBox1.Size = new Size(186, 26);
            aloneComboBox1.TabIndex = 22;
            // 
            // poisonDateTime1
            // 
            poisonDateTime1.CustomFormat = "MMMM dd, yyyy";
            poisonDateTime1.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Small;
            poisonDateTime1.Format = DateTimePickerFormat.Custom;
            poisonDateTime1.Location = new Point(437, 83);
            poisonDateTime1.MinimumSize = new Size(0, 25);
            poisonDateTime1.Name = "poisonDateTime1";
            poisonDateTime1.Size = new Size(118, 26);
            poisonDateTime1.TabIndex = 23;
            poisonDateTime1.Value = new DateTime(2026, 10, 14, 0, 0, 0, 0);
            // 
            // poisonDateTime2
            // 
            poisonDateTime2.CustomFormat = "MMMM dd, yyyy";
            poisonDateTime2.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Small;
            poisonDateTime2.Format = DateTimePickerFormat.Custom;
            poisonDateTime2.Location = new Point(582, 83);
            poisonDateTime2.MinimumSize = new Size(0, 25);
            poisonDateTime2.Name = "poisonDateTime2";
            poisonDateTime2.Size = new Size(118, 26);
            poisonDateTime2.TabIndex = 24;
            poisonDateTime2.Value = new DateTime(2026, 10, 14, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.Location = new Point(437, 54);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 25;
            label4.Text = "Date From";
            // 
            // label5
            // 
            label5.Location = new Point(582, 54);
            label5.Name = "label5";
            label5.Size = new Size(93, 23);
            label5.TabIndex = 26;
            label5.Text = "Date To";
            // 
            // aloneComboBox2
            // 
            aloneComboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            aloneComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            aloneComboBox2.EnabledCalc = true;
            aloneComboBox2.FormattingEnabled = true;
            aloneComboBox2.ItemHeight = 20;
            aloneComboBox2.Location = new Point(230, 83);
            aloneComboBox2.Name = "aloneComboBox2";
            aloneComboBox2.Size = new Size(186, 26);
            aloneComboBox2.TabIndex = 28;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(719, 67);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(194, 42);
            btnDashboard.TabIndex = 29;
            btnDashboard.Text = "Create Class Code";
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
            recentAttendanceGrid.Columns.AddRange(new DataGridViewColumn[] { colNo, colStudentName, colSection, colStatus });
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
            recentAttendanceGrid.Location = new Point(17, 124);
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
            recentAttendanceGrid.Size = new Size(892, 450);
            recentAttendanceGrid.TabIndex = 30;
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
            // reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(recentAttendanceGrid);
            Controls.Add(btnDashboard);
            Controls.Add(aloneComboBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(poisonDateTime2);
            Controls.Add(poisonDateTime1);
            Controls.Add(aloneComboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "reports";
            Size = new Size(926, 586);
            ((System.ComponentModel.ISupportInitialize)recentAttendanceGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox1;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime2;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox2;
        private AntdUI.ButtonShadow btnDashboard;
        private ReaLTaiizor.Controls.PoisonDataGridView recentAttendanceGrid;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colSection;
        private DataGridViewComboBoxColumn colStatus;
    }
}
