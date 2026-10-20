using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace School_Attendance_System
{
    /// <summary>
    /// Makes a typed value safe for a <see cref="System.Data.DataView.RowFilter"/> LIKE pattern.
    /// RowFilter treats [ ] % * ? # as pattern syntax, so an unescaped "[" throws an unhandled
    /// ArgumentException out of TextChanged and "%" silently matches everything.
    /// </summary>
    internal static class SearchFilter
    {
        internal static string Literal(string term)
        {
            StringBuilder escaped = new StringBuilder(term.Length);
            foreach (char character in term)
            {
                switch (character)
                {
                    case '\'': escaped.Append("''"); break;
                    case '[': escaped.Append("[[]"); break;
                    case ']': escaped.Append("[]]"); break;
                    case '%': escaped.Append("[%]"); break;
                    case '*': escaped.Append("[*]"); break;
                    case '?': escaped.Append("[?]"); break;
                    case '#': escaped.Append("[#]"); break;
                    default: escaped.Append(character); break;
                }
            }
            return escaped.ToString();
        }

        internal static string ContainsAny(DataTable table, IEnumerable<string> columns, string term)
        {
            string escapedTerm = Literal(term.Trim());
            if (escapedTerm.Length == 0) return string.Empty;

            return string.Join(" OR ", columns
                .Where(table.Columns.Contains)
                .Select(name =>
                {
                    string column = "[" + table.Columns[name]!.ColumnName.Replace("]", "]]", StringComparison.Ordinal) + "]";
                    // DataView LIKE requires text. Convert numeric/date columns (such as Year,
                    // Semester, and attendance counts) before filtering to avoid Byte/String errors.
                    return $"CONVERT({column}, 'System.String') LIKE '%{escapedTerm}%'";
                }));
        }
    }
}
