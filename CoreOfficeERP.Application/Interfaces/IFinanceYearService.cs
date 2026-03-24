using CoreOfficeERP.Domain.Responses;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface IFinanceYearService
    {
        public Task<IEnumerable<FinanceYearResponse>> GetActiveFinanceYears();
    }
}
