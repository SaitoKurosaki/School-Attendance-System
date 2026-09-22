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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            txtSearch = new TextBox();
            btnClear = new Button();
            dgvStudents = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            MiddleName = new DataGridViewTextBoxColumn();
            GradeSection = new DataGridViewTextBoxColumn();
            ParentEmail = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 88);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 27;
            label1.Text = "Search:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtSearch);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(91, 75);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(873, 51);
            panel1.TabIndex = 28;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(1, 9);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name, email, or ID...";
            txtSearch.Size = new Size(866, 27);
            txtSearch.TabIndex = 20;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlDark;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlText;
            btnClear.Location = new Point(247, 135);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(154, 51);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStudents.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { ID, LastName, FirstName, MiddleName, GradeSection, ParentEmail, Actions });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStudents.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStudents.Dock = DockStyle.Bottom;
            dgvStudents.Location = new Point(0, 283);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(1314, 525);
            dgvStudents.TabIndex = 30;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // LastName
            // 
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            // 
            // MiddleName
            // 
            MiddleName.HeaderText = "Middle Name";
            MiddleName.MinimumWidth = 6;
            MiddleName.Name = "MiddleName";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 12);
            label2.Name = "label2";
            label2.Size = new Size(108, 31);
            label2.TabIndex = 2;
            label2.Text = "Students";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1314, 0);
            panel2.TabIndex = 31;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 808);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(dgvStudents);
            Controls.Add(btnClear);
            Name = "Students";
            Text = "Students";
            Load += Students_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private TextBox txtSearch;
        private Button btnClear;
        private DataGridView dgvStudents;
        private Label label2;
        private Panel panel2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn GradeSection;
        private DataGridViewTextBoxColumn ParentEmail;
        private DataGridViewTextBoxColumn Actions;
    }
}