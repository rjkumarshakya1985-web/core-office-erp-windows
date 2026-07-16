using System.Drawing;

namespace CoreOffice.Win.Shared.Theme;

public static class ERPTheme
{
    // Colors
    public static Color PrimaryColor => ERPColors.Primary;
    public static Color FormBackColor => ERPColors.Window;
    public static Color CardColor => ERPColors.Card;

    public static Color BorderColor => ERPColors.Border;
    public static Color FocusColor => ERPColors.FocusBorder;

    public static Color GridAlternateRowBackColor => ERPColors.GridAlternateRow;

    // Fonts
    public static Font NormalFont => ERPFonts.Label;
    public static Font TextBoxFont => ERPFonts.TextBox;
    public static Font ButtonFont => ERPFonts.Button;
    public static Font GridFont => ERPFonts.Grid;
    public static Font GridHeaderFont => ERPFonts.GridHeader;
    public static Color SecondaryColor => ERPColors.PrimaryLight;

    public static Color SuccessColor => ERPColors.Success;
    public static Color DangerColor => ERPColors.Danger;
    public static Color WarningColor => ERPColors.Warning;
    public static Color InfoColor => ERPColors.Info;

    public static Color BackgroundColor => ERPColors.Window;
   
    public static Color DisabledColor => ERPColors.ReadOnly;

    public static Color TextColor => ERPColors.Text;
    public static Color LightTextColor => ERPColors.LightText;

    public static Color HeaderTextColor => ERPColors.WhiteText;

    public static Color GridHeaderColor => ERPColors.GridHeader;
    public static Color GridHeaderTextColor => ERPColors.GridHeaderText;
    public static Color GridAlternateRowColor => ERPColors.GridAlternateRow;
    public static Color GridSelectionColor => ERPColors.GridSelection;
}