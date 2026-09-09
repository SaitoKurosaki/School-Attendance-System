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

            dgvStudents.Columns["colStudentId"].Width = 100;
            dgvStudents.Columns["colFullName"].Width = 200;
            dgvStudents.Columns["colGradeSection"].Width = 180;
            dgvStudents.Columns["colParentEmail"].Width = 250;
            dgvStudents.Columns["colActions"].Width = 120;

            dgvStudents.Columns["colActions"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
