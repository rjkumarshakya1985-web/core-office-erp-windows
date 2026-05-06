using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Responses.Print;
using CoreOfficeERP.Infrastructure.Api;

namespace CoreOfficeERP.Application.Services
{
    public class PrintDataService : IPrintDataService
    {

        private readonly IApiRepository _apiRepository;

        public PrintDataService(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }
        public async Task<PackingSlipPrintResponse?> GetPackingSlipPrint(int id)
        {
            var reuslt = await _apiRepository
             .GetByIdAsync<ApiResponse<PackingSlipPrintResponse>>(ApiEndpoints.PackingSlipPrint, id);

            return reuslt?.Data;
        }
    }
}
