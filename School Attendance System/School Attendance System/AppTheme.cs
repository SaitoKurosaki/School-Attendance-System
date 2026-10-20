using System.Drawing;
using System;
using System.Windows.Forms;

namespace School_Attendance_System
{
    /// <summary>
    /// The login and sign up screens already fix the brand: SystemColors.HotTrack titles, blue AntdUI
    /// inputs and buttons. Every screen reads these tokens instead of re-typing colours so the shell and
    /// the auth windows stay one identity.
    /// </summary>
    internal static class AppTheme
    {
        internal static readonly Color Primary = Color.FromArgb(22, 119, 255);
        internal static readonly Color PrimaryHover = Color.FromArgb(64, 150, 255);
        internal static readonly Color Navy = Color.FromArgb(0, 102, 204);
        internal static readonly Color Ink = Color.FromArgb(31, 35, 41);
        internal static readonly Color Muted = Color.FromArgb(107, 114, 128);
        internal static readonly Color Line = Color.FromArgb(230, 233, 240);
        internal static readonly Color Canvas = Color.FromArgb(245, 247, 250);
        internal static readonly Color Surface = Color.White;
        internal static readonly Color Tint = Color.FromArgb(230, 244, 255);
        internal static readonly Color TintStrong = Color.FromArgb(207, 230, 253);

        internal static readonly Font PageTitleFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        internal static readonly Font CardTitleFont = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        internal static readonly Font BodyFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        internal static readonly Font CaptionFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        internal static readonly Font FieldLabelFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);

        internal static bool TryGetIntValue(object? value, out int result)
        {
            try
            {
                if (value is null || value == DBNull.Value)
                {
                    result = 0;
                    return false;
                }

                result = Convert.ToInt32(value);
                return true;
            }
            catch (Exception ex) when (ex is FormatException or InvalidCastException or OverflowException)
            {
                result = 0;
                return false;
            }
        }

        /// <summary>Every screen sits on the same pale canvas the login card is drawn on.</summary>
        internal static void Page(Control page)
        {
            page.BackColor = Canvas;
        }

        internal static void Input(AntdUI.Input input, string placeholder, string icon)
        {
            input.Radius = 6;
            input.Font = BodyFont;
            input.ForeColor = Ink;
            input.PlaceholderText = placeholder;
            input.PrefixSvg = icon;
            input.PrefixFore = Muted;
            input.IconRatio = 1.2F;
            input.BorderWidth = 1F;
        }

        /// <summary>Action buttons keep the login shape: 6px radius, blue for the primary verb.</summary>
        internal static void Action(AntdUI.Button button, string icon, bool primary = false)
        {
            button.Radius = 6;
            button.Font = BodyFont;
            button.IconSvg = icon;
            // IconGap is a fraction of the button height, not pixels: a literal 6 shoves the label off one side.
            button.IconGap = 0.25F;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.Type = primary ? AntdUI.TTypeMini.Primary : AntdUI.TTypeMini.Default;
        }

        /// <summary>White rounded card with a hairline border, the container every screen builds on.</summary>
        internal static void Card(AntdUI.Panel panel, bool elevated = false)
        {
            panel.BackColor = Surface;
            panel.Back = Surface;
            panel.Radius = 10;
            panel.BorderWidth = 1F;
            panel.BorderColor = Line;
            if (elevated)
            {
                panel.Shadow = 6;
                panel.ShadowColor = Color.FromArgb(22, 119, 255);
                panel.ShadowOpacity = 0.10F;
            }
        }

        /// <summary>
        /// Stat tiles stay inside the login palette: a pale blue tile, navy figure, blue caption.
        /// Status colours are deliberately not used here.
        /// </summary>
        internal static void Tile(AntdUI.Panel panel)
        {
            panel.BackColor = Tint;
            panel.Back = Tint;
            panel.Radius = 10;
            panel.BorderWidth = 1F;
            panel.BorderColor = TintStrong;
        }

        internal static void Title(AntdUI.Label label)
        {
            label.Font = PageTitleFont;
            label.ForeColor = Navy;
        }

        internal static void CardTitle(AntdUI.Label label)
        {
            label.Font = CardTitleFont;
            label.ForeColor = Ink;
        }

        internal static void FieldLabel(AntdUI.Label label)
        {
            label.Font = FieldLabelFont;
            label.ForeColor = Ink;
        }

        internal static void Field(ReaLTaiizor.Controls.SmallTextBox box)
        {
            box.BorderColor = Line;
            box.CustomBGColor = Surface;
            box.ForeColor = Ink;
        }

        internal static void Caption(AntdUI.Label label)
        {
            label.ForeColor = Muted;
            label.Font = BodyFont;
        }

        internal static void Menu(AntdUI.Menu menu)
        {
            menu.BackColor = Surface;
            menu.ForeColor = Ink;
            menu.BackHover = Tint;
            menu.BackActive = Tint;
            menu.ForeActive = Navy;
            menu.Radius = 8;
            menu.Font = BodyFont;
            // Gap is the breathing room above and below every item, in pixels.
            menu.Gap = 14;
            menu.IconGap = 10;
            menu.IconRatio = 1.35F;
        }

        internal static void Button(AntdUI.Button button, bool primary = true)
        {
            button.Radius = 6;
            button.Font = BodyFont;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.TextCenterHasIcon = false;
            button.Type = primary ? AntdUI.TTypeMini.Primary : AntdUI.TTypeMini.Default;
        }

        /// <summary>Grids get the blue header band and ink text instead of the old cyan Taiizor theme.</summary>
        internal static void Grid(DataGridView grid)
        {
            grid.BackgroundColor = Surface;
            grid.GridColor = Line;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.RowHeadersVisible = false;
            grid.EnableHeadersVisualStyles = false;
            grid.Font = BodyFont;
            grid.AllowUserToResizeRows = false;

            DataGridViewCellStyle header = new DataGridViewCellStyle(grid.ColumnHeadersDefaultCellStyle);
            header.BackColor = Primary;
            header.ForeColor = Surface;
            header.SelectionBackColor = Primary;
            header.SelectionForeColor = Surface;
            header.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            header.Alignment = DataGridViewContentAlignment.MiddleLeft;
            header.Padding = new Padding(10, 4, 8, 4);
            grid.ColumnHeadersDefaultCellStyle = header;
            grid.ColumnHeadersHeight = 46;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            DataGridViewCellStyle body = new DataGridViewCellStyle(grid.DefaultCellStyle);
            body.BackColor = Surface;
            body.ForeColor = Ink;
            body.SelectionBackColor = Tint;
            body.SelectionForeColor = Navy;
            body.Padding = new Padding(10, 4, 8, 4);
            grid.DefaultCellStyle = body;

            // Deliberately not cloned from body: a clone marks every property as explicitly set, and the
            // striped-row style outranks the column style, so the copied NotSet alignment would push the
            // centred counts back to the left on every second row.
            grid.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle { BackColor = Canvas };
            grid.RowTemplate.Height = 32;
            grid.DataBindingComplete += (_, _) => TidyColumns(grid);
            TidyColumns(grid);
        }

        /// <summary>
        /// Data-bound grids build their columns after the screen loads, so this runs on bind too. The grids
        /// are read-only views or fixed rosters, so the header sort arrow is only noise.
        /// </summary>
        private static void TidyColumns(DataGridView grid)
        {
            foreach (DataGridViewColumn column in grid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                if (column is not DataGridViewCheckBoxColumn && !IsNumeric(column)) continue;
                // Counts and ticks read as floating left of their words unless they share the header's centre.
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private static bool IsNumeric(DataGridViewColumn column)
        {
            switch (Type.GetTypeCode(column.ValueType))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Decimal:
                    return true;
                default:
                    return false;
            }
        }
    }
}
