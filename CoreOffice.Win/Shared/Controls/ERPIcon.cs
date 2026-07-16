using CoreOffice.Win.Shared.Theme;
using FontAwesome.Sharp;
using System.ComponentModel;

namespace CoreOffice.Win.Shared.Controls;

public class ERPIcon : IconPictureBox
{
    public ERPIcon()
    {
        BackColor = Color.Transparent;
        ForeColor = ERPColors.Primary;
        IconSize = 18;
        Size = new Size(20, 20);
        SizeMode = PictureBoxSizeMode.CenterImage;
    }
    [Category("ERP")]
    [DefaultValue(false)]
    public ERPIconType IconType
    {
        get => _icon;
        set
        {
            _icon = value;
            IconChar = GetIcon(value);
        }
    }

    private ERPIconType _icon = ERPIconType.None;

    private static IconChar GetIcon(ERPIconType icon)
    {
        return icon switch
        {
            ERPIconType.Customer => IconChar.UserTie,
            ERPIconType.Supplier => IconChar.Truck,
            ERPIconType.Product => IconChar.Box,
            ERPIconType.Company=> IconChar.Building,
            ERPIconType.Employee => IconChar.UserTie,
            ERPIconType.Credit=>IconChar.Calendar,

            ERPIconType.User => IconChar.User,
            ERPIconType.Mobile => IconChar.MobileScreenButton,
            ERPIconType.Phone => IconChar.Phone,
            ERPIconType.Email => IconChar.Envelope,

            ERPIconType.Address => IconChar.LocationDot,
            ERPIconType.City => IconChar.City,
            ERPIconType.State => IconChar.Map,
            ERPIconType.Group => IconChar.Users,
            ERPIconType.Password => IconChar.Key,

            ERPIconType.GST => IconChar.FileInvoiceDollar,
            ERPIconType.PAN => IconChar.IdCard,

            ERPIconType.Amount => IconChar.IndianRupeeSign,
            ERPIconType.Discount => IconChar.Percent,

            ERPIconType.Calendar => IconChar.CalendarDays,
            ERPIconType.Search => IconChar.MagnifyingGlass,
            ERPIconType.Barcode => IconChar.Barcode,
            ERPIconType.QRCode => IconChar.Qrcode,

            ERPIconType.Save => IconChar.FloppyDisk,
            ERPIconType.Edit => IconChar.Pen,
            ERPIconType.Delete => IconChar.Trash,
            ERPIconType.Refresh => IconChar.Rotate,
            ERPIconType.Close => IconChar.Xmark,
            ERPIconType.Add => IconChar.Plus,

            ERPIconType.Home => IconChar.House,
            ERPIconType.Dashboard => IconChar.ChartColumn,
            ERPIconType.Reports => IconChar.FileLines,

            ERPIconType.Warning => IconChar.TriangleExclamation,
            ERPIconType.Success => IconChar.CircleCheck,
            ERPIconType.Error => IconChar.CircleXmark,
            ERPIconType.Info => IconChar.CircleInfo,

            _ => IconChar.None
        };
    }
}