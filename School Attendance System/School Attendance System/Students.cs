using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace School_Attendance_System
{
    public partial class Students : Form
    {
        string connectionString = "Server=localhost;Database=addstudent;Uid=root;Pwd=123456;";
        public Students()
        {
            InitializeComponent();

            CustomizeStudentTable();
            dgvStudents.CellPainting += dgvStudents_CellPainting;
            dgvStudents.CellMouseClick += dgvStudents_CellMouseClick;
            LoadStudents();
        }
        private void LoadStudents()
        {
            string query = "SELECT * FROM addstudent";

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
                            string fullName = reader["first_name"].ToString() + " " +
                                              reader["last_name"].ToString();
                            string gradeSection = reader["grade_section"].ToString();
                            string parentEmail = reader["parent_email"].ToString();

                            dgvStudents.Rows.Add(
                                studentId,
                                fullName,
                                gradeSection,
                                parentEmail
                            );
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
            dgvStudents.ReadOnly = true;
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
            dgvStudents.Columns["FullName"].Width = 200;
            dgvStudents.Columns["GradeSection"].Width = 180;
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
                    string StudentID = dgvStudents.Rows[e.RowIndex].Cells[0].Value.ToString();

                    string query = "SELECT * FROM addstudent WHERE student_id = @StudentID";

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();

                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@StudentID", StudentID);

                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        string FirstName = reader["first_name"].ToString();
                                        string LastName = reader["last_name"].ToString();
                                        string GradeSection = reader["grade_section"].ToString();
                                        string ParentEmail = reader["parent_email"].ToString();
                                    }
                                }

                            }
                        }
                        catch
                        {

                        }
                    }
                }
                else if (deleteRect.Contains(mousePosition))
                {
                    MessageBox.Show("Student Delete");
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
            AddStudents AddStudents = new AddStudents();
            AddStudents.Show();
           
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
