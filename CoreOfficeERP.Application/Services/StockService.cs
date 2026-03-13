using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Responses;
using CoreOfficeERP.Infrastructure.Api;

namespace CoreOfficeERP.Application.Services
{
    public class StockService : IStockService
    {
        private readonly IApiRepository _apiRepository;

        public StockService(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }
        public async Task<IEnumerable<CurrentStockResponse>> GetStockItemsByBarcode(string barcode)
        {
            var reuslt = await _apiRepository
              .GetByIdAsync<ApiResponse<IEnumerable<CurrentStockResponse>>>(ApiEndpoints.GetStockItemsByBarcode, barcode);

            return reuslt?.Data;
        }


    }
}
