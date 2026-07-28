namespace School_Attendance_System
{
    partial class verification
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verification));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            emaillabel = new Label();
            verificationbox = new TextBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(152, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 91);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(97, 136);
            label1.Name = "label1";
            label1.Size = new Size(284, 25);
            label1.TabIndex = 1;
            label1.Text = "VERIFY YOUR EMAIL ADDRESS";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 172);
            label2.Name = "label2";
            label2.Size = new Size(219, 15);
            label2.TabIndex = 2;
            label2.Text = "We've send a 6-digit verification code to";
            // 
            // emaillabel
            // 
            emaillabel.ForeColor = SystemColors.HotTrack;
            emaillabel.Location = new Point(119, 196);
            emaillabel.Name = "emaillabel";
            emaillabel.Size = new Size(232, 15);
            emaillabel.TabIndex = 3;
            emaillabel.Text = "manuellucioporcinculaxworld@gmail.com";
            emaillabel.TextAlign = ContentAlignment.MiddleCenter;
            emaillabel.Click += label3_Click;
            // 
            // verificationbox
            // 
            verificationbox.BackColor = SystemColors.Control;
            verificationbox.BorderStyle = BorderStyle.None;
            verificationbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verificationbox.Location = new Point(3, 3);
            verificationbox.Name = "verificationbox";
            verificationbox.PlaceholderText = "Enter 6-digit code";
            verificationbox.Size = new Size(305, 22);
            verificationbox.TabIndex = 26;
            verificationbox.TextChanged += emailbox_TextChanged;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(verificationbox);
            panel2.Location = new Point(56, 240);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 33);
            panel2.TabIndex = 20;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 222);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 0;
            label5.Text = "Verification";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(153, 296);
            button1.Name = "button1";
            button1.Size = new Size(157, 38);
            button1.TabIndex = 22;
            button1.Text = "Verify Email";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(12, 373);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 1);
            panel1.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(229, 359);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 24;
            label4.Text = "OR";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(270, 373);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 1);
            panel3.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(177, 388);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 26;
            label6.Text = "Didn't receive the code?";
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.DeepSkyBlue;
            linkLabel2.AutoSize = true;
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = SystemColors.HotTrack;
            linkLabel2.Location = new Point(202, 413);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(76, 15);
            linkLabel2.TabIndex = 27;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Resend Code";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DeepSkyBlue;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = SystemColors.HotTrack;
            linkLabel1.Location = new Point(12, 455);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(92, 15);
            linkLabel1.TabIndex = 28;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back To Sign Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // verification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 489);
            Controls.Add(linkLabel1);
            Controls.Add(linkLabel2);
            Controls.Add(label6);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(emaillabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "verification";
            Text = "School Attendance System - Email Verification";
            Load += verification_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label emaillabel;
        private TextBox verificationbox;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label label5;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Label label4;
        private Panel panel3;
        private Label label6;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
    }
}