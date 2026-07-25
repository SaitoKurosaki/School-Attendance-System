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
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(413, 54);
            label1.Name = "label1";
            label1.Size = new Size(605, 48);
            label1.TabIndex = 0;
            label1.Text = "Create your Account now!";
            label1.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(467, 223);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(477, 47);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(467, 318);
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
            txtConfirm.Location = new Point(467, 417);
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
            bntSign.Location = new Point(467, 529);
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
            pictureBox2.Location = new Point(-6, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 87);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 23);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 8;
            label3.Text = "AttendEase";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Cursor = Cursors.Cross;
            flowLayoutPanel1.Location = new Point(366, 152);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(677, 511);
            flowLayoutPanel1.TabIndex = 9;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint_1;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1348, 721);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(bntSign);
            Controls.Add(txtConfirm);
            Controls.Add(txtPass);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
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
        private FlowLayoutPanel flowLayoutPanel1;
    }
}