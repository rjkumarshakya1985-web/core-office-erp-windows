using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOffice.Win
{
    public class GradientClass : Panel
    {
        private Color _gradientTop = Color.FromArgb(33, 145, 245);
        private Color _gradientBottom = Color.White;

        [Browsable(true)]
        [Category("Gradient")]
        [Description("Top color of gradient")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color GradientTop
        {
            get { return _gradientTop; }
            set
            {
                _gradientTop = value;
                this.Invalidate(); // repaint
            }
        }

        [Browsable(true)]
        [Category("Gradient")]
        [Description("Bottom color of gradient")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color GradientBottom
        {
            get { return _gradientBottom; }
            set
            {
                _gradientBottom = value;
                this.Invalidate(); // repaint
            }
        }

        public GradientClass()
        {
            this.Resize += GradientClass_Resize;
        }

        private void GradientClass_Resize(object? sender, EventArgs e)
        {
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush linear = new LinearGradientBrush(this.ClientRectangle, this.GradientTop, this.GradientBottom, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(linear, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
