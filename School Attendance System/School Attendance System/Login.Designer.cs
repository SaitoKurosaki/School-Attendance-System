namespace School_Attendance_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            passwordbox = new AntdUI.Input();
            emailbox = new AntdUI.Input();
            loginbtn = new AntdUI.Button();
            showpass = new AntdUI.Checkbox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(188, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 97);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(117, 152);
            label1.Name = "label1";
            label1.Size = new Size(294, 25);
            label1.TabIndex = 1;
            label1.Text = "SCHOOL ATTENDANCE SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(206, 186);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 2;
            label2.Text = "Please login to continue";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 229);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 309);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 503);
            label5.Name = "label5";
            label5.Size = new Size(131, 15);
            label5.TabIndex = 9;
            label5.Text = "Don't have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DeepSkyBlue;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = SystemColors.HotTrack;
            linkLabel1.Location = new Point(292, 503);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(48, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // passwordbox
            // 
            passwordbox.Location = new Point(53, 331);
            passwordbox.Name = "passwordbox";
            passwordbox.PasswordChar = '*';
            passwordbox.Size = new Size(374, 47);
            passwordbox.TabIndex = 35;
            passwordbox.TextChanged += passwordbox_TextChanged;
            // 
            // emailbox
            // 
            emailbox.Location = new Point(53, 247);
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(374, 47);
            emailbox.TabIndex = 36;
            emailbox.TextChanged += emailbox_TextChanged_1;
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(174, 436);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(140, 37);
            loginbtn.TabIndex = 38;
            loginbtn.Text = "Login";
            loginbtn.Click += loginbtn_Click;
            // 
            // showpass
            // 
            showpass.Location = new Point(66, 396);
            showpass.Name = "showpass";
            showpass.Size = new Size(119, 23);
            showpass.TabIndex = 39;
            showpass.Text = "Show Password";
            showpass.CheckedChanged += showpass_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 601);
            Controls.Add(showpass);
            Controls.Add(loginbtn);
            Controls.Add(emailbox);
            Controls.Add(passwordbox);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "School Attendance System - Login";
            Load += mainform_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel1;
        private AntdUI.Input passwordbox;
        private AntdUI.Input emailbox;
        private AntdUI.Button loginbtn;
        private AntdUI.Checkbox showpass;
    }
}