namespace School_Attendance_System
{
    partial class MainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            sidebar = new AntdUI.Panel();
            logoBox = new PictureBox();
            brandTitle = new AntdUI.Label();
            brandSub = new AntdUI.Label();
            navMenu = new AntdUI.Menu();
            adminDivider = new AntdUI.Divider();
            adminMenu = new AntdUI.Menu();
            userSeparator = new Panel();
            userName = new AntdUI.Label();
            userEmail = new AntdUI.Label();
            logoutBtn = new AntdUI.Button();
            contentPanel = new AntdUI.Panel();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.Back = Color.White;
            sidebar.BackColor = Color.White;
            sidebar.Controls.Add(logoBox);
            sidebar.Controls.Add(brandTitle);
            sidebar.Controls.Add(brandSub);
            sidebar.Controls.Add(navMenu);
            sidebar.Controls.Add(adminDivider);
            sidebar.Controls.Add(adminMenu);
            sidebar.Controls.Add(userSeparator);
            sidebar.Controls.Add(userName);
            sidebar.Controls.Add(userEmail);
            sidebar.Controls.Add(logoutBtn);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Radius = 0;
            sidebar.Size = new Size(224, 760);
            sidebar.TabIndex = 0;
            // 
            // logoBox
            // 
            logoBox.BackColor = Color.Transparent;
            logoBox.BackgroundImage = Properties.Resources.logo_main;
            logoBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoBox.Location = new Point(20, 20);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(44, 44);
            logoBox.TabIndex = 0;
            logoBox.TabStop = false;
            // 
            // brandTitle
            // 
            brandTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            brandTitle.Location = new Point(72, 22);
            brandTitle.Name = "brandTitle";
            brandTitle.Size = new Size(140, 22);
            brandTitle.TabIndex = 1;
            brandTitle.Text = "School Attendance";
            // 
            // brandSub
            // 
            brandSub.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            brandSub.Location = new Point(72, 44);
            brandSub.Name = "brandSub";
            brandSub.Size = new Size(140, 16);
            brandSub.TabIndex = 2;
            brandSub.Text = "SYSTEM";
            // 
            // navMenu
            // 
            navMenu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            navMenu.Gap = 4;
            navMenu.Location = new Point(12, 84);
            navMenu.Name = "navMenu";
            navMenu.Radius = 8;
            navMenu.Size = new Size(200, 250);
            navMenu.TabIndex = 3;
            navMenu.ItemClick += navMenu_ItemClick;
            // 
            // adminDivider
            // 
            adminDivider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            adminDivider.Location = new Point(12, 348);
            adminDivider.Name = "adminDivider";
            adminDivider.Size = new Size(200, 24);
            adminDivider.TabIndex = 4;
            adminDivider.Text = "Administration";
            // 
            // adminMenu
            // 
            adminMenu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            adminMenu.Gap = 4;
            adminMenu.Location = new Point(12, 376);
            adminMenu.Name = "adminMenu";
            adminMenu.Radius = 8;
            adminMenu.Size = new Size(200, 110);
            adminMenu.TabIndex = 5;
            adminMenu.ItemClick += navMenu_ItemClick;
            // 
            // userSeparator
            // 
            userSeparator.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userSeparator.Location = new Point(12, 656);
            userSeparator.Name = "userSeparator";
            userSeparator.Size = new Size(200, 1);
            userSeparator.TabIndex = 6;
            // 
            // userName
            // 
            userName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            userName.Location = new Point(16, 672);
            userName.Name = "userName";
            userName.Size = new Size(192, 18);
            userName.TabIndex = 8;
            userName.Text = "Teacher";
            userName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userEmail
            // 
            userEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userEmail.AutoEllipsis = true;
            userEmail.Font = new Font("Segoe UI", 8.25F);
            userEmail.Location = new Point(6, 692);
            userEmail.Name = "userEmail";
            userEmail.Size = new Size(212, 18);
            userEmail.TabIndex = 9;
            userEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logoutBtn.IconSvg = "LogoutOutlined";
            logoutBtn.Location = new Point(12, 716);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(200, 34);
            logoutBtn.TabIndex = 10;
            logoutBtn.Text = "Logout";
            logoutBtn.Click += logoutBtn_Click;
            // 
            // contentPanel
            // 
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(224, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Radius = 0;
            contentPanel.Size = new Size(1136, 760);
            contentPanel.TabIndex = 1;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 760);
            Controls.Add(contentPanel);
            Controls.Add(sidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "School Attendance System - Dashboard";
            Load += MainDashboard_Load;
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel sidebar;
        private AntdUI.Panel contentPanel;
        private PictureBox logoBox;
        private AntdUI.Label brandTitle;
        private AntdUI.Label brandSub;
        private AntdUI.Menu navMenu;
        private AntdUI.Divider adminDivider;
        private AntdUI.Menu adminMenu;
        private Panel userSeparator;
        private AntdUI.Label userName;
        private AntdUI.Label userEmail;
        private AntdUI.Button logoutBtn;
    }
}
