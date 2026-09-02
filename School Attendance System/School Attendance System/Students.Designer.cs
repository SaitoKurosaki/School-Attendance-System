namespace School_Attendance_System
{
    partial class Students
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
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            firstnamebox = new TextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            GradeSection = new DataGridViewTextBoxColumn();
            ParentEmail = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(108, 31);
            label2.TabIndex = 2;
            label2.Text = "Students";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(1027, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(200, 51);
            button1.TabIndex = 26;
            button1.Text = "+ Add Student";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 27;
            label1.Text = "Search:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(firstnamebox);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(86, 79);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 51);
            panel1.TabIndex = 28;
            // 
            // firstnamebox
            // 
            firstnamebox.BackColor = SystemColors.Control;
            firstnamebox.BorderStyle = BorderStyle.None;
            firstnamebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstnamebox.Location = new Point(3, 4);
            firstnamebox.Margin = new Padding(3, 4, 3, 4);
            firstnamebox.Name = "firstnamebox";
            firstnamebox.PlaceholderText = "Search by name, email, or ID...";
            firstnamebox.Size = new Size(349, 27);
            firstnamebox.TabIndex = 20;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(1073, 79);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(154, 51);
            button2.TabIndex = 29;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, FullName, GradeSection, ParentEmail, Actions });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(12, 155);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1215, 525);
            dataGridView1.TabIndex = 30;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // FullName
            // 
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            // 
            // GradeSection
            // 
            GradeSection.HeaderText = "Grade / Section";
            GradeSection.MinimumWidth = 6;
            GradeSection.Name = "GradeSection";
            // 
            // ParentEmail
            // 
            ParentEmail.HeaderText = "Parent Email";
            ParentEmail.MinimumWidth = 6;
            ParentEmail.Name = "ParentEmail";
            // 
            // Actions
            // 
            Actions.HeaderText = "Actions";
            Actions.MinimumWidth = 6;
            Actions.Name = "Actions";
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 808);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "Students";
            Text = "Students";
            Load += Students_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button1;
        private Label label1;
        private Panel panel1;
        private TextBox firstnamebox;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn GradeSection;
        private DataGridViewTextBoxColumn ParentEmail;
        private DataGridViewTextBoxColumn Actions;
    }
}