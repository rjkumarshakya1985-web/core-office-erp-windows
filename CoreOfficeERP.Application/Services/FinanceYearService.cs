

using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Responses;
using CoreOfficeERP.Infrastructure.Api;

namespace CoreOfficeERP.Application.Services
{
    public class FinanceYearService : IFinanceYearService
    {

        private readonly IApiRepository _apiRepository;

        public FinanceYearService(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }
        public async Task<IEnumerable<FinanceYearResponse>> GetActiveFinanceYears()
        {
            var reuslt = await _apiRepository
              .GetAsync<ApiResponse<IEnumerable<FinanceYearResponse>>>(ApiEndpoints.GetActiveFinancialYear);

            return reuslt?.Data;
        }
    }
}
