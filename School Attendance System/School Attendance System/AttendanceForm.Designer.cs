namespace School_Attendance_System
{
    partial class AttendanceForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            dgvAttendance = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            TimeIn = new DataGridViewTextBoxColumn();
            TimeOut = new DataGridViewTextBoxColumn();
            Present = new DataGridViewCheckBoxColumn();
            Late = new DataGridViewCheckBoxColumn();
            Absent = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(102, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(413, 34);
            dateTimePicker1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(839, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(372, 36);
            comboBox1.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(661, 30);
            label7.Name = "label7";
            label7.Size = new Size(158, 28);
            label7.TabIndex = 31;
            label7.Text = "Grade / Section:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(27, 28);
            label8.Name = "label8";
            label8.Size = new Size(59, 28);
            label8.TabIndex = 32;
            label8.Text = "Date:";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(897, 650);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(314, 56);
            button1.TabIndex = 33;
            button1.Text = "Save Attendance";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAttendance.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[] { Number, ID, StudentName, TimeIn, TimeOut, Present, Late, Absent });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAttendance.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAttendance.Location = new Point(12, 98);
            dgvAttendance.MultiSelect = false;
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(1215, 534);
            dgvAttendance.TabIndex = 34;
            dgvAttendance.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Number
            // 
            Number.HeaderText = "#";
            Number.MinimumWidth = 6;
            Number.Name = "Number";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Student Name";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            // 
            // TimeIn
            // 
            TimeIn.HeaderText = "Time In";
            TimeIn.MinimumWidth = 6;
            TimeIn.Name = "TimeIn";
            // 
            // TimeOut
            // 
            TimeOut.HeaderText = "Time Out";
            TimeOut.MinimumWidth = 6;
            TimeOut.Name = "TimeOut";
            // 
            // Present
            // 
            Present.HeaderText = "Present";
            Present.MinimumWidth = 6;
            Present.Name = "Present";
            Present.Resizable = DataGridViewTriState.True;
            Present.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Late
            // 
            Late.HeaderText = "Late";
            Late.MinimumWidth = 6;
            Late.Name = "Late";
            Late.Resizable = DataGridViewTriState.True;
            Late.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Absent
            // 
            Absent.HeaderText = "Absent";
            Absent.MinimumWidth = 6;
            Absent.Name = "Absent";
            Absent.Resizable = DataGridViewTriState.True;
            Absent.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 721);
            Controls.Add(dgvAttendance);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Name = "AttendanceForm";
            Text = "AttendanceForm";
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label7;
        private Label label8;
        private Button button1;
        private DataGridView dgvAttendance;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn TimeIn;
        private DataGridViewTextBoxColumn TimeOut;
        private DataGridViewCheckBoxColumn Present;
        private DataGridViewCheckBoxColumn Late;
        private DataGridViewCheckBoxColumn Absent;
    }
}