using CoreOfficeERP.Common.Enums;

namespace CoreOfficeERP.Common.Extensions
{
    public static class GSTRegistrationExtensions
    {
        public static string ToTallyString(this int? regType)
        {
            if (!Enum.IsDefined(typeof(GSTRegistrationType), regType))
                return "Unregistered/Consumer";

            return ((GSTRegistrationType)regType) switch
            {
                GSTRegistrationType.Regular => "Regular",
                GSTRegistrationType.Composition => "Composition",
                GSTRegistrationType.Unregistered => "Unregistered/Consumer",
                _ => "Unregistered/Consumer"
            };
        }
    }
}