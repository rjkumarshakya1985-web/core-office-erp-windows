using CoreOffice.Win.Shared.Theme;
using System.ComponentModel;

namespace CoreOffice.Win.Shared.Controls;

public class ERPControl : UserControl
{
    public ERPControl()
    {
        DoubleBuffered = true;

        BackColor = ERPTheme.CardColor;
        ForeColor = ERPTheme.TextColor;
        Font = ERPFonts.TextBox;

        Margin = new Padding(5);
    }

    [Browsable(false)]
    public bool IsDarkTheme => false;

    protected virtual void ApplyTheme()
    {
        BackColor = ERPTheme.CardColor;
        ForeColor = ERPTheme.TextColor;
        Font = ERPFonts.TextBox;

        Invalidate();
    }

    protected override void OnFontChanged(EventArgs e)
    {
        base.OnFontChanged(e);
        Invalidate();
    }

    protected override void OnForeColorChanged(EventArgs e)
    {
        base.OnForeColorChanged(e);
        Invalidate();
    }

    protected override void OnBackColorChanged(EventArgs e)
    {
        base.OnBackColorChanged(e);
        Invalidate();
    }
}