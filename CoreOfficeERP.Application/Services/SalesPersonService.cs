using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Responses;
using CoreOfficeERP.Domain.Responses.SalesPersons;
using CoreOfficeERP.Infrastructure.Api;

namespace CoreOfficeERP.Application.Services
{
    public class SalesPersonService : ISalesPersonService
    {
      
        private readonly IApiRepository _apiRepository;

        public SalesPersonService(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }
        public async Task<List<SalePersonResponse>> GetActiveSalesPerson()
        {
            var reuslt = await _apiRepository
            .GetAsync<ApiResponse<List<SalePersonResponse>>>(ApiEndpoints.GetAllActiveSalesPersons);
            return reuslt?.Data;
        }
    }
}
