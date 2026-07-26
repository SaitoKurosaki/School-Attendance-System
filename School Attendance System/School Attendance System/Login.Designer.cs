namespace School_Attendance_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLog = new Button();
            btnSign = new Button();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.RoyalBlue;
            btnLog.Cursor = Cursors.Hand;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLog.ForeColor = SystemColors.Control;
            btnLog.Location = new Point(164, 414);
            btnLog.Margin = new Padding(3, 4, 3, 4);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(441, 63);
            btnLog.TabIndex = 0;
            btnLog.Text = "Login";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLogin_Click;
            // 
            // btnSign
            // 
            btnSign.BackColor = Color.Transparent;
            btnSign.FlatStyle = FlatStyle.Flat;
            btnSign.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSign.ForeColor = Color.Black;
            btnSign.Location = new Point(164, 514);
            btnSign.Margin = new Padding(3, 4, 3, 4);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(441, 63);
            btnSign.TabIndex = 1;
            btnSign.Text = "Sign Up";
            btnSign.UseVisualStyleBackColor = false;
            btnSign.Click += btnSign_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font("Verdana", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(845, 99);
            label1.Name = "label1";
            label1.Size = new Size(335, 57);
            label1.TabIndex = 2;
            label1.Text = "Welcome to";
            label1.Click += label1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.RoyalBlue;
            flowLayoutPanel1.Location = new Point(758, -1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(590, 755);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(779, 226);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(549, 451);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(854, 163);
            label2.Name = "label2";
            label2.Size = new Size(443, 36);
            label2.TabIndex = 5;
            label2.Text = "Student Attendance System";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(-7, -7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 87);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 21);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 9;
            label3.Text = "AttendEase";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel2.BackgroundImage");
            flowLayoutPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel2.Location = new Point(340, 183);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(89, 80);
            flowLayoutPanel2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(142, 286);
            label4.Name = "label4";
            label4.Size = new Size(490, 45);
            label4.TabIndex = 11;
            label4.Text = "Welcome to AttenEase";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(241, 331);
            label6.Name = "label6";
            label6.Size = new Size(279, 23);
            label6.TabIndex = 13;
            label6.Text = "Please login or sign up to Continue";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1348, 721);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSign);
            Controls.Add(btnLog);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLog;
        private Button btnSign;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label4;
        private Label label6;
    }
}
