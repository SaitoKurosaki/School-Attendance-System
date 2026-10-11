namespace School_Attendance_System
{
    partial class classcode
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
            coursecombo = new ReaLTaiizor.Controls.AloneComboBox();
            sectioncombo = new ReaLTaiizor.Controls.AloneComboBox();
            codebtn = new AntdUI.ButtonShadow();
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            listcodecontent = new ReaLTaiizor.Controls.PoisonDataGridView();
            ((System.ComponentModel.ISupportInitialize)listcodecontent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(117, 35);
            label1.TabIndex = 3;
            label1.Text = "Class Code";
            // 
            // coursecombo
            // 
            coursecombo.DrawMode = DrawMode.OwnerDrawFixed;
            coursecombo.DropDownStyle = ComboBoxStyle.DropDownList;
            coursecombo.EnabledCalc = true;
            coursecombo.FormattingEnabled = true;
            coursecombo.ItemHeight = 20;
            coursecombo.Location = new Point(17, 79);
            coursecombo.Name = "coursecombo";
            coursecombo.Size = new Size(293, 26);
            coursecombo.TabIndex = 13;
            // 
            // sectioncombo
            // 
            sectioncombo.DrawMode = DrawMode.OwnerDrawFixed;
            sectioncombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sectioncombo.EnabledCalc = true;
            sectioncombo.FormattingEnabled = true;
            sectioncombo.ItemHeight = 20;
            sectioncombo.Location = new Point(342, 79);
            sectioncombo.Name = "sectioncombo";
            sectioncombo.Size = new Size(217, 26);
            sectioncombo.TabIndex = 14;
            // 
            // codebtn
            // 
            codebtn.Location = new Point(692, 63);
            codebtn.Name = "codebtn";
            codebtn.Size = new Size(217, 42);
            codebtn.TabIndex = 15;
            codebtn.Text = "Create Class Code";
            codebtn.Click += codebtn_Click;
            // 
            // label2
            // 
            label2.Location = new Point(17, 50);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 16;
            label2.Text = "Course";
            // 
            // label3
            // 
            label3.Location = new Point(342, 50);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 17;
            label3.Text = "Section";
            // 
            // listcodecontent
            // 
            listcodecontent.AllowUserToAddRows = false;
            listcodecontent.AllowUserToDeleteRows = false;
            listcodecontent.AllowUserToResizeColumns = false;
            listcodecontent.AllowUserToResizeRows = false;
            listcodecontent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listcodecontent.BackgroundColor = Color.FromArgb(255, 255, 255);
            listcodecontent.BorderStyle = BorderStyle.None;
            listcodecontent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            listcodecontent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            listcodecontent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            listcodecontent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            listcodecontent.DefaultCellStyle = dataGridViewCellStyle2;
            listcodecontent.EnableHeadersVisualStyles = false;
            listcodecontent.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            listcodecontent.GridColor = Color.FromArgb(255, 255, 255);
            listcodecontent.Location = new Point(17, 124);
            listcodecontent.Name = "listcodecontent";
            listcodecontent.ReadOnly = true;
            listcodecontent.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            listcodecontent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            listcodecontent.RowHeadersVisible = false;
            listcodecontent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            listcodecontent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listcodecontent.Size = new Size(892, 450);
            listcodecontent.TabIndex = 12;
            listcodecontent.UseCustomBackColor = true;
            listcodecontent.UseCustomForeColor = true;
            listcodecontent.UseStyleColors = true;
            listcodecontent.CellContentClick += recentAttendanceGrid_CellContentClick;
            // 
            // classcode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(codebtn);
            Controls.Add(sectioncombo);
            Controls.Add(coursecombo);
            Controls.Add(listcodecontent);
            Controls.Add(label1);
            Name = "classcode";
            Size = new Size(926, 586);
            ((System.ComponentModel.ISupportInitialize)listcodecontent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private ReaLTaiizor.Controls.AloneComboBox coursecombo;
        private ReaLTaiizor.Controls.AloneComboBox sectioncombo;
        private AntdUI.ButtonShadow codebtn;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private ReaLTaiizor.Controls.PoisonDataGridView listcodecontent;
    }
}
