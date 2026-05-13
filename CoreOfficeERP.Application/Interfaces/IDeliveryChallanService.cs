using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Requests.DeliveryChallan;
using CoreOfficeERP.Domain.Responses.DeliveryChallan;


namespace CoreOfficeERP.Application.Interfaces
{
    public interface IDeliveryChallanService
    {
        Task<TableResult<DeliveryChallanListResponse>> GetTableData(TableDataRequest tableDataRequest,int finYearId);

        Task<int> CreateAsync(BillingRequest request);
        Task<int> UpdateDeliveryChallanAsnc(UpdateDeliveryChallanRequest request);

        public Task<DeliveryChallanReturnDetailResponse?> GetDeliveryChallanForReturn(string number, int finYearId);

        public Task<DeliveryChallanReturnDetailResponse?> GetDeliveryChallan(string number, int finYearId);

        public Task<int> SaveDeliveryChallanReturn(DeliveryChalanReturnRequest request);

        public Task<bool> CancelDeliveryChallan(int delviveryChallanId);
    }
}
