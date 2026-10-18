namespace School_Attendance_System
{
    partial class Administrator
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
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            coursetext = new ReaLTaiizor.Controls.SmallTextBox();
            sectiontext = new ReaLTaiizor.Controls.SmallTextBox();
            addcoursebtn = new AntdUI.Button();
            addsectionbtn = new AntdUI.Button();
            coursecombo = new ReaLTaiizor.Controls.AloneComboBox();
            sectioncombo = new ReaLTaiizor.Controls.AloneComboBox();
            deletecoursebtn = new AntdUI.Button();
            renamecoursebtn = new AntdUI.Button();
            deletesectionbtn = new AntdUI.Button();
            renamesectionbtn = new AntdUI.Button();
            searchtext = new ReaLTaiizor.Controls.SmallTextBox();
            label5 = new AntdUI.Label();
            label6 = new AntdUI.Label();
            label7 = new AntdUI.Label();
            label8 = new AntdUI.Label();
            nametext = new ReaLTaiizor.Controls.SmallTextBox();
            numtext = new ReaLTaiizor.Controls.SmallTextBox();
            emailtext = new ReaLTaiizor.Controls.SmallTextBox();
            parenttext = new ReaLTaiizor.Controls.SmallTextBox();
            updatestudentbtn = new AntdUI.Button();
            studentlistcontent = new ReaLTaiizor.Controls.PoisonDataGridView();
            ((System.ComponentModel.ISupportInitialize)studentlistcontent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(160, 35);
            label1.TabIndex = 0;
            label1.Text = "Administrator";
            // 
            // label2
            // 
            label2.Location = new Point(17, 50);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 1;
            label2.Text = "New Course";
            // 
            // coursetext
            // 
            coursetext.BackColor = Color.Transparent;
            coursetext.BorderColor = Color.FromArgb(180, 180, 180);
            coursetext.CustomBGColor = Color.White;
            coursetext.Font = new Font("Tahoma", 11F);
            coursetext.ForeColor = Color.DimGray;
            coursetext.Location = new Point(17, 79);
            coursetext.MaxLength = 255;
            coursetext.Multiline = false;
            coursetext.Name = "coursetext";
            coursetext.ReadOnly = false;
            coursetext.Size = new Size(293, 28);
            coursetext.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            coursetext.TabIndex = 2;
            coursetext.TextAlignment = HorizontalAlignment.Left;
            coursetext.UseSystemPasswordChar = false;
            // 
            // addcoursebtn
            // 
            addcoursebtn.Location = new Point(325, 72);
            addcoursebtn.Name = "addcoursebtn";
            addcoursebtn.Size = new Size(140, 42);
            addcoursebtn.TabIndex = 3;
            addcoursebtn.Text = "Add Course";
            addcoursebtn.Click += addcoursebtn_Click;
            // 
            // label3
            // 
            label3.Location = new Point(620, 50);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 4;
            label3.Text = "New Section";
            // 
            // sectiontext
            // 
            sectiontext.BackColor = Color.Transparent;
            sectiontext.BorderColor = Color.FromArgb(180, 180, 180);
            sectiontext.CustomBGColor = Color.White;
            sectiontext.Font = new Font("Tahoma", 11F);
            sectiontext.ForeColor = Color.DimGray;
            sectiontext.Location = new Point(620, 79);
            sectiontext.MaxLength = 2;
            sectiontext.Multiline = false;
            sectiontext.Name = "sectiontext";
            sectiontext.ReadOnly = false;
            sectiontext.Size = new Size(254, 28);
            sectiontext.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            sectiontext.TabIndex = 5;
            sectiontext.TextAlignment = HorizontalAlignment.Left;
            sectiontext.UseSystemPasswordChar = false;
            // 
            // addsectionbtn
            // 
            addsectionbtn.Location = new Point(945, 72);
            addsectionbtn.Name = "addsectionbtn";
            addsectionbtn.Size = new Size(140, 42);
            addsectionbtn.TabIndex = 6;
            addsectionbtn.Text = "Add Section";
            addsectionbtn.Click += addsectionbtn_Click;
            // 
            // coursecombo
            // 
            coursecombo.DrawMode = DrawMode.OwnerDrawFixed;
            coursecombo.DropDownStyle = ComboBoxStyle.DropDownList;
            coursecombo.EnabledCalc = true;
            coursecombo.FormattingEnabled = true;
            coursecombo.ItemHeight = 20;
            coursecombo.Location = new Point(17, 127);
            coursecombo.Name = "coursecombo";
            coursecombo.Size = new Size(293, 26);
            coursecombo.TabIndex = 9;
            coursecombo.SelectedIndexChanged += coursecombo_SelectedIndexChanged;
            // 
            // renamecoursebtn
            // 
            renamecoursebtn.Location = new Point(325, 119);
            renamecoursebtn.Name = "renamecoursebtn";
            renamecoursebtn.Size = new Size(88, 42);
            renamecoursebtn.TabIndex = 10;
            renamecoursebtn.Text = "Rename";
            renamecoursebtn.Click += renamecoursebtn_Click;
            // 
            // deletecoursebtn
            // 
            deletecoursebtn.Location = new Point(423, 119);
            deletecoursebtn.Name = "deletecoursebtn";
            deletecoursebtn.Size = new Size(88, 42);
            deletecoursebtn.TabIndex = 11;
            deletecoursebtn.Text = "Delete";
            deletecoursebtn.Click += deletecoursebtn_Click;
            // 
            // sectioncombo
            // 
            sectioncombo.DrawMode = DrawMode.OwnerDrawFixed;
            sectioncombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sectioncombo.EnabledCalc = true;
            sectioncombo.FormattingEnabled = true;
            sectioncombo.ItemHeight = 20;
            sectioncombo.Location = new Point(620, 127);
            sectioncombo.Name = "sectioncombo";
            sectioncombo.Size = new Size(293, 26);
            sectioncombo.TabIndex = 12;
            sectioncombo.SelectedIndexChanged += sectioncombo_SelectedIndexChanged;
            // 
            // renamesectionbtn
            // 
            renamesectionbtn.Location = new Point(928, 119);
            renamesectionbtn.Name = "renamesectionbtn";
            renamesectionbtn.Size = new Size(88, 42);
            renamesectionbtn.TabIndex = 13;
            renamesectionbtn.Text = "Rename";
            renamesectionbtn.Click += renamesectionbtn_Click;
            // 
            // deletesectionbtn
            // 
            deletesectionbtn.Location = new Point(1026, 119);
            deletesectionbtn.Name = "deletesectionbtn";
            deletesectionbtn.Size = new Size(88, 42);
            deletesectionbtn.TabIndex = 14;
            deletesectionbtn.Text = "Delete";
            deletesectionbtn.Click += deletesectionbtn_Click;
            // 
            // searchtext
            // 
            searchtext.BackColor = Color.Transparent;
            searchtext.BorderColor = Color.FromArgb(180, 180, 180);
            searchtext.CustomBGColor = Color.White;
            searchtext.Font = new Font("Tahoma", 11F);
            searchtext.ForeColor = Color.DimGray;
            searchtext.Location = new Point(811, 170);
            searchtext.MaxLength = 255;
            searchtext.Multiline = false;
            searchtext.Name = "searchtext";
            searchtext.ReadOnly = false;
            searchtext.Size = new Size(332, 28);
            searchtext.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            searchtext.TabIndex = 15;
            searchtext.TextAlignment = HorizontalAlignment.Left;
            searchtext.UseSystemPasswordChar = false;
            searchtext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchtext.TextChanged += searchtext_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 174);
            label4.Name = "label4";
            label4.Size = new Size(160, 26);
            label4.TabIndex = 7;
            label4.Text = "All Students";
            // 
            // studentlistcontent
            // 
            studentlistcontent.AllowUserToAddRows = false;
            studentlistcontent.AllowUserToDeleteRows = false;
            studentlistcontent.AllowUserToResizeColumns = false;
            studentlistcontent.AllowUserToResizeRows = false;
            studentlistcontent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentlistcontent.BackgroundColor = Color.FromArgb(255, 255, 255);
            studentlistcontent.BorderStyle = BorderStyle.None;
            studentlistcontent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            studentlistcontent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            studentlistcontent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            studentlistcontent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            studentlistcontent.DefaultCellStyle = dataGridViewCellStyle2;
            studentlistcontent.EnableHeadersVisualStyles = false;
            studentlistcontent.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            studentlistcontent.GridColor = Color.FromArgb(255, 255, 255);
            studentlistcontent.Location = new Point(17, 270);
            studentlistcontent.Name = "studentlistcontent";
            studentlistcontent.ReadOnly = true;
            studentlistcontent.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            studentlistcontent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            studentlistcontent.RowHeadersVisible = false;
            studentlistcontent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            studentlistcontent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentlistcontent.Size = new Size(1126, 474);
            studentlistcontent.TabIndex = 8;
            studentlistcontent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentlistcontent.UseCustomBackColor = true;
            studentlistcontent.UseCustomForeColor = true;
            studentlistcontent.UseStyleColors = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 204);
            label5.Name = "label5";
            label5.Size = new Size(120, 23);
            label5.TabIndex = 16;
            label5.Text = "Student Name";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(287, 204);
            label6.Name = "label6";
            label6.Size = new Size(140, 23);
            label6.TabIndex = 17;
            label6.Text = "Student Number";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(437, 204);
            label7.Name = "label7";
            label7.Size = new Size(120, 23);
            label7.TabIndex = 18;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(687, 204);
            label8.Name = "label8";
            label8.Size = new Size(140, 23);
            label8.TabIndex = 19;
            label8.Text = "Parent Email";
            // 
            // nametext
            // 
            nametext.BackColor = Color.Transparent;
            nametext.BorderColor = Color.FromArgb(180, 180, 180);
            nametext.CustomBGColor = Color.White;
            nametext.Font = new Font("Tahoma", 11F);
            nametext.ForeColor = Color.DimGray;
            nametext.Location = new Point(17, 229);
            nametext.MaxLength = 255;
            nametext.Multiline = false;
            nametext.Name = "nametext";
            nametext.ReadOnly = false;
            nametext.Size = new Size(260, 28);
            nametext.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nametext.TabIndex = 20;
            nametext.TextAlignment = HorizontalAlignment.Left;
            nametext.UseSystemPasswordChar = false;
            // 
            // numtext
            // 
            numtext.BackColor = Color.Transparent;
            numtext.BorderColor = Color.FromArgb(180, 180, 180);
            numtext.CustomBGColor = Color.White;
            numtext.Font = new Font("Tahoma", 11F);
            numtext.ForeColor = Color.DimGray;
            numtext.Location = new Point(287, 229);
            numtext.MaxLength = 255;
            numtext.Multiline = false;
            numtext.Name = "numtext";
            numtext.ReadOnly = false;
            numtext.Size = new Size(140, 28);
            numtext.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            numtext.TabIndex = 21;
            numtext.TextAlignment = HorizontalAlignment.Left;
            numtext.UseSystemPasswordChar = false;
            // 
            // emailtext
            // 
            emailtext.BackColor = Color.Transparent;
            emailtext.BorderColor = Color.FromArgb(180, 180, 180);
            emailtext.CustomBGColor = Color.White;
            emailtext.Font = new Font("Tahoma", 11F);
            emailtext.ForeColor = Color.DimGray;
            emailtext.Location = new Point(437, 229);
            emailtext.MaxLength = 255;
            emailtext.Multiline = false;
            emailtext.Name = "emailtext";
            emailtext.ReadOnly = false;
            emailtext.Size = new Size(240, 28);
            emailtext.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            emailtext.TabIndex = 22;
            emailtext.TextAlignment = HorizontalAlignment.Left;
            emailtext.UseSystemPasswordChar = false;
            // 
            // parenttext
            // 
            parenttext.BackColor = Color.Transparent;
            parenttext.BorderColor = Color.FromArgb(180, 180, 180);
            parenttext.CustomBGColor = Color.White;
            parenttext.Font = new Font("Tahoma", 11F);
            parenttext.ForeColor = Color.DimGray;
            parenttext.Location = new Point(687, 229);
            parenttext.MaxLength = 255;
            parenttext.Multiline = false;
            parenttext.Name = "parenttext";
            parenttext.ReadOnly = false;
            parenttext.Size = new Size(240, 28);
            parenttext.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parenttext.TabIndex = 23;
            parenttext.TextAlignment = HorizontalAlignment.Left;
            parenttext.UseSystemPasswordChar = false;
            // 
            // updatestudentbtn
            // 
            updatestudentbtn.Location = new Point(1003, 222);
            updatestudentbtn.Name = "updatestudentbtn";
            updatestudentbtn.Size = new Size(140, 42);
            updatestudentbtn.TabIndex = 24;
            updatestudentbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            updatestudentbtn.Text = "Update Student";
            updatestudentbtn.Click += updatestudentbtn_Click;
            // 
            // Administrator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(studentlistcontent);
            Controls.Add(updatestudentbtn);
            Controls.Add(parenttext);
            Controls.Add(emailtext);
            Controls.Add(numtext);
            Controls.Add(nametext);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(searchtext);
            Controls.Add(renamesectionbtn);
            Controls.Add(deletesectionbtn);
            Controls.Add(sectioncombo);
            Controls.Add(renamecoursebtn);
            Controls.Add(deletecoursebtn);
            Controls.Add(coursecombo);
            Controls.Add(label4);
            Controls.Add(addsectionbtn);
            Controls.Add(sectiontext);
            Controls.Add(label3);
            Controls.Add(addcoursebtn);
            Controls.Add(coursetext);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Administrator";
            Size = new Size(1160, 760);
            ((System.ComponentModel.ISupportInitialize)studentlistcontent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private ReaLTaiizor.Controls.SmallTextBox coursetext;
        private ReaLTaiizor.Controls.SmallTextBox sectiontext;
        private AntdUI.Button addcoursebtn;
        private AntdUI.Button addsectionbtn;
        private ReaLTaiizor.Controls.AloneComboBox coursecombo;
        private ReaLTaiizor.Controls.AloneComboBox sectioncombo;
        private AntdUI.Button deletecoursebtn;
        private AntdUI.Button renamecoursebtn;
        private AntdUI.Button deletesectionbtn;
        private AntdUI.Button renamesectionbtn;
        private ReaLTaiizor.Controls.SmallTextBox searchtext;
        private AntdUI.Label label5;
        private AntdUI.Label label6;
        private AntdUI.Label label7;
        private AntdUI.Label label8;
        private ReaLTaiizor.Controls.SmallTextBox nametext;
        private ReaLTaiizor.Controls.SmallTextBox numtext;
        private ReaLTaiizor.Controls.SmallTextBox emailtext;
        private ReaLTaiizor.Controls.SmallTextBox parenttext;
        private AntdUI.Button updatestudentbtn;
        private ReaLTaiizor.Controls.PoisonDataGridView studentlistcontent;
    }
}
