using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Attendance_System
{
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();
            CenterToScreen();
            CustomizeAttendanceTable();
            LoadAttendance();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadAttendance()
        {

        }

        private void CustomizeAttendanceTable()
        {
            dgvAttendance.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvAttendance.GridColor = Color.Gray;
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.ReadOnly = false;
            dgvAttendance.RowHeadersVisible = false;

            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvAttendance.MultiSelect = false;

            dgvAttendance.BorderStyle = BorderStyle.None;

            dgvAttendance.EnableHeadersVisualStyles = false;

            dgvAttendance.ColumnHeadersHeight = 40;

            dgvAttendance.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvAttendance.RowTemplate.Height = 45;

            dgvAttendance.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dgvAttendance.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvAttendance.DefaultCellStyle.SelectionBackColor = Color.LightGray;

            dgvAttendance.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvAttendance.AllowUserToResizeRows = false;

            dgvAttendance.Columns["Number"].Width = 50;
            dgvAttendance.Columns["ID"].Width = 70;
            dgvAttendance.Columns["StudentName"].Width = 100;
            dgvAttendance.Columns["TimeIn"].Width = 50;
            dgvAttendance.Columns["TimeOut"].Width = 50;
            dgvAttendance.Columns["Present"].Width = 30;
            dgvAttendance.Columns["Late"].Width = 30;
            dgvAttendance.Columns["Absent"].Width = 30;
        }

        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == dgvAttendance.Columns["Present"].Index)
                {
                    dgvAttendance.Rows[e.RowIndex].Cells["Late"].Value = false;
                    dgvAttendance.Rows[e.RowIndex].Cells["Absent"].Value = false;
                }

            if (e.ColumnIndex == dgvAttendance.Columns["Late"].Index)
                {
                    dgvAttendance.Rows[e.RowIndex].Cells["Present"].Value = false;
                    dgvAttendance.Rows[e.RowIndex].Cells["Absent"].Value = false;
                }

            if (e.ColumnIndex == dgvAttendance.Columns["Absent"].Index)
                {
                    dgvAttendance.Rows[e.RowIndex].Cells["Present"].Value = false;
                    dgvAttendance.Rows[e.RowIndex].Cells["Late"].Value = false;
                }

            if (e.ColumnIndex == dgvAttendance.Columns["Present"].Index)
            {
                if (Convert.ToBoolean(dgvAttendance.Rows[e.RowIndex].Cells["Present"].Value))
                {
                    dgvAttendance.Rows[e.RowIndex].Cells["TimeIn"].Value = DateTime.Now.TimeOfDay;
                }

                else
                {
                    dgvAttendance.Rows[e.RowIndex].Cells["TimeIn"].Value = null;
                }
            }

            if (e.ColumnIndex == dgvAttendance.Columns["Late"].Index)
            {
                if (Convert.ToBoolean(dgvAttendance.Rows[e.RowIndex].Cells["Late"].Value))
                {
                    dgvAttendance.Rows[e.RowIndex].Cells["TimeIn"].Value = DateTime.Now.TimeOfDay;
                }

                else
                {
                    dgvAttendance.Rows[e.RowIndex].Cells["TimeIn"].Value = null;
                }
            }

            if (e.ColumnIndex == dgvAttendance.Columns["Absent"].Index)
            {
                dgvAttendance.Rows[e.RowIndex].Cells["TimeIn"].Value = null;
            }

            //timeOut next work:
        }
    }
}
