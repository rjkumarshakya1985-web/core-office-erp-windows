using CoreOffice.Win.Shared.Theme;
using System.ComponentModel;

namespace CoreOffice.Win.Shared.Controls;

public class ERPHeader : Panel
{
    private string _title = "Title";
    private string _subTitle = "";

    public ERPHeader()
    {
        Height = 70;
        Dock = DockStyle.Top;

        DoubleBuffered = true;

        BackColor = ERPColors.Primary;
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

    [Category("ERP")]
    [DefaultValue(false)]
    public string SubTitle
    {
        get => _subTitle;
        set
        {
            _subTitle = value;
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics g = e.Graphics;

        using var titleBrush = new SolidBrush(Color.White);

        using var subBrush = new SolidBrush(Color.FromArgb(220, 220, 220));

        g.DrawString(
            Title,
            ERPFonts.Header,
            titleBrush,
            15,
            10);

        g.DrawString(
            SubTitle,
            ERPFonts.SubHeader,
            subBrush,
            18,
            42);
    }
}