using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Attendance_System
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();

            CustomizeStudentTable();

            dgvStudents.CellPainting += dgvStudents_CellPainting;
        }

        private void CustomizeStudentTable()
        {
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;

            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvStudents.MultiSelect = false;

            dgvStudents.BorderStyle = BorderStyle.None;

            dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

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
    }
}
