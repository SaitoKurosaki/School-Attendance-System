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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new AntdUI.Panel();
            studentlistcontent = new ReaLTaiizor.Controls.PoisonDataGridView();
            label1 = new AntdUI.Label();
            searchtext = new ReaLTaiizor.Controls.SmallTextBox();
            searchbtn = new AntdUI.Button();
            searchall = new AntdUI.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentlistcontent).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(studentlistcontent);
            panel1.Location = new Point(13, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 481);
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
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
            studentlistcontent.Location = new Point(4, 3);
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
            studentlistcontent.Size = new Size(892, 475);
            studentlistcontent.TabIndex = 10;
            studentlistcontent.UseCustomBackColor = true;
            studentlistcontent.UseCustomForeColor = true;
            studentlistcontent.UseStyleColors = true;
            studentlistcontent.CellContentClick += studentlist_CellContentClick;
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
            // searchtext
            // 
            searchtext.BackColor = Color.Transparent;
            searchtext.BorderColor = Color.FromArgb(180, 180, 180);
            searchtext.CustomBGColor = Color.White;
            searchtext.Font = new Font("Tahoma", 11F);
            searchtext.ForeColor = Color.DimGray;
            searchtext.Location = new Point(13, 44);
            searchtext.MaxLength = 32767;
            searchtext.Multiline = false;
            searchtext.Name = "searchtext";
            searchtext.ReadOnly = false;
            searchtext.Size = new Size(337, 28);
            searchtext.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            searchtext.TabIndex = 2;
            searchtext.TextAlignment = HorizontalAlignment.Left;
            searchtext.UseSystemPasswordChar = false;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(403, 31);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(103, 41);
            searchbtn.TabIndex = 3;
            searchbtn.Text = "Search";
            searchbtn.Click += button1_Click;
            // 
            // searchall
            // 
            searchall.Location = new Point(530, 31);
            searchall.Name = "searchall";
            searchall.Size = new Size(103, 41);
            searchall.TabIndex = 4;
            searchall.Text = "Search All";
            searchall.Click += searchall_Click;
            // 
            // manuelstudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchall);
            Controls.Add(searchbtn);
            Controls.Add(searchtext);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "manuelstudents";
            Size = new Size(926, 586);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)studentlistcontent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.Label label1;
        private ReaLTaiizor.Controls.PoisonDataGridView studentlistcontent;
        private ReaLTaiizor.Controls.SmallTextBox searchtext;
        private AntdUI.Button searchbtn;
        private AntdUI.Button searchall;
    }
}
