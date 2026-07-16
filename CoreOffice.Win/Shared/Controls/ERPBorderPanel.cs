using CoreOffice.Win.Shared.Theme;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace CoreOffice.Win.Shared.Controls
{
    public class ERPBorderPanel : Panel
    {
        private bool _focused;
        private bool _hasError;
        private int _borderRadius = 6;

        public ERPBorderPanel()
        {
            DoubleBuffered = true;

            BackColor = Color.White;

            Padding = new Padding(10, 6, 10, 6);

            Resize += (_, _) => Invalidate();
        }

        [Category("ERP")]
        [DefaultValue(false)]
        public bool IsFocused
        {
            get => _focused;
            set
            {
                _focused = value;
                Invalidate();
            }
        }

        [Category("ERP")]
        [DefaultValue(false)]
        public bool HasError
        {
            get => _hasError;
            set
            {
                _hasError = value;
                Invalidate();
            }
        }

        [Category("ERP")]
        [DefaultValue(6)]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = ClientRectangle;
            rect.Width--;
            rect.Height--;

            Color borderColor = ERPColors.Border;

            if (HasError)
                borderColor = ERPColors.Danger;
            else if (IsFocused)
                borderColor = ERPColors.Primary;

            using GraphicsPath path = CreateRoundRectangle(rect, BorderRadius);

            using SolidBrush brush = new(BackColor);
            e.Graphics.FillPath(brush, path);

            using Pen pen = new(borderColor, IsFocused ? 2 : 1);
            e.Graphics.DrawPath(pen, path);
        }

        private static GraphicsPath CreateRoundRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new();

            int diameter = radius * 2;

            path.AddArc(rect.Left, rect.Top, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Top, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();

            return path;
        }
    }
}