using System;

namespace School_Attendance_System
{
    /// <summary>
    /// Role names come from the database, so every privilege test in the app goes through here rather than
    /// comparing strings at each call site. Matching is case-insensitive because MySQL already compares
    /// role names that way.
    /// </summary>
    internal static class Access
    {
        internal const string Administrator = "Administrator";
        internal const string SubAdministrator = "Sub-Administrator";
        internal const string Teacher = "Teacher";

        /// <summary>Both administrator ranks open the administration screens.</summary>
        internal static bool IsAdministrative(string role) =>
            Matches(role, Administrator) || Matches(role, SubAdministrator);

        /// <summary>Only a full administrator may promote, demote or remove an administrator.</summary>
        internal static bool IsFullAdministrator(string role) => Matches(role, Administrator);

        internal static bool Matches(string role, string name) => string.Equals(role, name, StringComparison.OrdinalIgnoreCase);
    }
}
