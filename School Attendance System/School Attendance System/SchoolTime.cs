using System;

namespace School_Attendance_System
{
    internal static class SchoolTime
    {
        private static readonly TimeSpan PhilippineOffset = TimeSpan.FromHours(8);

        internal static DateTime Now => DateTime.UtcNow + PhilippineOffset;

        internal static DateTime Today => Now.Date;

        internal static DateTime MonthStart => new DateTime(Today.Year, Today.Month, 1);
    }
}
