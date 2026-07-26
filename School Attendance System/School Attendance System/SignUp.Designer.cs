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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            label1 = new Label();
            txtUsername = new TextBox();
            txtPass = new TextBox();
            txtConfirm = new TextBox();
            bntSign = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            txtEmail = new TextBox();
            panel4 = new Panel();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(403, 99);
            label1.Name = "label1";
            label1.Size = new Size(605, 48);
            label1.TabIndex = 0;
            label1.Text = "Create your Account now!";
            label1.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(467, 233);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(477, 47);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(467, 409);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Password";
            txtPass.Size = new Size(477, 47);
            txtPass.TabIndex = 2;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // txtConfirm
            // 
            txtConfirm.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirm.Location = new Point(467, 497);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.PlaceholderText = "Confirm Password";
            txtConfirm.Size = new Size(477, 47);
            txtConfirm.TabIndex = 3;
            txtConfirm.TextChanged += txtConfirm_TextChanged;
            // 
            // bntSign
            // 
            bntSign.BackColor = Color.RoyalBlue;
            bntSign.FlatStyle = FlatStyle.Flat;
            bntSign.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntSign.ForeColor = SystemColors.Control;
            bntSign.Location = new Point(467, 598);
            bntSign.Name = "bntSign";
            bntSign.Size = new Size(477, 62);
            bntSign.TabIndex = 4;
            bntSign.Text = "Sign Up";
            bntSign.UseVisualStyleBackColor = false;
            bntSign.Click += bntSign_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(12, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 53);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 23);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 8;
            label3.Text = "AttendEase";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(886, 237);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 38);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(886, 500);
            panel2.Name = "panel2";
            panel2.Size = new Size(50, 38);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(886, 412);
            panel3.Name = "panel3";
            panel3.Size = new Size(50, 38);
            panel3.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(467, 319);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(477, 47);
            txtEmail.TabIndex = 12;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(886, 319);
            panel4.Name = "panel4";
            panel4.Size = new Size(50, 38);
            panel4.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(468, 203);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(468, 296);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 14;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(467, 386);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 15;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(467, 474);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 16;
            label6.Text = "Confirm Password";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1348, 721);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(bntSign);
            Controls.Add(txtPass);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(txtEmail);
            Controls.Add(txtConfirm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPass;
        private TextBox txtConfirm;
        private Button bntSign;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtEmail;
        private Panel panel4;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}