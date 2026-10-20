using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace School_Attendance_System
{
    public partial class MainDashboard : Form
    {
        private const string MysqlConnection = "server=165.140.202.88;database=school;uid=school;password=Administrator";

        public int TeacherID { get; private set; }

        public string RoleName { get; }

      
        public bool IsAdministrator => Access.IsAdministrative(RoleName);

        private AntdUI.Menu? currentMenu;
        private AntdUI.MenuItem? currentItem;

        public MainDashboard(int teacherID, string role, string email)
        {
            TeacherID = teacherID;
            RoleName = role;
            InitializeComponent();
            // Every dashboard page uses a fixed 1160 px design surface. Keep enough
            // client width for that surface plus the sidebar so anchored controls
            // (especially the attendance date and Save button) cannot collide.
            MinimumSize = new Size(1420, 840);

            AppTheme.Menu(navMenu);
            AppTheme.Menu(adminMenu);
            AppTheme.Button(logoutBtn, primary: false);
            BuildNav();
            ShowSignedInAs(email);
            Open();
        }

        private void BuildNav()
        {
            AntdUI.MenuItem dashboard = AddItem(navMenu, "Dashboard", "DashboardOutlined", "dashboard");
            AddItem(navMenu, "Students", "TeamOutlined", "students");
            AddItem(navMenu, "Attendance", "ScheduleOutlined", "attendance");
            AddItem(navMenu, "Class Code", "IdcardOutlined", "classcode");
            AddItem(navMenu, "Reports", "BarChartOutlined", "reports");

            AddItem(adminMenu, "Administrator", "SafetyCertificateOutlined", "administrator");
            AddItem(adminMenu, "Teachers", "UserSwitchOutlined", "teachers");
            AddItem(testMenu, "Test", "ExperimentOutlined", "fdatest");
            adminMenu.Visible = IsAdministrator;
            testMenu.Visible = IsAdministrator;
            adminDivider.Visible = IsAdministrator;
            testDivider.Visible = IsAdministrator;

            currentMenu = navMenu;
            currentItem = dashboard;
            dashboard.Select = true;
        }

        private static AntdUI.MenuItem AddItem(AntdUI.Menu menu, string text, string icon, string key)
        {
            AntdUI.MenuItem item = new AntdUI.MenuItem(text, icon) { Name = key, ID = key };
            menu.Items.Add(item);
            return item;
        }

        private void navMenu_ItemClick(object sender, AntdUI.MenuItemEventArgs e)
        {
            if (sender is not AntdUI.Menu menu || e.Item?.Name is not string key) return;
            if (string.Equals(key, currentItem?.Name, StringComparison.Ordinal)) return;

            AntdUI.Menu? previousMenu = currentMenu;
            AntdUI.MenuItem? previousItem = currentItem;

            if (!OpenScreen(key))
            {
               
                e.Item.Select = false;
                if (previousItem != null) previousItem.Select = true;
                menu.Invalidate();
                previousMenu?.Invalidate();
                return;
            }

            currentMenu = menu;
            currentItem = e.Item;

            if (!ReferenceEquals(previousMenu, menu) && previousItem != null)
            {
                previousItem.Select = false;
                previousMenu?.Invalidate();
            }
        }

        private bool OpenScreen(string key)
        {
            if (key == "fdatest" && !IsAdministrator) return false;

            UserControl screen = key switch
            {
                "students" => new Students(TeacherID),
                "attendance" => new Attendance(TeacherID),
                "classcode" => new ClassCode(TeacherID),
                "reports" => new Reports(TeacherID),
                "administrator" => new Administrator(RoleName),
                "teachers" => new Teachers(TeacherID, RoleName),
                "fdatest" => new FdaTest(RoleName),
                _ => new Dashboard(TeacherID),
            };

            return LoadUserControl(screen);
        }

        private bool Open() => OpenScreen("dashboard");

        private bool LoadUserControl(UserControl userControl)
        {
            Control? current = contentPanel.Controls.Count > 0 ? contentPanel.Controls[0] : null;

           
            if (current is Attendance attendance && !attendance.ConfirmDiscardEdits())
            {
                userControl.Dispose();
                return false;
            }

           
            if (current != null)
            {
                contentPanel.Controls.Remove(current);
                current.Dispose();
            }

            userControl.Dock = DockStyle.Fill;

            contentPanel.Controls.Add(userControl);
            return true;
        }

        private void ShowSignedInAs(string email)
        {
            userEmail.Text = email;

            try
            {
                using MySqlConnection connection = new MySqlConnection(MysqlConnection);
                connection.Open();
                using MySqlCommand command = new MySqlCommand(
                    @"SELECT TRIM(CONCAT(IFNULL(t.first_name, ''), ' ', IFNULL(t.last_name, '')))
                      FROM teachers t WHERE t.ID = @teacherID LIMIT 1;", connection);
                command.Parameters.AddWithValue("@teacherID", TeacherID);
                object? value = command.ExecuteScalar();
                string name = Convert.ToString(value)?.Trim() ?? string.Empty;
                if (name.Length > 0)
                {
                    userName.Text = name;
                }
            }
            catch (MySqlException)
            {
             
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            Login.ShowLogin();
            Close();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
