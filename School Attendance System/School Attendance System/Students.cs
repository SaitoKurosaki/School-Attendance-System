using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using MySqlX.XDevAPI.Common;

namespace School_Attendance_System
{
    public partial class Students : Form
    {
        private string oldStudentId;
        string connectionString = "Server=localhost;Database=addstudent;Uid=root;Pwd=123456;";
        public Students()
        {
            InitializeComponent();

            CustomizeStudentTable();
            dgvStudents.CellPainting += dgvStudents_CellPainting;
            dgvStudents.CellMouseClick += dgvStudents_CellMouseClick;
            dgvStudents.CellBeginEdit += dgvStudents_CellBeginEdit;
            dgvStudents.CellEndEdit += dgvStudents_CellEndEdit;
            LoadStudents();
        }
        private void LoadStudents()
        {
            string query = "SELECT * FROM addstudent ORDER BY last_name ASC";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dgvStudents.Rows.Clear();

                        while (reader.Read())
                        {
                            string studentId = reader["student_id"].ToString();
                            string lastName = reader["last_name"].ToString();
                            string firstName = reader["first_name"].ToString();
                            string middleName = reader["middle_name"].ToString();
                            string gradeSection = reader["course_section"].ToString();
                            string parentEmail = reader["parent_email"].ToString();

                            int newRowIndex = dgvStudents.Rows.Add();

                            var row = dgvStudents.Rows[newRowIndex];

                            row.Cells["ID"].Value = studentId;
                            row.Cells["LastName"].Value = lastName;
                            row.Cells["FirstName"].Value = firstName;
                            row.Cells["MiddleName"].Value = middleName;
                            row.Cells["CourseSection"].Value = gradeSection;
                            row.Cells["ParentEmail"].Value = parentEmail;

                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                cell.ReadOnly = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading students: " + ex.Message);
                }
            }
        }
        private void CustomizeStudentTable()
        {
            dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvStudents.GridColor = Color.Gray;
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.ReadOnly = false;
            dgvStudents.RowHeadersVisible = false;

            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvStudents.MultiSelect = false;

            dgvStudents.BorderStyle = BorderStyle.None;

            dgvStudents.EnableHeadersVisualStyles = false;

            dgvStudents.ColumnHeadersHeight = 40;

            dgvStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvStudents.RowTemplate.Height = 45;

            dgvStudents.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dgvStudents.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvStudents.DefaultCellStyle.SelectionBackColor = Color.LightGray;

            dgvStudents.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvStudents.AllowUserToResizeRows = false;

            dgvStudents.Columns["ID"].Width = 100;
            dgvStudents.Columns["LastName"].Width = 200;
            dgvStudents.Columns["FirstName"].Width = 200;
            dgvStudents.Columns["MiddleName"].Width = 200;
            dgvStudents.Columns["CourseSection"].Width = 180;
            dgvStudents.Columns["ParentEmail"].Width = 250;
            dgvStudents.Columns["Actions"].Width = 120;

            dgvStudents.Columns["Actions"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvStudents_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvStudents.Columns["Actions"].Index)
            {
                e.PaintBackground(e.CellBounds, true);

                Image editIcon = Properties.Resources.edit_icon;
                Image deleteIcon = Properties.Resources.delete_icon;

                int iconSize = 20;
                int spacing = 15;

                int totalWidth = (iconSize * 2) + spacing;

                int startX = e.CellBounds.X +
                             (e.CellBounds.Width - totalWidth) / 2;

                int startY = e.CellBounds.Y +
                             (e.CellBounds.Height - iconSize) / 2;

                Rectangle editRect = new Rectangle(
                    startX, startY, iconSize, iconSize);

                Rectangle deleteRect = new Rectangle(
                    startX + iconSize + spacing,
                    startY,
                    iconSize,
                    iconSize);

                e.Graphics.DrawImage(editIcon, editRect);
                e.Graphics.DrawImage(deleteIcon, deleteRect);

                e.Paint(e.CellBounds, DataGridViewPaintParts.Border);

                e.Handled = true;
            }
        }

        private void dgvStudents_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           if (e.RowIndex >= 0 && e.ColumnIndex == dgvStudents.Columns["Actions"].Index)
            {
                Rectangle cellBounds = dgvStudents.GetCellDisplayRectangle(e.ColumnIndex,e.RowIndex,false);
                int iconSize = 20;
                int spacing = 15;

                int totalWidth = (iconSize * 2) + spacing;

                int startX = cellBounds.X +
                             (cellBounds.Width - totalWidth) / 2;

                int startY = cellBounds.Y +
                             (cellBounds.Height - iconSize) / 2;

                Rectangle editRect = new Rectangle(
                    startX, startY, iconSize, iconSize);

                Rectangle deleteRect = new Rectangle(
                    startX + iconSize + spacing,
                    startY,
                    iconSize,
                    iconSize);

                Point mousePosition = new Point(
                    e.Location.X + cellBounds.X,
                    e.Location.Y + cellBounds.Y
);

                if (editRect.Contains(mousePosition))
                {
                    var row = dgvStudents.Rows[e.RowIndex];

                   oldStudentId = row.Cells["ID"].Value.ToString();

                    dgvStudents.ReadOnly = false;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.ReadOnly = true;

                        if (cell.ColumnIndex != dgvStudents.Columns["Actions"].Index)
                        {
                            cell.ReadOnly = false;
                        }
                    }
                    dgvStudents.CurrentCell = row.Cells["ID"];
                    dgvStudents.BeginEdit(true);
                    dgvStudents.Focus();
                }
                else if (deleteRect.Contains(mousePosition))
                {
                    string studentId = dgvStudents.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        string query = "DELETE FROM addstudent WHERE student_id = @StudentID";

                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            try
                            {
                                conn.Open();

                                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@StudentID", studentId);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Student deleted successfully!");

                                    LoadStudents();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error deleting student: " + ex.Message);
                            }
                        }
                    }
                }
            }

        }

        private void dgvStudents_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == dgvStudents.Columns["Actions"].Index)
            {
                e.Cancel = true;
            }
        }
        private void dgvStudents_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvStudents.Rows[e.RowIndex];

            string newStudentId = row.Cells["ID"].Value.ToString();
            string lastName = row.Cells["LastName"].Value.ToString();
            string firstName = row.Cells["FirstName"].Value.ToString();
            string middleName = row.Cells["MiddleName"].Value.ToString();
            string courseSection = row.Cells["CourseSection"].Value.ToString();
            string parentEmail = row.Cells["ParentEmail"].Value.ToString();

            string query = "UPDATE addstudent SET student_id = @NewID, last_name = @LastName, first_name = @FirstName, middle_name = @MiddleName, course_section = @CourseSection, parent_email = @ParentEmail WHERE student_id = @OldID";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd =  new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewID", newStudentId);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@MiddleName", middleName);
                        cmd.Parameters.AddWithValue("@CourseSection", courseSection);
                        cmd.Parameters.AddWithValue("@ParentEmail", parentEmail);
                        cmd.Parameters.AddWithValue("@OldID", oldStudentId);

                       int rowsAffected = cmd.ExecuteNonQuery();

                        oldStudentId = newStudentId;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating student: " + ex.Message);
                }
            }
        }
        private void Students_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void bntAddStudent_Click(object sender, EventArgs e)
        {

        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
