using System.ComponentModel;

namespace CoreOfficeERP.Common.Hepler
{
    public class Helper
    {
        public static string GetEnumDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attr = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attr.Length > 0 ? attr[0].Description : value.ToString();
        }


    }
}
