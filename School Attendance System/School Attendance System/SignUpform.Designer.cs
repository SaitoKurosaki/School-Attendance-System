namespace School_Attendance_System
{
    partial class SignUpform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpform));
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            linkLabel2 = new LinkLabel();
            submitbtn = new AntdUI.Button();
            cancelbtn = new AntdUI.Button();
            showpass = new AntdUI.Checkbox();
            confirmpassbox = new AntdUI.Input();
            fullnamebox = new AntdUI.Input();
            emailbox = new AntdUI.Input();
            passwordbox = new AntdUI.Input();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(156, 183);
            label2.Name = "label2";
            label2.Size = new Size(156, 15);
            label2.TabIndex = 14;
            label2.Text = "Fill in the information below";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(102, 144);
            label1.Name = "label1";
            label1.Size = new Size(262, 25);
            label1.TabIndex = 13;
            label1.Text = "CREATE TEACHER ACCOUNT";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(175, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 97);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 221);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(62, 15);
            label3.TabIndex = 16;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(63, 298);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 18;
            label4.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(63, 452);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 26;
            label8.Text = "Confirm Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(63, 377);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 24;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 623);
            label6.Name = "label6";
            label6.Size = new Size(142, 15);
            label6.TabIndex = 21;
            label6.Text = "Already have an account?";
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.DeepSkyBlue;
            linkLabel2.AutoSize = true;
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = SystemColors.HotTrack;
            linkLabel2.Location = new Point(299, 623);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(37, 15);
            linkLabel2.TabIndex = 22;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Login";
            linkLabel2.LinkClicked += linkLabel1_LinkClicked;
            // 
            // submitbtn
            // 
            submitbtn.Location = new Point(54, 569);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(129, 38);
            submitbtn.TabIndex = 30;
            submitbtn.Text = "Submit";
            submitbtn.Click += submitbtn_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.Location = new Point(299, 569);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(129, 38);
            cancelbtn.TabIndex = 31;
            cancelbtn.Text = "Cancel";
            // 
            // showpass
            // 
            showpass.Location = new Point(54, 523);
            showpass.Name = "showpass";
            showpass.Size = new Size(119, 23);
            showpass.TabIndex = 32;
            showpass.Text = "Show Password";
            showpass.CheckedChanged += showpass_CheckedChanged;
            // 
            // confirmpassbox
            // 
            confirmpassbox.Location = new Point(54, 470);
            confirmpassbox.Name = "confirmpassbox";
            confirmpassbox.Size = new Size(374, 47);
            confirmpassbox.TabIndex = 33;
            confirmpassbox.TextChanged += confirmpassbox_TextChanged;
            // 
            // fullnamebox
            // 
            fullnamebox.Location = new Point(54, 239);
            fullnamebox.Name = "fullnamebox";
            fullnamebox.Size = new Size(374, 47);
            fullnamebox.TabIndex = 34;
            fullnamebox.TextChanged += input2_TextChanged;
            // 
            // emailbox
            // 
            emailbox.Location = new Point(54, 316);
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(374, 47);
            emailbox.TabIndex = 35;
            emailbox.TextChanged += emailbox_TextChanged;
            // 
            // passwordbox
            // 
            passwordbox.Location = new Point(54, 395);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(374, 47);
            passwordbox.TabIndex = 36;
            passwordbox.TextChanged += passwordbox_TextChanged_1;
            // 
            // SignUpform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 669);
            Controls.Add(passwordbox);
            Controls.Add(emailbox);
            Controls.Add(fullnamebox);
            Controls.Add(confirmpassbox);
            Controls.Add(showpass);
            Controls.Add(cancelbtn);
            Controls.Add(submitbtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(linkLabel2);
            Controls.Add(label6);
            Controls.Add(label4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignUpform";
            Text = "School Attendance System - Sign Up";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private LinkLabel linkLabel2;
        private AntdUI.Button submitbtn;
        private AntdUI.Button cancelbtn;
        private AntdUI.Checkbox showpass;
        private AntdUI.Input confirmpassbox;
        private AntdUI.Input fullnamebox;
        private AntdUI.Input emailbox;
        private AntdUI.Input passwordbox;
    }
}