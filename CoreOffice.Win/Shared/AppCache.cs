
using CoreOfficeERP.Domain.Responses;
using CoreOfficeERP.Domain.Responses.Tally;

namespace CoreOffice.Win.Shared
{
    public class AppCache
    {
        public static List<FinanceYearResponse> Companies { get; set; }
        public static List<TallyCompanyResponse> TallyCompanies { get; set; }
    }
}
