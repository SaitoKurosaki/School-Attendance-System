namespace School_Attendance_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLog = new Button();
            btnSign = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLog
            // 
            btnLog.BackColor = SystemColors.Control;
            btnLog.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLog.Location = new Point(256, 198);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(342, 50);
            btnLog.TabIndex = 0;
            btnLog.Text = "Login";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLogin_Click;
            // 
            // btnSign
            // 
            btnSign.BackColor = SystemColors.Control;
            btnSign.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSign.Location = new Point(256, 288);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(342, 50);
            btnSign.TabIndex = 1;
            btnSign.Text = "Sign Up";
            btnSign.UseVisualStyleBackColor = false;
            btnSign.Click += btnSign_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(283, 68);
            label1.Name = "label1";
            label1.Size = new Size(296, 34);
            label1.TabIndex = 2;
            label1.Text = "Student Attendance";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(851, 508);
            Controls.Add(label1);
            Controls.Add(btnSign);
            Controls.Add(btnLog);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLog;
        private Button btnSign;
        private Label label1;
    }
}
