using System.Text;

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
    }
}
