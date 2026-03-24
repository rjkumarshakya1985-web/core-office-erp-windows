namespace CoreOfficeERP.Common.Extensions
{
    public static class DateTimeExtensions
    {
        private static readonly TimeZoneInfo IstZone =
            TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

        public static DateTime ToIst(this DateTime utcDate)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(
                DateTime.SpecifyKind(utcDate, DateTimeKind.Utc),
                IstZone);
        }

        public static string ToIstString(this DateTime utcDate, string format = "dd-MMM-yyyy hh:mm tt")
        {
            var istDate = utcDate.ToIst();
            return istDate.ToString(format);
        }
    }
}
