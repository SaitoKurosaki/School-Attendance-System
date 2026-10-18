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
            AppTheme.Field(coursetext);
            AppTheme.Field(sectiontext);
            AppTheme.Field(searchtext);
            AppTheme.Field(nametext);
            AppTheme.Field(numtext);
            AppTheme.Field(emailtext);
            AppTheme.Field(parenttext);
            AppTheme.Action(addcoursebtn, "PlusOutlined", primary: true);
            AppTheme.Action(addsectionbtn, "PlusOutlined", primary: true);
            AppTheme.Action(renamecoursebtn, "EditOutlined");
            AppTheme.Action(deletecoursebtn, "DeleteOutlined");
            AppTheme.Action(renamesectionbtn, "EditOutlined");
            AppTheme.Action(deletesectionbtn, "DeleteOutlined");
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

            string term = SearchFilter.Literal(searchtext.Text.Trim());
            view.RowFilter = term.Length == 0
                ? string.Empty
                : string.Join(" OR ", new[] { "[Student Name]", "[Student Number]", "Email", "[Parent Email]" }
                    .Select(column => $"{column} LIKE '%{term}%'"));
        }

        private void LoadCatalogs()
        {
            LoadComboBox(coursecombo, "SELECT ID, COURSE_NAME FROM course ORDER BY COURSE_NAME;", "COURSE_NAME");
            LoadComboBox(sectioncombo, "SELECT ID, SECTION_NAME FROM section ORDER BY SECTION_NAME;", "SECTION_NAME");
            coursetext.Text = string.Empty;
            sectiontext.Text = string.Empty;
        }

        private void coursecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            coursetext.Text = coursecombo.Text;
        }

        private void sectioncombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            sectiontext.Text = sectioncombo.Text;
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
            if (!Regex.IsMatch(newName, "^[A-Z][1-4]$"))
            {
                MessageBox.Show("Section must be a letter followed by the year level 1-4 (e.g. B1).", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newName.Equals(sectioncombo.Text, StringComparison.OrdinalIgnoreCase)) return;
            if (!UpdateName("section", "SECTION_NAME", sectionId, newName, "section")) return;
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

        private void deletecoursebtn_Click(object sender, EventArgs e)
        {
            if (coursecombo.SelectedValue is not int courseId)
            {
                MessageBox.Show("Select a course to delete.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DeleteCatalogItem("course", "COURSE_ID", courseId, coursecombo.Text))
            {
                RefreshAll();
            }
        }

        private void deletesectionbtn_Click(object sender, EventArgs e)
        {
            if (sectioncombo.SelectedValue is not int sectionId)
            {
                MessageBox.Show("Select a section to delete.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DeleteCatalogItem("section", "SECTION_ID", sectionId, sectioncombo.Text))
            {
                RefreshAll();
            }
        }

        private void RefreshAll()
        {
            LoadCatalogs();
            LoadAllStudents();
        }

       
        private static bool DeleteCatalogItem(string table, string fkColumn, int id, string name)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(Connection);
                connection.Open();

                List<string> codes = new List<string>();
                using (MySqlCommand find = new MySqlCommand($"SELECT CLASS_CODE FROM class_codes WHERE {fkColumn} = @id;", connection))
                {
                    find.Parameters.AddWithValue("@id", id);
                    using MySqlDataReader reader = find.ExecuteReader();
                    while (reader.Read())
                    {
                        codes.Add(reader.GetString(0));
                    }
                }

                string warning = codes.Count == 0
                    ? $"Delete \"{name}\"?"
                    : $"\"{name}\" is used by {codes.Count} class code(s). Deleting it will also remove those class codes, unenroll their students, and delete their attendance records.\n\nContinue?";
                if (MessageBox.Show(warning, "Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    return false;
                }

                using MySqlTransaction transaction = connection.BeginTransaction();
                const string unenrollQuery = @"
                    UPDATE students
                    SET classcode = JSON_REMOVE(classcode, JSON_UNQUOTE(JSON_SEARCH(classcode, 'one', @code)))
                    WHERE JSON_CONTAINS(classcode, JSON_QUOTE(@code));";
                foreach (string code in codes)
                {
                    using MySqlCommand unenroll = new MySqlCommand(unenrollQuery, connection, transaction);
                    unenroll.Parameters.AddWithValue("@code", code);
                    unenroll.ExecuteNonQuery();
                }

                using (MySqlCommand deleteCodes = new MySqlCommand($"DELETE FROM class_codes WHERE {fkColumn} = @id;", connection, transaction))
                {
                    deleteCodes.Parameters.AddWithValue("@id", id);
                    deleteCodes.ExecuteNonQuery();
                }

                using (MySqlCommand deleteItem = new MySqlCommand($"DELETE FROM {table} WHERE ID = @id;", connection, transaction))
                {
                    deleteItem.Parameters.AddWithValue("@id", id);
                    deleteItem.ExecuteNonQuery();
                }

                transaction.Commit();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to delete: " + ex.Message, "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!Regex.IsMatch(sectionName, "^[A-Z][1-4]$"))
            {
                MessageBox.Show("Section must be a letter followed by the year level 1-4 (e.g. B1).", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AddName("section", "SECTION_NAME", sectionName))
            {
                sectiontext.Text = string.Empty;
                LoadCatalogs();
                MessageBox.Show($"Section \"{sectionName}\" added.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    GROUP_CONCAT(DISTINCT sec.SECTION_NAME ORDER BY sec.SECTION_NAME SEPARATOR ', ') AS Section
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
