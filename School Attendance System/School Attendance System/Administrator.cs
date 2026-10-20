using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace School_Attendance_System
{
    public partial class Administrator : UserControl
    {
        private const string Connection = "server=165.140.202.88;database=school;uid=school;password=Administrator";

        public Administrator(string role)
        {
           
            if (!Access.IsAdministrative(role)) return;
            InitializeComponent();
            AppTheme.Page(this);
            AppTheme.Title(label1);
            AppTheme.FieldLabel(label2);
            AppTheme.FieldLabel(label3);
            AppTheme.CardTitle(label4);
            AppTheme.FieldLabel(label5);
            AppTheme.FieldLabel(label6);
            AppTheme.FieldLabel(label7);
            AppTheme.FieldLabel(label8);
            AppTheme.FieldLabel(label9);
            AppTheme.FieldLabel(label10);
            AppTheme.FieldLabel(sectionyearlabel);
            AppTheme.FieldLabel(sectionsemesterlabel);
            AppTheme.FieldLabel(sectionnamelabel);
            AppTheme.FieldLabel(newsemesterlabel);
            AppTheme.FieldLabel(newsectionlabel);
            AppTheme.Field(coursetext);
            AppTheme.Field(sectiontext);
            AppTheme.Input(searchtext, string.Empty, "SearchOutlined");
            AppTheme.Field(nametext);
            AppTheme.Field(numtext);
            AppTheme.Field(emailtext);
            AppTheme.Field(parenttext);
            AppTheme.Action(addcoursebtn, "PlusOutlined", primary: true);
            AppTheme.Action(addsectionbtn, "PlusOutlined", primary: true);
            AppTheme.Action(renamecoursebtn, "EditOutlined");
            AppTheme.Action(archivecoursebtn, "FolderOutlined");
            AppTheme.Action(renamesectionbtn, "EditOutlined");
            AppTheme.Action(archivesectionbtn, "FolderOutlined");
            AppTheme.Action(restorecoursebtn, "RollbackOutlined");
            AppTheme.Action(restoresectionbtn, "RollbackOutlined");
            AppTheme.Action(updatestudentbtn, "SaveOutlined", primary: true);
            AppTheme.Grid(studentlistcontent);
            studentlistcontent.SelectionChanged += studentlistcontent_SelectionChanged;
            LoadCatalogs();
            LoadAllStudents();
        }

        private void studentlistcontent_SelectionChanged(object? sender, EventArgs e)
        {
            DataRowView? student = studentlistcontent.CurrentRow?.DataBoundItem as DataRowView;
            nametext.Text = Field(student, "Student Name");
            numtext.Text = Field(student, "Student Number");
            emailtext.Text = Field(student, "Email");
            parenttext.Text = Field(student, "Parent Email");
        }

        private static string Field(DataRowView? student, string column) => student?[column]?.ToString() ?? string.Empty;

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
            ApplyStudentFilter();
        }

       
        private void ApplyStudentFilter()
        {
            if (studentlistcontent.DataSource is not DataView view) return;

            view.RowFilter = SearchFilter.ContainsAny(
                view.Table,
                new[] { "Student Name", "Student Number", "Email", "Parent Email" },
                searchtext.Text);
        }

        private void LoadCatalogs()
        {
            LoadComboBox(coursecombo, "SELECT ID, COURSE_NAME FROM course WHERE IS_ARCHIVED = 0 ORDER BY COURSE_NAME;", "COURSE_NAME");
            LoadComboBox(archivedcoursecombo, "SELECT ID, COURSE_NAME FROM course WHERE IS_ARCHIVED = 1 ORDER BY COURSE_NAME;", "COURSE_NAME");
            LoadComboBox(yearcombo, "SELECT DISTINCT CAST(YEAR_LEVEL AS SIGNED) AS ID, CONCAT('Year ', YEAR_LEVEL) AS LABEL FROM section WHERE IS_ARCHIVED = 0 AND SECTION_NAME NOT LIKE 'ARCHIVED-%' ORDER BY ID;", "LABEL");
            LoadComboBox(semestercombo, "SELECT CAST(1 AS SIGNED) AS ID, 'Semester 1' AS LABEL UNION ALL SELECT CAST(2 AS SIGNED), 'Semester 2';", "LABEL");
            LoadComboBox(sectionyearcombo, "SELECT DISTINCT CAST(YEAR_LEVEL AS SIGNED) AS ID, CONCAT('Year ', YEAR_LEVEL) AS LABEL FROM section WHERE IS_ARCHIVED = 0 AND SECTION_NAME NOT LIKE 'ARCHIVED-%' ORDER BY ID;", "LABEL");
            LoadComboBox(sectionsemestercombo, "SELECT CAST(1 AS SIGNED) AS ID, 'Semester 1' AS LABEL UNION ALL SELECT CAST(2 AS SIGNED), 'Semester 2';", "LABEL");
            sectioncombo.DataSource = null;
            sectiontext.Text = string.Empty;
            LoadComboBox(archivedsectioncombo, "SELECT ID, CONCAT('Year ', YEAR_LEVEL, ' • Semester ', SEMESTER, ' • Section ', SECTION_NAME) AS SECTION_LABEL FROM section WHERE IS_ARCHIVED = 1 AND SECTION_NAME NOT LIKE 'ARCHIVED-%' ORDER BY YEAR_LEVEL, SEMESTER, SECTION_NAME;", "SECTION_LABEL");
            coursetext.Text = string.Empty;
            sectiontext.Text = string.Empty;
        }

        private void coursecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            coursetext.Text = coursecombo.Text;
        }

        private void sectioncombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sectioncombo.SelectedItem is DataRowView row) sectiontext.Text = row["SECTION_NAME"]?.ToString() ?? string.Empty;
        }

        private void sectionfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!AppTheme.TryGetIntValue(sectionyearcombo.SelectedValue, out int year) ||
                !AppTheme.TryGetIntValue(sectionsemestercombo.SelectedValue, out int semester))
            {
                sectioncombo.DataSource = null;
                sectiontext.Text = string.Empty;
                return;
            }

            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                using MySqlCommand command = new MySqlCommand(
                    "SELECT ID, SECTION_NAME FROM section WHERE IS_ARCHIVED = 0 AND YEAR_LEVEL = @year AND SEMESTER = @semester AND SECTION_NAME NOT LIKE 'ARCHIVED-%' ORDER BY SECTION_NAME;",
                    connection);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@semester", semester);
                using MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                sectioncombo.DataSource = table;
                sectioncombo.DisplayMember = "SECTION_NAME";
                sectioncombo.ValueMember = "ID";
                sectioncombo.SelectedIndex = -1;
                sectiontext.Text = string.Empty;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to load sections: " + ex.Message, "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static void LoadComboBox(ComboBox comboBox, string query, string displayMember)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                using MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                comboBox.DataSource = table;
                comboBox.DisplayMember = displayMember;
                comboBox.ValueMember = "ID";
                comboBox.SelectedIndex = -1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to load list: " + ex.Message, "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void renamecoursebtn_Click(object sender, EventArgs e)
        {
            if (coursecombo.SelectedValue is not int courseId)
            {
                MessageBox.Show("Select the course you want to rename.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newName = coursetext.Text.Trim();
            if (newName.Length == 0)
            {
                MessageBox.Show("Type the new course name in the box above the dropdown.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newName.Equals(coursecombo.Text, StringComparison.OrdinalIgnoreCase)) return;
            if (!UpdateName("course", "COURSE_NAME", courseId, newName, "course")) return;
            RefreshAll();
        }

        private void renamesectionbtn_Click(object sender, EventArgs e)
        {
            if (sectioncombo.SelectedValue is not int sectionId)
            {
                MessageBox.Show("Select the section you want to rename.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newName = sectiontext.Text.Trim().ToUpperInvariant();
            if (!Regex.IsMatch(newName, "^[A-Z]$"))
            {
                MessageBox.Show("Section must be one letter (for example A or B).", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedName = sectioncombo.SelectedItem is DataRowView selected ? selected["SECTION_NAME"]?.ToString() ?? string.Empty : string.Empty;
            if (newName.Equals(selectedName, StringComparison.OrdinalIgnoreCase)) return;
            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                connection.Open();
                using MySqlCommand update = new MySqlCommand("UPDATE section SET SECTION_NAME = @name WHERE ID = @id;", connection);
                update.Parameters.AddWithValue("@name", newName);
                update.Parameters.AddWithValue("@id", sectionId);
                update.ExecuteNonQuery();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("That section already exists for the same year and semester.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to rename section: " + ex.Message, "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RefreshAll();
        }

       
        private static bool UpdateName(string table, string column, int id, string name, string kind)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                connection.Open();

                using (MySqlCommand check = new MySqlCommand($"SELECT COUNT(*) FROM {table} WHERE LOWER({column}) = LOWER(@name) AND ID <> @id;", connection))
                {
                    check.Parameters.AddWithValue("@name", name);
                    check.Parameters.AddWithValue("@id", id);
                    if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show($"\"{name}\" already exists.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                using MySqlCommand update = new MySqlCommand($"UPDATE {table} SET {column} = @name WHERE ID = @id;", connection);
                update.Parameters.AddWithValue("@name", name);
                update.Parameters.AddWithValue("@id", id);
                update.ExecuteNonQuery();
                MessageBox.Show($"{char.ToUpperInvariant(kind[0]) + kind.Substring(1)} renamed to \"{name}\".", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to rename: " + ex.Message, "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void archivecoursebtn_Click(object sender, EventArgs e)
        {
            if (coursecombo.SelectedValue is not int courseId)
            {
                MessageBox.Show("Select a course to archive.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SetCatalogArchived("course", courseId, true, coursecombo.Text))
            {
                RefreshAll();
            }
        }

        private void archivesectionbtn_Click(object sender, EventArgs e)
        {
            if (sectioncombo.SelectedValue is not int sectionId)
            {
                MessageBox.Show("Select a section to archive.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SetCatalogArchived("section", sectionId, true, sectioncombo.Text))
            {
                RefreshAll();
            }
        }

        private void restorecoursebtn_Click(object sender, EventArgs e)
        {
            if (archivedcoursecombo.SelectedValue is not int courseId)
            {
                MessageBox.Show("Select an archived course to restore.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (SetCatalogArchived("course", courseId, false, archivedcoursecombo.Text)) RefreshAll();
        }

        private void restoresectionbtn_Click(object sender, EventArgs e)
        {
            if (archivedsectioncombo.SelectedValue is not int sectionId)
            {
                MessageBox.Show("Select an archived section to restore.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (SetCatalogArchived("section", sectionId, false, archivedsectioncombo.Text)) RefreshAll();
        }

        private void RefreshAll()
        {
            LoadCatalogs();
            LoadAllStudents();
        }

       
        private static bool SetCatalogArchived(string table, int id, bool archived, string name)
        {
            if (table is not ("course" or "section")) throw new ArgumentOutOfRangeException(nameof(table));
            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                connection.Open();
                string action = archived ? "archive" : "restore";
                string prompt = archived
                    ? $"Archive \"{name}\"? It will leave active selectors, but its class codes, students, and attendance history will be kept."
                    : $"Restore \"{name}\" ";
                if (MessageBox.Show(prompt,
                    "Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return false;
                }
                using (MySqlCommand update = new MySqlCommand($"UPDATE {table} SET IS_ARCHIVED = @archived WHERE ID = @id;", connection))
                {
                    update.Parameters.AddWithValue("@archived", archived ? 1 : 0);
                    update.Parameters.AddWithValue("@id", id);
                    if (update.ExecuteNonQuery() == 0) return false;
                }
                MessageBox.Show($"{char.ToUpperInvariant(action[0]) + action.Substring(1)}d \"{name}\" successfully.",
                    "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to update archive status: " + ex.Message, "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void addcoursebtn_Click(object sender, EventArgs e)
        {
            string courseName = coursetext.Text.Trim();
            if (courseName.Length == 0)
            {
                MessageBox.Show("Enter a course name.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AddName("course", "COURSE_NAME", courseName))
            {
                coursetext.Text = string.Empty;
                LoadCatalogs();
                MessageBox.Show($"Course \"{courseName}\" added.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addsectionbtn_Click(object sender, EventArgs e)
        {
            string sectionName = sectiontext.Text.Trim().ToUpperInvariant();
            if (!AppTheme.TryGetIntValue(yearcombo.SelectedValue, out int year) ||
                !AppTheme.TryGetIntValue(semestercombo.SelectedValue, out int semester) ||
                !Regex.IsMatch(sectionName, "^[A-Z]$"))
            {
                MessageBox.Show("Choose a year and semester, then enter one section letter (for example A).", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                connection.Open();
                using MySqlCommand insert = new MySqlCommand("INSERT INTO section (YEAR_LEVEL, SEMESTER, SECTION_NAME) VALUES (@year, @semester, @name);", connection);
                insert.Parameters.AddWithValue("@year", year);
                insert.Parameters.AddWithValue("@semester", semester);
                insert.Parameters.AddWithValue("@name", sectionName);
                insert.ExecuteNonQuery();
                sectiontext.Text = string.Empty;
                LoadCatalogs();
                MessageBox.Show($"Year {year}, Semester {semester}, Section {sectionName} added.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("That section already exists for the selected year and semester.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to add section: " + ex.Message, "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private static bool AddName(string table, string column, string name)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                connection.Open();

                using (MySqlCommand check = new MySqlCommand($"SELECT COUNT(*) FROM {table} WHERE LOWER({column}) = LOWER(@name);", connection))
                {
                    check.Parameters.AddWithValue("@name", name);
                    if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show($"\"{name}\" already exists.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                using MySqlCommand insert = new MySqlCommand($"INSERT INTO {table} ({column}) VALUES (@name);", connection);
                insert.Parameters.AddWithValue("@name", name);
                insert.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to save: " + ex.Message, "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void LoadAllStudents(int? selectStudentId = null)
        {
            const string query = @"
                SELECT
                    s.id AS ID,
                    s.full_name AS `Student Name`,
                    s.student_number AS `Student Number`,
                    s.email AS Email,
                    s.parent_email AS `Parent Email`,
                    GROUP_CONCAT(DISTINCT c.COURSE_NAME ORDER BY c.COURSE_NAME SEPARATOR ', ') AS Course,
                    GROUP_CONCAT(DISTINCT sec.YEAR_LEVEL ORDER BY sec.YEAR_LEVEL SEPARATOR ', ') AS Year,
                    GROUP_CONCAT(DISTINCT sec.SEMESTER ORDER BY sec.SEMESTER SEPARATOR ', ') AS Semester,
                    GROUP_CONCAT(DISTINCT sec.SECTION_NAME ORDER BY sec.YEAR_LEVEL, sec.SEMESTER, sec.SECTION_NAME SEPARATOR ', ') AS Section
                FROM students s
                LEFT JOIN class_codes cc ON JSON_CONTAINS(s.classcode, JSON_QUOTE(cc.CLASS_CODE))
                LEFT JOIN course c ON c.ID = cc.COURSE_ID
                LEFT JOIN section sec ON sec.ID = cc.SECTION_ID
                GROUP BY s.id, s.full_name, s.student_number, s.email, s.parent_email
                ORDER BY s.full_name;";

            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                using MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                studentlistcontent.DataSource = new DataView(table);
                studentlistcontent.Columns["Course"]!.FillWeight = 180;
                studentlistcontent.Columns["Section"]!.FillWeight = 80;
                ApplyStudentFilter();
               
                studentlistcontent.Columns["ID"]!.Visible = false;
                if (selectStudentId is int studentId) SelectStudent(studentId);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to load students: " + ex.Message, "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
        private void SelectStudent(int studentId)
        {
            DataGridViewColumn? firstVisible = studentlistcontent.Columns.Cast<DataGridViewColumn>()
                .FirstOrDefault(column => column.Visible);
            if (firstVisible == null) return;
            foreach (DataGridViewRow row in studentlistcontent.Rows)
            {
                if (row.DataBoundItem is not DataRowView view || Convert.ToInt32(view["ID"]) != studentId) continue;
                studentlistcontent.CurrentCell = row.Cells[firstVisible.Index];
                return;
            }
        }

        private void updatestudentbtn_Click(object? sender, EventArgs e)
        {
            if (studentlistcontent.CurrentRow?.DataBoundItem is not DataRowView student)
            {
                MessageBox.Show("Select a student in the list first.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = nametext.Text.Trim();
            string studentNumber = numtext.Text.Trim();
            string email = emailtext.Text.Trim();
            string parentEmail = parenttext.Text.Trim();
            if (name.Length == 0 || studentNumber.Length == 0 || email.Length == 0)
            {
                MessageBox.Show("Name, student number, and email cannot be empty.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            const string duplicateQuery = @"
                SELECT COUNT(*) FROM students
                WHERE (email = @Email OR student_number = @StudentNumber) AND id <> @ID;";
            const string updateQuery = @"
                UPDATE students
                SET full_name = @Name, student_number = @StudentNumber, email = @Email, parent_email = @ParentEmail
                WHERE id = @ID;";

            int id = Convert.ToInt32(student["ID"]);
            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                connection.Open();
                using (MySqlCommand duplicate = new MySqlCommand(duplicateQuery, connection))
                {
                    duplicate.Parameters.AddWithValue("@Email", email);
                    duplicate.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    duplicate.Parameters.AddWithValue("@ID", id);
                    if (Convert.ToInt32(duplicate.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Another student already uses that email or student number.", "Administrator",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                using MySqlCommand update = new MySqlCommand(updateQuery, connection);
                update.Parameters.AddWithValue("@Name", name);
                update.Parameters.AddWithValue("@StudentNumber", studentNumber);
                update.Parameters.AddWithValue("@Email", email);
                update.Parameters.AddWithValue("@ParentEmail", parentEmail.Length == 0 ? DBNull.Value : parentEmail);
                update.Parameters.AddWithValue("@ID", id);
                update.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to update the student: " + ex.Message, "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            LoadAllStudents(id);
            MessageBox.Show($"\"{name}\" updated.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
