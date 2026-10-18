namespace School_Attendance_System
{
    partial class Teachers
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
            teacherlistcontent = new ReaLTaiizor.Controls.PoisonDataGridView();
            rolecombo = new ReaLTaiizor.Controls.AloneComboBox();
            changebtn = new AntdUI.Button();
            removebtn = new AntdUI.Button();
            ((System.ComponentModel.ISupportInitialize)teacherlistcontent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(160, 35);
            label1.TabIndex = 0;
            label1.Text = "Teachers";
            // 
            // teacherlistcontent
            // 
            teacherlistcontent.AllowUserToAddRows = false;
            teacherlistcontent.AllowUserToDeleteRows = false;
            teacherlistcontent.AllowUserToResizeColumns = false;
            teacherlistcontent.AllowUserToResizeRows = false;
            teacherlistcontent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            teacherlistcontent.BackgroundColor = Color.FromArgb(255, 255, 255);
            teacherlistcontent.BorderStyle = BorderStyle.None;
            teacherlistcontent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            teacherlistcontent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            teacherlistcontent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            teacherlistcontent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            teacherlistcontent.DefaultCellStyle = dataGridViewCellStyle2;
            teacherlistcontent.EnableHeadersVisualStyles = false;
            teacherlistcontent.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            teacherlistcontent.GridColor = Color.FromArgb(255, 255, 255);
            teacherlistcontent.Location = new Point(17, 50);
            teacherlistcontent.Name = "teacherlistcontent";
            teacherlistcontent.ReadOnly = true;
            teacherlistcontent.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            teacherlistcontent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            teacherlistcontent.RowHeadersVisible = false;
            teacherlistcontent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            teacherlistcontent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            teacherlistcontent.Size = new Size(1126, 560);
            teacherlistcontent.TabIndex = 1;
            teacherlistcontent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            teacherlistcontent.UseCustomBackColor = true;
            teacherlistcontent.UseCustomForeColor = true;
            teacherlistcontent.UseStyleColors = true;
            // 
            // label2
            // 
            label2.Location = new Point(17, 620);
            label2.Name = "label2";
            label2.Size = new Size(360, 23);
            label2.TabIndex = 2;
            label2.Text = "Select a teacher above, then choose a role";
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            // 
            // rolecombo
            // 
            rolecombo.DrawMode = DrawMode.OwnerDrawFixed;
            rolecombo.DropDownStyle = ComboBoxStyle.DropDownList;
            rolecombo.EnabledCalc = true;
            rolecombo.FormattingEnabled = true;
            rolecombo.ItemHeight = 20;
            rolecombo.Location = new Point(17, 650);
            rolecombo.Name = "rolecombo";
            rolecombo.Size = new Size(210, 26);
            rolecombo.TabIndex = 3;
            rolecombo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            // 
            // changebtn
            // 
            changebtn.Location = new Point(237, 642);
            changebtn.Name = "changebtn";
            changebtn.Size = new Size(120, 42);
            changebtn.TabIndex = 4;
            changebtn.Text = "Change Role";
            changebtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            changebtn.Click += changeroledbtn_Click;
            // 
            // removebtn
            // 
            removebtn.Location = new Point(367, 642);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(140, 42);
            removebtn.TabIndex = 5;
            removebtn.Text = "Remove Teacher";
            removebtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            removebtn.Click += removeteacherbtn_Click;
            // 
            // Teachers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(removebtn);
            Controls.Add(changebtn);
            Controls.Add(rolecombo);
            Controls.Add(label2);
            Controls.Add(teacherlistcontent);
            Controls.Add(label1);
            Name = "Teachers";
            Size = new Size(1160, 760);
            ((System.ComponentModel.ISupportInitialize)teacherlistcontent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private ReaLTaiizor.Controls.PoisonDataGridView teacherlistcontent;
        private ReaLTaiizor.Controls.AloneComboBox rolecombo;
        private AntdUI.Button changebtn;
        private AntdUI.Button removebtn;
    }
}
