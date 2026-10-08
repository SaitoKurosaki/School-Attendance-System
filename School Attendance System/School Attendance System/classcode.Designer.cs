namespace School_Attendance_System
{
    partial class classcode
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            label1 = new AntdUI.Label();
            recentAttendanceGrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colStudentName = new DataGridViewTextBoxColumn();
            colSection = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewComboBoxColumn();
            aloneComboBox1 = new ReaLTaiizor.Controls.AloneComboBox();
            aloneComboBox2 = new ReaLTaiizor.Controls.AloneComboBox();
            btnDashboard = new AntdUI.ButtonShadow();
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            ((System.ComponentModel.ISupportInitialize)recentAttendanceGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(117, 35);
            label1.TabIndex = 3;
            label1.Text = "Class Code";
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
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            recentAttendanceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            recentAttendanceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recentAttendanceGrid.Columns.AddRange(new DataGridViewColumn[] { colNo, colStudentName, colSection, colStatus });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            recentAttendanceGrid.DefaultCellStyle = dataGridViewCellStyle11;
            recentAttendanceGrid.EnableHeadersVisualStyles = false;
            recentAttendanceGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            recentAttendanceGrid.GridColor = Color.FromArgb(255, 255, 255);
            recentAttendanceGrid.Location = new Point(17, 124);
            recentAttendanceGrid.Name = "recentAttendanceGrid";
            recentAttendanceGrid.ReadOnly = true;
            recentAttendanceGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            recentAttendanceGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            recentAttendanceGrid.RowHeadersVisible = false;
            recentAttendanceGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            recentAttendanceGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            recentAttendanceGrid.Size = new Size(892, 450);
            recentAttendanceGrid.TabIndex = 12;
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
            // aloneComboBox1
            // 
            aloneComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            aloneComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            aloneComboBox1.EnabledCalc = true;
            aloneComboBox1.FormattingEnabled = true;
            aloneComboBox1.ItemHeight = 20;
            aloneComboBox1.Location = new Point(17, 79);
            aloneComboBox1.Name = "aloneComboBox1";
            aloneComboBox1.Size = new Size(253, 26);
            aloneComboBox1.TabIndex = 13;
            // 
            // aloneComboBox2
            // 
            aloneComboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            aloneComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            aloneComboBox2.EnabledCalc = true;
            aloneComboBox2.FormattingEnabled = true;
            aloneComboBox2.ItemHeight = 20;
            aloneComboBox2.Location = new Point(306, 79);
            aloneComboBox2.Name = "aloneComboBox2";
            aloneComboBox2.Size = new Size(253, 26);
            aloneComboBox2.TabIndex = 14;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(692, 63);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(217, 42);
            btnDashboard.TabIndex = 15;
            btnDashboard.Text = "Create Class Code";
            // 
            // label2
            // 
            label2.Location = new Point(17, 50);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 16;
            label2.Text = "Course";
            // 
            // label3
            // 
            label3.Location = new Point(306, 50);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 17;
            label3.Text = "Section";
            // 
            // classcode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDashboard);
            Controls.Add(aloneComboBox2);
            Controls.Add(aloneComboBox1);
            Controls.Add(recentAttendanceGrid);
            Controls.Add(label1);
            Name = "classcode";
            Size = new Size(926, 586);
            ((System.ComponentModel.ISupportInitialize)recentAttendanceGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private ReaLTaiizor.Controls.PoisonDataGridView recentAttendanceGrid;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colSection;
        private DataGridViewComboBoxColumn colStatus;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox1;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox2;
        private AntdUI.ButtonShadow btnDashboard;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
    }
}
