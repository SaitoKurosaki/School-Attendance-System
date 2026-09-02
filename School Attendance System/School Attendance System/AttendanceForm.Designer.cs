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
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Present = new DataGridViewTextBoxColumn();
            Late = new DataGridViewTextBoxColumn();
            Absent = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Number, StudentName, Present, Late, Absent });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(12, 98);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1215, 534);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Number
            // 
            Number.HeaderText = "#";
            Number.MinimumWidth = 6;
            Number.Name = "Number";
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Student Name";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            // 
            // Present
            // 
            Present.HeaderText = "Present";
            Present.MinimumWidth = 6;
            Present.Name = "Present";
            // 
            // Late
            // 
            Late.HeaderText = "Late";
            Late.MinimumWidth = 6;
            Late.Name = "Late";
            // 
            // Absent
            // 
            Absent.HeaderText = "Absent";
            Absent.MinimumWidth = 6;
            Absent.Name = "Absent";
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 721);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Name = "AttendanceForm";
            Text = "AttendanceForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label7;
        private Label label8;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Present;
        private DataGridViewTextBoxColumn Late;
        private DataGridViewTextBoxColumn Absent;
    }
}