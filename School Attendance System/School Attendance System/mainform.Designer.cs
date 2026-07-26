namespace School_Attendance_System
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            emailbox = new TextBox();
            label3 = new Label();
            passwordbox = new TextBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            showpassword = new CheckBox();
            LoginBtn = new Button();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(emailbox);
            panel1.Location = new Point(66, 247);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 33);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(330, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 37);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // emailbox
            // 
            emailbox.BackColor = SystemColors.Control;
            emailbox.BorderStyle = BorderStyle.None;
            emailbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailbox.Location = new Point(3, 3);
            emailbox.Name = "emailbox";
            emailbox.PlaceholderText = "Enter Your Email";
            emailbox.Size = new Size(305, 22);
            emailbox.TabIndex = 1;
            emailbox.TextChanged += emailbox_TextChanged;
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
            // passwordbox
            // 
            passwordbox.BackColor = SystemColors.Control;
            passwordbox.BorderStyle = BorderStyle.None;
            passwordbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordbox.Location = new Point(3, 3);
            passwordbox.Name = "passwordbox";
            passwordbox.PasswordChar = '*';
            passwordbox.PlaceholderText = "Enter Your Password";
            passwordbox.Size = new Size(305, 22);
            passwordbox.TabIndex = 0;
            passwordbox.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(passwordbox);
            panel2.Location = new Point(66, 327);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 33);
            panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(330, -5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 37);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
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
            // showpassword
            // 
            showpassword.AutoSize = true;
            showpassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showpassword.Location = new Point(66, 384);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(112, 19);
            showpassword.TabIndex = 7;
            showpassword.Text = "Show Password";
            showpassword.UseVisualStyleBackColor = true;
            showpassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.HotTrack;
            LoginBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.Transparent;
            LoginBtn.Location = new Point(66, 427);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Padding = new Padding(15, 0, 0, 0);
            LoginBtn.Size = new Size(393, 38);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Login";
            LoginBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += button1_Click;
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
            // mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 601);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(LoginBtn);
            Controls.Add(showpassword);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainform";
            Text = "School Attendance System - Login";
            Load += mainform_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox emailbox;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox passwordbox;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label label4;
        private CheckBox showpassword;
        private Button LoginBtn;
        private Label label5;
        private LinkLabel linkLabel1;
    }
}