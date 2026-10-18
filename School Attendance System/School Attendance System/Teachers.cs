using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace School_Attendance_System
{
    public partial class Teachers : UserControl
    {
        private const string Connection = "server=165.140.202.88;database=school;uid=school;password=Administrator";
        private readonly int currentTeacherId;

       
        private readonly bool canManageAdministrators;

        public Teachers(int currentTeacherId, string role)
        {
           
            if (!Access.IsAdministrative(role)) return;
            canManageAdministrators = Access.IsFullAdministrator(role);
            this.currentTeacherId = currentTeacherId;
            InitializeComponent();
            AppTheme.Page(this);
            AppTheme.Title(label1);
            AppTheme.Caption(label2);
            AppTheme.Action(changebtn, "UserSwitchOutlined", primary: true);
            AppTheme.Action(removebtn, "DeleteOutlined");
            AppTheme.Grid(teacherlistcontent);
            LoadRoles();
            LoadTeachers();
        }

        private void LoadRoles()
        {
           
            const string query = @"
                SELECT ID, ROLE_NAME FROM roles
                WHERE ROLE_NAME <> @hidden
                ORDER BY ROLE_NAME;";
            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                using MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@hidden", Access.Administrator);
                DataTable table = new DataTable();
                adapter.Fill(table);
                rolecombo.DataSource = table;
                rolecombo.DisplayMember = "ROLE_NAME";
                rolecombo.ValueMember = "ID";
                rolecombo.SelectedIndex = -1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to load roles: " + ex.Message, "Teachers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadTeachers()
        {
            const string query = @"
                SELECT t.ID,
                    TRIM(CONCAT(IFNULL(t.first_name, ''), ' ', IFNULL(t.last_name, ''))) AS Teacher,
                    t.email AS Email,
                    r.ROLE_NAME AS Role,
                    DATE_FORMAT(t.register_date, '%M %d, %Y') AS Registered
                FROM teachers t
                INNER JOIN roles r ON r.ID = t.ROLE_ID
                WHERE @hidden = '' OR r.ROLE_NAME <> @hidden
                ORDER BY Teacher;";

            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                using MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@hidden", canManageAdministrators ? string.Empty : Access.Administrator);
                DataTable table = new DataTable();
                adapter.Fill(table);
                teacherlistcontent.DataSource = table;
                teacherlistcontent.Columns["ID"]!.Visible = false;
                teacherlistcontent.Columns["Teacher"]!.FillWeight = 200;
                teacherlistcontent.Columns["Email"]!.FillWeight = 260;
                teacherlistcontent.Columns["Role"]!.FillWeight = 130;
                teacherlistcontent.Columns["Registered"]!.FillWeight = 150;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to load teachers: " + ex.Message, "Teachers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool TryGetSelectedTeacher(out int teacherId, out string name, out string role)
        {
            teacherId = 0;
            name = string.Empty;
            role = string.Empty;

            DataGridViewRow? row = teacherlistcontent.CurrentRow;
            if (row == null)
            {
                MessageBox.Show("Select a teacher in the list first.", "Teachers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            teacherId = Convert.ToInt32(row.Cells["ID"].Value);
            name = row.Cells["Teacher"].Value?.ToString() ?? string.Empty;
            role = row.Cells["Role"].Value?.ToString() ?? string.Empty;
            return true;
        }

        private void changeroledbtn_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedTeacher(out int teacherId, out string name, out string currentRole)) return;
            if (rolecombo.SelectedValue is not int roleId)
            {
                MessageBox.Show("Choose the role to apply.", "Teachers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newRole = rolecombo.Text;
            if (teacherId == currentTeacherId && !IsSameRole(newRole, currentRole))
            {
                MessageBox.Show("You cannot change your own role.", "Teachers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsAdministratorRole(currentRole) && !IsAdministratorRole(newRole) && CountAdministrators() <= 1)
            {
                MessageBox.Show("This is the only Administrator account. Another Administrator must exist in the database before this one can be demoted.", "Teachers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            const string query = "UPDATE teachers SET ROLE_ID = @roleId WHERE ID = @teacherId;";
            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                connection.Open();
                using MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@roleId", roleId);
                command.Parameters.AddWithValue("@teacherId", teacherId);
                command.ExecuteNonQuery();
                LoadTeachers();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to change role: " + ex.Message, "Teachers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeteacherbtn_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedTeacher(out int teacherId, out string name, out string role)) return;

            if (teacherId == currentTeacherId)
            {
                MessageBox.Show("You cannot remove your own account.", "Teachers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsAdministratorRole(role) && CountAdministrators() <= 1)
            {
                MessageBox.Show("This is the only Administrator account. It cannot be removed.", "Teachers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int codeCount = CountClassCodes(teacherId);
            string warning = codeCount == 0
                ? $"Remove teacher \"{name}\"?"
                : $"\"{name}\" has {codeCount} class code(s). Removing this teacher will also delete those class codes, unenroll their students, and delete their attendance records.\n\nContinue?";
            if (MessageBox.Show(warning, "Teachers", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            const string findCodesQuery = "SELECT CLASS_CODE FROM class_codes WHERE TEACHER_ID = @teacherId;";
            const string unenrollQuery = @"
                UPDATE students
                SET classcode = JSON_REMOVE(classcode, JSON_UNQUOTE(JSON_SEARCH(classcode, 'one', @code)))
                WHERE JSON_CONTAINS(classcode, JSON_QUOTE(@code));";

            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                connection.Open();
                List<string> codes = new List<string>();
                using (MySqlCommand find = new MySqlCommand(findCodesQuery, connection))
                {
                    find.Parameters.AddWithValue("@teacherId", teacherId);
                    using MySqlDataReader reader = find.ExecuteReader();
                    while (reader.Read()) codes.Add(reader.GetString(0));
                }

                using MySqlTransaction transaction = connection.BeginTransaction();
                foreach (string code in codes)
                {
                    using MySqlCommand unenroll = new MySqlCommand(unenrollQuery, connection, transaction);
                    unenroll.Parameters.AddWithValue("@code", code);
                    unenroll.ExecuteNonQuery();
                }

                using (MySqlCommand deleteCodes = new MySqlCommand("DELETE FROM class_codes WHERE TEACHER_ID = @teacherId;", connection, transaction))
                {
                    deleteCodes.Parameters.AddWithValue("@teacherId", teacherId);
                    deleteCodes.ExecuteNonQuery();
                }

                using (MySqlCommand deleteTeacher = new MySqlCommand("DELETE FROM teachers WHERE ID = @teacherId;", connection, transaction))
                {
                    deleteTeacher.Parameters.AddWithValue("@teacherId", teacherId);
                    if (deleteTeacher.ExecuteNonQuery() == 0)
                    {
                        transaction.Rollback();
                        MessageBox.Show("That teacher no longer exists.", "Teachers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                transaction.Commit();
                LoadTeachers();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to remove teacher: " + ex.Message, "Teachers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool IsAdministratorRole(string role) => Access.Matches(role, Access.Administrator);

        private static bool IsSameRole(string left, string right) => Access.Matches(left, right);

        private int CountAdministrators() => CountScalar("SELECT COUNT(*) FROM teachers t INNER JOIN roles r ON r.ID = t.ROLE_ID WHERE r.ROLE_NAME = 'Administrator';");

        private int CountClassCodes(int teacherId)
        {
            using MySqlConnection connection = new MySqlConnection(Connection);
            connection.Open();
            using MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM class_codes WHERE TEACHER_ID = @teacherId;", connection);
            command.Parameters.AddWithValue("@teacherId", teacherId);
            return Convert.ToInt32(command.ExecuteScalar());
        }

        private int CountScalar(string query)
        {
            using MySqlConnection connection = new MySqlConnection(Connection);
            connection.Open();
            using MySqlCommand command = new MySqlCommand(query, connection);
            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
}
