using CoreOffice.Win.Shared.Theme;
using System.ComponentModel;

namespace CoreOffice.Win.Shared.Controls;

public class ERPLabel : Label
{
    private ERPLabelType _labelType = ERPLabelType.Normal;

    public ERPLabel()
    {
        AutoSize = true;
        ApplyTheme();
    }

    [Category("ERP")]
    [DefaultValue(ERPLabelType.Normal)]
    public ERPLabelType LabelType
    {
        get => _labelType;
        set
        {
            _labelType = value;
            ApplyTheme();
        }
    }

    [Category("ERP")]
    [DefaultValue(false)]
    public bool Required { get; set; }

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);

        if (Required && !Text.EndsWith(" *"))
            Text += " *";
    }

    private void ApplyTheme()
    {
        switch (_labelType)
        {
            case ERPLabelType.Normal:
                Font = ERPFonts.Label;
                ForeColor = ERPColors.Text;
                break;

            case ERPLabelType.Header:
                Font = ERPFonts.Header;
                ForeColor = ERPColors.Primary;
                break;

            case ERPLabelType.Section:
                Font = ERPFonts.SubHeader;
                ForeColor = ERPColors.Primary;
                break;

            case ERPLabelType.Required:
                Font = ERPFonts.Label;
                ForeColor = Color.Red;
                break;
        }
    }
}