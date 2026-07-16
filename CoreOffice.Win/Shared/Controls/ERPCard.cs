using CoreOffice.Win.Shared.Theme;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Automation.Text;

namespace CoreOffice.Win.Shared.Controls;

public class ERPCard : ERPControl
{
    private string _title = "";

    public ERPCard()
    {
        DoubleBuffered = true;

        BackColor = ERPTheme.CardColor;

        Padding = new Padding(15, 45, 15, 15);

        Margin = new Padding(10);

        BorderStyle = BorderStyle.None;
    }

    [Category("ERP")]
    [DefaultValue(false)]
    public string Title
    {
        get => _title;
        set
        {
            _title = value;
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics g = e.Graphics;

        g.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = ClientRectangle;
        rect.Width--;
        rect.Height--;

        using GraphicsPath path = CreateRoundRectangle(rect, ERPStyle.CardRadius);

        using SolidBrush back = new(ERPTheme.CardColor);
        g.FillPath(back, path);

        using Pen border = new(ERPTheme.BorderColor);
        g.DrawPath(border, path);

        if (!string.IsNullOrWhiteSpace(Title))
        {
            using SolidBrush brush = new(ERPTheme.PrimaryColor);

            g.DrawString(
                Title,
                ERPFonts.CardTitle,
                brush,
                15,
                12);
        }
    }

    private static GraphicsPath CreateRoundRectangle(Rectangle rect, int radius)
    {
        GraphicsPath path = new();

        int d = radius * 2;

        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

        path.CloseFigure();

        return path;
    }
}