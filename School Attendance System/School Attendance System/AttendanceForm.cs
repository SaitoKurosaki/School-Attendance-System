using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

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
            dgvAttendance.EditingControlShowing += dgvAttendance_EditingControlShowing;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadAttendance()
        {
            int rowIndex = dgvAttendance.Rows.Add();

            dgvAttendance.Rows[rowIndex].Cells["Number"].Value = 1;
            dgvAttendance.Rows[rowIndex].Cells["ID"].Value = "2026001";
            dgvAttendance.Rows[rowIndex].Cells["StudentName"].Value = "Louie Cabasal";
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
            dgvAttendance.Columns["TimeIn"].Width = 80;
            dgvAttendance.Columns["TimeOut"].Width = 80;
            dgvAttendance.Columns["Present"].Width = 30;
            dgvAttendance.Columns["Late"].Width = 30;
            dgvAttendance.Columns["Absent"].Width = 30;

            dgvAttendance.Columns["Present"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvAttendance.Columns["Late"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvAttendance.Columns["Absent"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
        }

        private void dgvAttendance_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAttendance.Columns["TimeIn"].Index)
            {
                if (dgvAttendance.Rows[e.RowIndex].Cells["TimeIn"].Value == null)
                {
                    return;
                }

                if (DateTime.TryParseExact(dgvAttendance.Rows[e.RowIndex].Cells["TimeIn"].Value.ToString(), "h:mmtt", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime timeIn))
                {

                }
                else
                {
                    MessageBox.Show("Invalid time format. Please use h:mm AM/PM.");

                    dgvAttendance.Rows[e.RowIndex].Cells["TimeIn"].Value = null;
                }

            }

            if (e.ColumnIndex == dgvAttendance.Columns["TimeOut"].Index)
            {
                if (dgvAttendance.Rows[e.RowIndex].Cells["TimeOut"].Value == null)
                {
                    return;
                }

                if (DateTime.TryParseExact(dgvAttendance.Rows[e.RowIndex].Cells["TimeOut"].Value.ToString(), "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime timeOut))
                {

                }
                else
                {
                    MessageBox.Show("Invalid time format. Please use h:mm AM/PM.");

                    dgvAttendance.Rows[e.RowIndex].Cells["TimeOut"].Value = null;
                }
            }
        }
        private void dgvAttendance_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvAttendance.CurrentCell.ColumnIndex == dgvAttendance.Columns["TimeIn"].Index || dgvAttendance.CurrentCell.ColumnIndex == dgvAttendance.Columns["TimeOut"].Index)
            {
                TextBox textBox = e.Control as TextBox;

                textBox.KeyPress -= Time_KeyPress;
                textBox.KeyPress += Time_KeyPress;
            }
        }

        private void Time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ':' || e.KeyChar == 'A' || e.KeyChar == 'P' || e.KeyChar == 'M' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}