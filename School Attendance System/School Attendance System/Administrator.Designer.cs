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
            yearcombo = new ReaLTaiizor.Controls.AloneComboBox();
            semestercombo = new ReaLTaiizor.Controls.AloneComboBox();
            addcoursebtn = new AntdUI.Button();
            addsectionbtn = new AntdUI.Button();
            coursecombo = new ReaLTaiizor.Controls.AloneComboBox();
            sectioncombo = new ReaLTaiizor.Controls.AloneComboBox();
            archivecoursebtn = new AntdUI.Button();
            renamecoursebtn = new AntdUI.Button();
            archivesectionbtn = new AntdUI.Button();
            archivedcoursecombo = new ReaLTaiizor.Controls.AloneComboBox();
            archivedsectioncombo = new ReaLTaiizor.Controls.AloneComboBox();
            restorecoursebtn = new AntdUI.Button();
            restoresectionbtn = new AntdUI.Button();
            label9 = new AntdUI.Label();
            label10 = new AntdUI.Label();
            sectionyearlabel = new AntdUI.Label();
            sectionsemesterlabel = new AntdUI.Label();
            sectionnamelabel = new AntdUI.Label();
            newsemesterlabel = new AntdUI.Label();
            newsectionlabel = new AntdUI.Label();
            sectionyearcombo = new ReaLTaiizor.Controls.AloneComboBox();
            sectionsemestercombo = new ReaLTaiizor.Controls.AloneComboBox();
            renamesectionbtn = new AntdUI.Button();
            searchtext = new AntdUI.Input();
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
            label3.Size = new Size(90, 23);
            label3.TabIndex = 4;
            label3.Text = "Year";
            // 
            // sectiontext
            // 
            sectiontext.BackColor = Color.Transparent;
            sectiontext.BorderColor = Color.FromArgb(180, 180, 180);
            sectiontext.CustomBGColor = Color.White;
            sectiontext.Font = new Font("Tahoma", 11F);
            sectiontext.ForeColor = Color.DimGray;
            sectiontext.Location = new Point(900, 79);
            sectiontext.MaxLength = 10;
            sectiontext.Multiline = false;
            sectiontext.Name = "sectiontext";
            sectiontext.ReadOnly = false;
            sectiontext.Size = new Size(52, 28);
            sectiontext.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            sectiontext.TabIndex = 5;
            sectiontext.TextAlignment = HorizontalAlignment.Left;
            sectiontext.UseSystemPasswordChar = false;
            // 
            // addsectionbtn
            // 
            addsectionbtn.Location = new Point(970, 72);
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
            // archivecoursebtn
            // 
            archivecoursebtn.Location = new Point(423, 119);
            archivecoursebtn.Name = "archivecoursebtn";
            archivecoursebtn.Size = new Size(88, 42);
            archivecoursebtn.TabIndex = 11;
            archivecoursebtn.Text = "Archive";
            archivecoursebtn.Click += archivecoursebtn_Click;
            // 
            // sectioncombo
            // 
            sectioncombo.DrawMode = DrawMode.OwnerDrawFixed;
            sectioncombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sectioncombo.EnabledCalc = true;
            sectioncombo.FormattingEnabled = true;
            sectioncombo.ItemHeight = 20;
            sectioncombo.Location = new Point(840, 139);
            sectioncombo.Name = "sectioncombo";
            sectioncombo.Size = new Size(75, 26);
            sectioncombo.TabIndex = 12;
            sectioncombo.SelectedIndexChanged += sectioncombo_SelectedIndexChanged;
            yearcombo.DrawMode = DrawMode.OwnerDrawFixed;
            yearcombo.DropDownStyle = ComboBoxStyle.DropDownList;
            yearcombo.EnabledCalc = true;
            yearcombo.FormattingEnabled = true;
            yearcombo.ItemHeight = 20;
            yearcombo.Location = new Point(620, 79);
            yearcombo.Name = "yearcombo";
            yearcombo.Size = new Size(115, 26);
            yearcombo.TabIndex = 25;
            semestercombo.DrawMode = DrawMode.OwnerDrawFixed;
            semestercombo.DropDownStyle = ComboBoxStyle.DropDownList;
            semestercombo.EnabledCalc = true;
            semestercombo.FormattingEnabled = true;
            semestercombo.ItemHeight = 20;
            semestercombo.Location = new Point(750, 79);
            semestercombo.Name = "semestercombo";
            semestercombo.Size = new Size(135, 26);
            semestercombo.TabIndex = 26;
            newsemesterlabel.Location = new Point(750, 50);
            newsemesterlabel.Name = "newsemesterlabel";
            newsemesterlabel.Size = new Size(100, 23);
            newsemesterlabel.Text = "Semester";
            newsectionlabel.Location = new Point(900, 50);
            newsectionlabel.Name = "newsectionlabel";
            newsectionlabel.Size = new Size(75, 23);
            newsectionlabel.Text = "Section";
            sectionyearlabel.Location = new Point(620, 116);
            sectionyearlabel.Name = "sectionyearlabel";
            sectionyearlabel.Size = new Size(90, 23);
            sectionyearlabel.Text = "Year";
            sectionsemesterlabel.Location = new Point(725, 116);
            sectionsemesterlabel.Name = "sectionsemesterlabel";
            sectionsemesterlabel.Size = new Size(100, 23);
            sectionsemesterlabel.Text = "Semester";
            sectionnamelabel.Location = new Point(840, 116);
            sectionnamelabel.Name = "sectionnamelabel";
            sectionnamelabel.Size = new Size(75, 23);
            sectionnamelabel.Text = "Section";
            sectionyearcombo.DrawMode = DrawMode.OwnerDrawFixed;
            sectionyearcombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sectionyearcombo.EnabledCalc = true;
            sectionyearcombo.FormattingEnabled = true;
            sectionyearcombo.ItemHeight = 20;
            sectionyearcombo.Location = new Point(620, 139);
            sectionyearcombo.Name = "sectionyearcombo";
            sectionyearcombo.Size = new Size(95, 26);
            sectionyearcombo.TabIndex = 27;
            sectionsemestercombo.DrawMode = DrawMode.OwnerDrawFixed;
            sectionsemestercombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sectionsemestercombo.EnabledCalc = true;
            sectionsemestercombo.FormattingEnabled = true;
            sectionsemestercombo.ItemHeight = 20;
            sectionsemestercombo.Location = new Point(725, 139);
            sectionsemestercombo.Name = "sectionsemestercombo";
            sectionsemestercombo.Size = new Size(105, 26);
            sectionsemestercombo.TabIndex = 28;
            sectionyearcombo.SelectedIndexChanged += sectionfilter_SelectedIndexChanged;
            sectionsemestercombo.SelectedIndexChanged += sectionfilter_SelectedIndexChanged;
            // 
            // renamesectionbtn
            // 
            renamesectionbtn.Location = new Point(925, 131);
            renamesectionbtn.Name = "renamesectionbtn";
            renamesectionbtn.Size = new Size(88, 42);
            renamesectionbtn.TabIndex = 13;
            renamesectionbtn.Text = "Rename";
            renamesectionbtn.Click += renamesectionbtn_Click;
            // archivesectionbtn
            archivesectionbtn.Location = new Point(1023, 131);
            archivesectionbtn.Name = "archivesectionbtn";
            archivesectionbtn.Size = new Size(88, 42);
            archivesectionbtn.TabIndex = 14;
            archivesectionbtn.Text = "Archive";
            archivesectionbtn.Click += archivesectionbtn_Click;
            // Archived catalog controls
            label9.Location = new Point(17, 185);
            label9.Name = "label9";
            label9.Size = new Size(220, 23);
            label9.Text = "Archived Courses";
            archivedcoursecombo.DropDownStyle = ComboBoxStyle.DropDownList;
            archivedcoursecombo.Location = new Point(17, 209);
            archivedcoursecombo.Name = "archivedcoursecombo";
            archivedcoursecombo.Size = new Size(250, 26);
            restorecoursebtn.Location = new Point(277, 202);
            restorecoursebtn.Name = "restorecoursebtn";
            restorecoursebtn.Size = new Size(110, 40);
            restorecoursebtn.Text = "Restore";
            restorecoursebtn.Click += restorecoursebtn_Click;
            label10.Location = new Point(620, 185);
            label10.Name = "label10";
            label10.Size = new Size(220, 23);
            label10.Text = "Archived Sections";
            archivedsectioncombo.DropDownStyle = ComboBoxStyle.DropDownList;
            archivedsectioncombo.Location = new Point(620, 209);
            archivedsectioncombo.Name = "archivedsectioncombo";
            archivedsectioncombo.Size = new Size(290, 26);
            restoresectionbtn.Location = new Point(920, 202);
            restoresectionbtn.Name = "restoresectionbtn";
            restoresectionbtn.Size = new Size(110, 40);
            restoresectionbtn.Text = "Restore";
            restoresectionbtn.Click += restoresectionbtn_Click;
            // 
            // searchtext
            // 
            searchtext.AllowClear = true;
            searchtext.Location = new Point(811, 255);
            searchtext.Name = "searchtext";
            searchtext.Size = new Size(332, 36);
            searchtext.TabIndex = 15;
            searchtext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchtext.TextChanged += searchtext_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 259);
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
            studentlistcontent.Location = new Point(17, 355);
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
            studentlistcontent.Size = new Size(1126, 409);
            studentlistcontent.TabIndex = 8;
            studentlistcontent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentlistcontent.UseCustomBackColor = true;
            studentlistcontent.UseCustomForeColor = true;
            studentlistcontent.UseStyleColors = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 289);
            label5.Name = "label5";
            label5.Size = new Size(120, 23);
            label5.TabIndex = 16;
            label5.Text = "Student Name";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(287, 289);
            label6.Name = "label6";
            label6.Size = new Size(140, 23);
            label6.TabIndex = 17;
            label6.Text = "Student Number";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(437, 289);
            label7.Name = "label7";
            label7.Size = new Size(120, 23);
            label7.TabIndex = 18;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(687, 289);
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
            nametext.Location = new Point(17, 314);
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
            numtext.Location = new Point(287, 314);
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
            emailtext.Location = new Point(437, 314);
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
            parenttext.Location = new Point(687, 314);
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
            updatestudentbtn.Location = new Point(1003, 307);
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
            Controls.Add(label9);
            Controls.Add(archivedcoursecombo);
            Controls.Add(restorecoursebtn);
            Controls.Add(label10);
            Controls.Add(archivedsectioncombo);
            Controls.Add(restoresectionbtn);
            Controls.Add(sectionyearlabel);
            Controls.Add(sectionsemesterlabel);
            Controls.Add(sectionnamelabel);
            Controls.Add(newsemesterlabel);
            Controls.Add(newsectionlabel);
            Controls.Add(sectionyearcombo);
            Controls.Add(sectionsemestercombo);
            Controls.Add(renamesectionbtn);
            Controls.Add(archivesectionbtn);
            Controls.Add(sectioncombo);
            Controls.Add(renamecoursebtn);
            Controls.Add(archivecoursebtn);
            Controls.Add(coursecombo);
            Controls.Add(label4);
            Controls.Add(addsectionbtn);
            Controls.Add(sectiontext);
            Controls.Add(yearcombo);
            Controls.Add(semestercombo);
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
        private ReaLTaiizor.Controls.AloneComboBox yearcombo;
        private ReaLTaiizor.Controls.AloneComboBox semestercombo;
        private AntdUI.Button addcoursebtn;
        private AntdUI.Button addsectionbtn;
        private ReaLTaiizor.Controls.AloneComboBox coursecombo;
        private ReaLTaiizor.Controls.AloneComboBox sectioncombo;
        private AntdUI.Button archivecoursebtn;
        private AntdUI.Button renamecoursebtn;
        private AntdUI.Button archivesectionbtn;
        private AntdUI.Button renamesectionbtn;
        private AntdUI.Input searchtext;
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
        private ReaLTaiizor.Controls.AloneComboBox archivedcoursecombo;
        private ReaLTaiizor.Controls.AloneComboBox archivedsectioncombo;
        private AntdUI.Button restorecoursebtn;
        private AntdUI.Button restoresectionbtn;
        private AntdUI.Label label9;
        private AntdUI.Label label10;
        private AntdUI.Label sectionyearlabel;
        private AntdUI.Label sectionsemesterlabel;
        private AntdUI.Label sectionnamelabel;
        private AntdUI.Label newsemesterlabel;
        private AntdUI.Label newsectionlabel;
        private ReaLTaiizor.Controls.AloneComboBox sectionyearcombo;
        private ReaLTaiizor.Controls.AloneComboBox sectionsemestercombo;
    }
}
