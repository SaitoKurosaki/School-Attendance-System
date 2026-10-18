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
            searchtext = new AntdUI.Input();
            studentlistcontent = new ReaLTaiizor.Controls.PoisonDataGridView();
            ((System.ComponentModel.ISupportInitialize)studentlistcontent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 1;
            label1.Text = "Students";
            // 
            // searchtext
            // 
            searchtext.AllowClear = true;
            searchtext.Location = new Point(16, 52);
            searchtext.Name = "searchtext";
            searchtext.Size = new Size(360, 36);
            searchtext.TabIndex = 2;
            searchtext.TextChanged += searchtext_TextChanged;
            // 
            // studentlistcontent
            // 
            studentlistcontent.AllowUserToAddRows = false;
            studentlistcontent.AllowUserToDeleteRows = false;
            studentlistcontent.AllowUserToResizeColumns = false;
            studentlistcontent.AllowUserToResizeRows = false;
            studentlistcontent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentlistcontent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentlistcontent.BackgroundColor = Color.FromArgb(255, 255, 255);
            studentlistcontent.BorderStyle = BorderStyle.None;
            studentlistcontent.CellBorderStyle = DataGridViewCellBorderStyle.None;
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
            studentlistcontent.Location = new Point(16, 100);
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
            studentlistcontent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            studentlistcontent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentlistcontent.Size = new Size(1104, 644);
            studentlistcontent.TabIndex = 10;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(studentlistcontent);
            Controls.Add(searchtext);
            Controls.Add(label1);
            Name = "Students";
            Size = new Size(1136, 760);
            ((System.ComponentModel.ISupportInitialize)studentlistcontent).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Label label1;
        private AntdUI.Input searchtext;
        private ReaLTaiizor.Controls.PoisonDataGridView studentlistcontent;
    }
}
