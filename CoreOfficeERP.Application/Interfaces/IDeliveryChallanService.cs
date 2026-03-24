using CoreOfficeERP.Domain.Requests.DeliveryChallan;
using CoreOfficeERP.Domain.Responses.DeliveryChallan;


namespace CoreOfficeERP.Application.Interfaces
{
    public interface IDeliveryChallanService
    {
        Task<int> CreateAsync(BillingRequest request);

        public Task<DeliveryChallanReturnDetailResponse?> GetDeliveryChallanForReturn(string number, int FinYearId);

        public Task<int> SaveDeliveryChallanReturn(DeliveryChalanReturnRequest request);
    }
}
