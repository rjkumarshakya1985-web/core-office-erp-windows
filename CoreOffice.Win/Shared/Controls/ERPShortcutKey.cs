using CoreOffice.Win.Shared.Theme;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace CoreOffice.Win.Shared.Controls
{
    public class ERPShortcutKey : Control
    {
        private string _keyText = "F1";

        public ERPShortcutKey()
        {
            DoubleBuffered = true;
            Size = new Size(42, 22);
            Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            ForeColor = ERPColors.Primary;
            BackColor = Color.LightGray;
        }

        [Category("ERP")]
        [DefaultValue(false)]
        public string KeyText
        {
            get => _keyText;
            set
            {
                _keyText = value;
                Width = Math.Max(32, TextRenderer.MeasureText(value, Font).Width + 16);
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = ClientRectangle;
            rect.Width--;
            rect.Height--;

            using GraphicsPath path = RoundedRect(rect, 5);

            using SolidBrush brush = new(Color.White);
            e.Graphics.FillPath(brush, path);

            using Pen pen = new(Color.FromArgb(210, 210, 210));
            e.Graphics.DrawPath(pen, path);

            TextRenderer.DrawText(
                e.Graphics,
                KeyText,
                Font,
                rect,
                ERPColors.Primary,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter);
        }

        private GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            GraphicsPath path = new();

            int d = radius * 2;

            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}