using System.Drawing;
using System.Windows.Forms;

namespace School_Attendance_System
{
    /// <summary>
    /// Login, Sign Up and Verification swap windows on every link click. Without this each new window
    /// re-centered itself, so the screen jumped back to the middle whenever the teacher had dragged
    /// the current window somewhere else.
    /// </summary>
    internal static class AuthWindowPlacement
    {
        private static Point? lastLocation;

        internal static void Apply(Form form)
        {
            if (lastLocation is not Point location)
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                return;
            }
            form.StartPosition = FormStartPosition.Manual;
            form.Location = location;
        }

        internal static void Remember(Form form)
        {
            if (form.WindowState == FormWindowState.Normal) lastLocation = form.Location;
        }
    }
}
