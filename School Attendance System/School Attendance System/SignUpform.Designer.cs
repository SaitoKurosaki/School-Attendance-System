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
            firstnamebox = new TextBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            emailbox = new TextBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            label4 = new Label();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            passwordbox = new TextBox();
            button2 = new Button();
            label8 = new Label();
            panel5 = new Panel();
            pictureBox6 = new PictureBox();
            confirmbox = new TextBox();
            label7 = new Label();
            label9 = new Label();
            panel6 = new Panel();
            pictureBox7 = new PictureBox();
            lastnamebox = new TextBox();
            label6 = new Label();
            linkLabel2 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(222, 241);
            label2.Name = "label2";
            label2.Size = new Size(196, 20);
            label2.TabIndex = 14;
            label2.Text = "Fill in the information below";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(163, 193);
            label1.Name = "label1";
            label1.Size = new Size(334, 32);
            label1.TabIndex = 13;
            label1.Text = "CREATE TEACHER ACCOUNT";
            // 
            // firstnamebox
            // 
            firstnamebox.BackColor = SystemColors.Control;
            firstnamebox.BorderStyle = BorderStyle.None;
            firstnamebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstnamebox.Location = new Point(3, 4);
            firstnamebox.Margin = new Padding(3, 4, 3, 4);
            firstnamebox.Name = "firstnamebox";
            firstnamebox.PlaceholderText = "Enter your last name";
            firstnamebox.Size = new Size(349, 27);
            firstnamebox.TabIndex = 20;
            firstnamebox.TextChanged += emailbox_TextChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(firstnamebox);
            panel1.Location = new Point(62, 299);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 43);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(377, -1);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 49);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(222, 41);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 129);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(62, 275);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(86, 20);
            label3.TabIndex = 16;
            label3.Text = "First Name";
            // 
            // emailbox
            // 
            emailbox.BackColor = SystemColors.Control;
            emailbox.BorderStyle = BorderStyle.None;
            emailbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailbox.Location = new Point(3, 4);
            emailbox.Margin = new Padding(3, 4, 3, 4);
            emailbox.Name = "emailbox";
            emailbox.PlaceholderText = "Enter your email";
            emailbox.Size = new Size(349, 27);
            emailbox.TabIndex = 0;
            emailbox.TextChanged += emailbox_TextChanged_1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(emailbox);
            panel2.Location = new Point(62, 465);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 43);
            panel2.TabIndex = 17;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(377, -7);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(82, 49);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(62, 691);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(179, 51);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 441);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 18;
            label4.Text = "Email";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(passwordbox);
            panel4.Location = new Point(62, 548);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(444, 43);
            panel4.TabIndex = 23;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(377, -7);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(82, 49);
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // passwordbox
            // 
            passwordbox.BackColor = SystemColors.Control;
            passwordbox.BorderStyle = BorderStyle.None;
            passwordbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordbox.Location = new Point(3, 4);
            passwordbox.Margin = new Padding(3, 4, 3, 4);
            passwordbox.Name = "passwordbox";
            passwordbox.PlaceholderText = "Enter your password";
            passwordbox.Size = new Size(349, 27);
            passwordbox.TabIndex = 0;
            passwordbox.TextChanged += passwordbox_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(327, 691);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(179, 51);
            button2.TabIndex = 25;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(62, 608);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 26;
            label8.Text = "Confirm Password";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(confirmbox);
            panel5.Location = new Point(62, 632);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(444, 43);
            panel5.TabIndex = 25;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(377, -7);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(82, 49);
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // confirmbox
            // 
            confirmbox.BackColor = SystemColors.Control;
            confirmbox.BorderStyle = BorderStyle.None;
            confirmbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmbox.Location = new Point(3, 4);
            confirmbox.Margin = new Padding(3, 4, 3, 4);
            confirmbox.Name = "confirmbox";
            confirmbox.PlaceholderText = "Enter your password";
            confirmbox.Size = new Size(349, 27);
            confirmbox.TabIndex = 0;
            confirmbox.TextChanged += confirmbox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(62, 524);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 24;
            label7.Text = "Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(62, 356);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(84, 20);
            label9.TabIndex = 28;
            label9.Text = "Last Name";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(pictureBox7);
            panel6.Controls.Add(lastnamebox);
            panel6.Location = new Point(62, 380);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(444, 43);
            panel6.TabIndex = 27;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(377, -1);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(82, 49);
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // lastnamebox
            // 
            lastnamebox.BackColor = SystemColors.Control;
            lastnamebox.BorderStyle = BorderStyle.None;
            lastnamebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastnamebox.Location = new Point(3, 4);
            lastnamebox.Margin = new Padding(3, 4, 3, 4);
            lastnamebox.Name = "lastnamebox";
            lastnamebox.PlaceholderText = "Enter your last name";
            lastnamebox.Size = new Size(349, 27);
            lastnamebox.TabIndex = 20;
            lastnamebox.TextChanged += lastnamebox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(187, 760);
            label6.Name = "label6";
            label6.Size = new Size(178, 20);
            label6.TabIndex = 21;
            label6.Text = "Already have an account?";
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.DeepSkyBlue;
            linkLabel2.AutoSize = true;
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = SystemColors.HotTrack;
            linkLabel2.Location = new Point(351, 760);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(46, 20);
            linkLabel2.TabIndex = 22;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Login";
            linkLabel2.LinkClicked += linkLabel1_LinkClicked;
            // 
            // SignUpform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 801);
            Controls.Add(panel6);
            Controls.Add(label9);
            Controls.Add(panel5);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(panel4);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(linkLabel2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUpform";
            Text = "School Attendance System - Sign Up";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox firstnamebox;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox emailbox;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button button1;
        private Label label4;
        private Panel panel4;
        private PictureBox pictureBox5;
        private TextBox passwordbox;
        private Button button2;
        private Label label8;
        private Panel panel5;
        private PictureBox pictureBox6;
        private TextBox confirmbox;
        private Label label7;
        private Label label9;
        private Panel panel6;
        private PictureBox pictureBox7;
        private TextBox lastnamebox;
        private Label label6;
        private LinkLabel linkLabel2;
    }
}