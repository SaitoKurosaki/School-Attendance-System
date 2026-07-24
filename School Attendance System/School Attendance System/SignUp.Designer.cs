namespace School_Attendance_System
{
    partial class SignUp
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
            label1 = new Label();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            txtConfirm = new TextBox();
            bntSign = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 40);
            label1.Name = "label1";
            label1.Size = new Size(275, 25);
            label1.TabIndex = 0;
            label1.Text = "Create your Account now!";
            label1.Click += label1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(276, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(327, 47);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(276, 215);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Password";
            txtPass.Size = new Size(327, 47);
            txtPass.TabIndex = 2;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // txtConfirm
            // 
            txtConfirm.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirm.Location = new Point(276, 294);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PlaceholderText = "Confirm Password";
            txtConfirm.Size = new Size(327, 47);
            txtConfirm.TabIndex = 3;
            // 
            // bntSign
            // 
            bntSign.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntSign.Location = new Point(276, 387);
            bntSign.Name = "bntSign";
            bntSign.Size = new Size(327, 62);
            bntSign.TabIndex = 4;
            bntSign.Text = "Sign Up";
            bntSign.UseVisualStyleBackColor = true;
            bntSign.Click += bntSign_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(851, 508);
            Controls.Add(bntSign);
            Controls.Add(txtConfirm);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private TextBox txtPass;
        private TextBox txtConfirm;
        private Button bntSign;
    }
}