using CoreOfficeERP.Domain.Requests.DeliveryChallan;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface IInvoiceService
    {
        Task<int> CreateAsync(BillingRequest request);
    }
}
