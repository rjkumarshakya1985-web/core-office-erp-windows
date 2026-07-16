using CoreOffice.Win.Shared.Theme;
using System.ComponentModel;

namespace CoreOffice.Win.Shared.Controls;

public class ERPButton : Button
{
    private ERPButtonType _buttonType = ERPButtonType.Primary;

    public ERPButton()
    {
        InitializeControl();
        
    }
    private void InitializeControl()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;

        Font = ERPFonts.Button;

        Height = ERPStyle.ButtonHeight;

        Cursor = Cursors.Hand;

        UseVisualStyleBackColor = false;

        ApplyStyle();
    }

    [Category("ERP")]
    [DefaultValue(ERPButtonType.Primary)]
    public ERPButtonType ButtonType
    {
        get => _buttonType;
        set
        {
            _buttonType = value;
            ApplyStyle();
        }
    }

    protected override void OnEnabledChanged(EventArgs e)
    {
        base.OnEnabledChanged(e);
        ApplyStyle();
    }

    private void ApplyStyle()
    {
        if (!Enabled)
        {
            BackColor = Color.Gainsboro;
            ForeColor = Color.Gray;
            return;
        }

        switch (_buttonType)
        {
            case ERPButtonType.Primary:
                BackColor = ERPColors.Primary;
                ForeColor = Color.White;
                break;

            case ERPButtonType.Success:
                BackColor = ERPColors.Success;
                ForeColor = Color.White;
                break;

            case ERPButtonType.Danger:
                BackColor = ERPColors.Danger;
                ForeColor = Color.White;
                break;

            case ERPButtonType.Warning:
                BackColor = ERPColors.Warning;
                ForeColor = Color.Black;
                break;

            case ERPButtonType.Secondary:
                BackColor = Color.DimGray;
                ForeColor = Color.White;
                break;
            case ERPButtonType.Save:
                BackColor = Color.RoyalBlue;
                ForeColor = Color.White;
                break;
            case ERPButtonType.Clear:
                BackColor = Color.FromArgb(107, 114, 128);
                ForeColor = Color.White;
                break;
            case ERPButtonType.Close:
                BackColor = Color.FromArgb(55, 65, 81);
                ForeColor = Color.White;
                break;
            case ERPButtonType.Edit:
                BackColor = Color.FromArgb(245, 158, 11);
                ForeColor = Color.Black;
                break;            
            case ERPButtonType.Remove:
                BackColor = Color.FromArgb(220, 38, 38);
                ForeColor = Color.Black;
                break;
                case ERPButtonType.List:
                BackColor = Color.FromArgb(124, 58, 237);
                ForeColor = Color.White;
                break;
        }
    }
}