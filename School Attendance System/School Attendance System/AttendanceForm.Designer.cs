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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label7 = new Label();
            label8 = new Label();
            dgvAttendance = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            TimeIn = new DataGridViewTextBoxColumn();
            TimeOut = new DataGridViewTextBoxColumn();
            Present = new DataGridViewCheckBoxColumn();
            Late = new DataGridViewCheckBoxColumn();
            Absent = new DataGridViewCheckBoxColumn();
            Remarks = new DataGridViewTextBoxColumn();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            comboBoxEdit1 = new ReaLTaiizor.Controls.ComboBoxEdit();
            pdtDate = new ReaLTaiizor.Controls.PoisonDateTime();
            btnSave = new AntdUI.Button();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(661, 30);
            label7.Name = "label7";
            label7.Size = new Size(167, 28);
            label7.TabIndex = 31;
            label7.Text = "Course / Section:";
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
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAttendance.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[] { Number, ID, StudentName, TimeIn, TimeOut, Present, Late, Absent, Remarks });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvAttendance.DefaultCellStyle = dataGridViewCellStyle4;
            dgvAttendance.Location = new Point(11, 98);
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
            // Remarks
            // 
            Remarks.HeaderText = "Remarks";
            Remarks.MinimumWidth = 6;
            Remarks.Name = "Remarks";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.BackColor = Color.FromArgb(246, 246, 246);
            comboBoxEdit1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxEdit1.DropDownHeight = 100;
            comboBoxEdit1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEdit1.Font = new Font("Segoe UI", 10F);
            comboBoxEdit1.ForeColor = Color.FromArgb(142, 142, 142);
            comboBoxEdit1.FormattingEnabled = true;
            comboBoxEdit1.HoverSelectionColor = Color.FromArgb(241, 241, 241);
            comboBoxEdit1.IntegralHeight = false;
            comboBoxEdit1.ItemHeight = 20;
            comboBoxEdit1.Location = new Point(834, 35);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Size = new Size(372, 26);
            comboBoxEdit1.StartIndex = 0;
            comboBoxEdit1.TabIndex = 35;
            // 
            // pdtDate
            // 
            pdtDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            pdtDate.Location = new Point(92, 30);
            pdtDate.MinimumSize = new Size(0, 30);
            pdtDate.Name = "pdtDate";
            pdtDate.Size = new Size(413, 30);
            pdtDate.TabIndex = 36;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkGreen;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(912, 653);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(314, 56);
            btnSave.TabIndex = 37;
            btnSave.Text = "Save Attendance";
            btnSave.Click += btnSave_Click;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 721);
            Controls.Add(btnSave);
            Controls.Add(pdtDate);
            Controls.Add(comboBoxEdit1);
            Controls.Add(dgvAttendance);
            Controls.Add(label8);
            Controls.Add(label7);
            Name = "AttendanceForm";
            Text = "AttendanceForm";
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label8;
        private DataGridView dgvAttendance;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn TimeIn;
        private DataGridViewTextBoxColumn TimeOut;
        private DataGridViewCheckBoxColumn Present;
        private DataGridViewCheckBoxColumn Late;
        private DataGridViewCheckBoxColumn Absent;
        private DataGridViewTextBoxColumn Remarks;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ReaLTaiizor.Controls.ComboBoxEdit comboBoxEdit1;
        private ReaLTaiizor.Controls.PoisonDateTime pdtDate;
        private AntdUI.Button btnSave;
    }
}