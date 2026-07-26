namespace School_Attendance_System
{
    partial class MainLogin
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
            btnLog = new Button();
            txtUsername = new TextBox();
            txtPass = new TextBox();
            lnkForgotPass = new LinkLabel();
            chkShowPass = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.RoyalBlue;
            btnLog.Cursor = Cursors.Hand;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLog.ForeColor = SystemColors.Control;
            btnLog.Location = new Point(452, 481);
            btnLog.Margin = new Padding(3, 4, 3, 4);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(477, 63);
            btnLog.TabIndex = 1;
            btnLog.Text = "Login";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(452, 277);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(477, 47);
            txtUsername.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(452, 357);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Password";
            txtPass.Size = new Size(477, 47);
            txtPass.TabIndex = 3;
            // 
            // lnkForgotPass
            // 
            lnkForgotPass.AutoSize = true;
            lnkForgotPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkForgotPass.LinkColor = Color.RoyalBlue;
            lnkForgotPass.Location = new Point(614, 556);
            lnkForgotPass.Name = "lnkForgotPass";
            lnkForgotPass.Size = new Size(143, 23);
            lnkForgotPass.TabIndex = 4;
            lnkForgotPass.TabStop = true;
            lnkForgotPass.Text = "Forgot Password?";
            lnkForgotPass.LinkClicked += lnkForgotPass_LinkClicked;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPass.Location = new Point(453, 415);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(158, 29);
            chkShowPass.TabIndex = 5;
            chkShowPass.Text = "Show Password";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(625, 146);
            label1.Name = "label1";
            label1.Size = new Size(102, 34);
            label1.TabIndex = 6;
            label1.Text = "Login";
            // 
            // MainLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(label1);
            Controls.Add(chkShowPass);
            Controls.Add(lnkForgotPass);
            Controls.Add(txtPass);
            Controls.Add(txtUsername);
            Controls.Add(btnLog);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainLogin";
            Text = "MainLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLog;
        private TextBox txtUsername;
        private TextBox txtPass;
        private LinkLabel lnkForgotPass;
        private CheckBox chkShowPass;
        private Label label1;
    }
}