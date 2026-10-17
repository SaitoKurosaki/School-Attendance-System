using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Attendance_System
{
    public partial class attendance : UserControl
    {
        public attendance()
        {
            InitializeComponent();

            colNo.Width = 40;
            colID.Width = 90;
            colStudentName.Width = 120;
            colTimeIn.Width = 80;
            colTimeOut.Width = 80;
            colPresent.Width = 75;
            colLate.Width = 65;
            colAbsent.Width = 75;
            colRemarks.Width = 110;

            colStudentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            colPresent.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            colLate.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            colAbsent.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            colPresent.HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            colLate.HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            colAbsent.HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            recentAttendanceGrid.EditingControlShowing += recentAttendanceGrid_EditingControlShowing;

            recentAttendanceGrid.CellValidating += recentAttendanceGrid_CellValidating;

            recentAttendanceGrid.CurrentCellDirtyStateChanged += recentAttendanceGrid_CurrentCellDirtyStateChanged;

            recentAttendanceGrid.CellValueChanged += recentAttendanceGrid_CellValueChanged;

            recentAttendanceGrid.ReadOnly = false;

            colNo.ReadOnly = true;
            colID.ReadOnly = false;
            colStudentName.ReadOnly = false;
            colTimeIn.ReadOnly = false;
            colTimeOut.ReadOnly = false;
            colRemarks.ReadOnly = false;

            colPresent.ReadOnly = false;
            colLate.ReadOnly = false;
            colAbsent.ReadOnly = false;

            recentAttendanceGrid.Rows.Add( 1,12345, "Test Student","","",false,false,false, "");
        }

        private void recentAttendanceGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (recentAttendanceGrid.CurrentCell == null)
                return;

            string columnName = recentAttendanceGrid.CurrentCell.OwningColumn.Name;

            if (columnName == "colTimeIn" || columnName == "colTimeOut")
            {
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress -= Time_KeyPress;
                    tb.KeyPress += Time_KeyPress;
                }
            }
        }

        private void Time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != ':' &&
                !"AMPamp".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void recentAttendanceGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = recentAttendanceGrid.Columns[e.ColumnIndex].Name;

            if (columnName != "colTimeIn" && columnName != "colTimeOut")
                return;

            string time = e.FormattedValue?.ToString().Trim() ?? "";

            if (time == "")
                return;

            if (!DateTime.TryParseExact(
                time,
                new[] { "h:mm tt", "hh:mm tt", "h:mmtt", "hh:mmtt" },
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out _))
            {
                MessageBox.Show(
                    "Enter a valid time, such as 7:30 AM or 5:00 PM.",
                    "Invalid Time",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                e.Cancel = true;
            }
        }

        private void recentAttendanceGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (recentAttendanceGrid.IsCurrentCellDirty)
            {
                recentAttendanceGrid.CommitEdit(
                    DataGridViewDataErrorContexts.Commit);
            }
        }

        private void recentAttendanceGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string columnName =
                recentAttendanceGrid.Columns[e.ColumnIndex].Name;

            if (columnName != "colPresent" &&
                columnName != "colLate" &&
                columnName != "colAbsent")
                return;

            bool isChecked =
                Convert.ToBoolean(
                    recentAttendanceGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value
                    ?? false);

            if (!isChecked)
                return;

            string[] statusColumns = { "colPresent", "colLate", "colAbsent" };

            foreach (string name in statusColumns)
            {
                if (name != columnName)
                {
                    recentAttendanceGrid.Rows[e.RowIndex].Cells[name].Value = false;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
