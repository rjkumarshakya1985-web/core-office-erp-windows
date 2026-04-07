using CoreOfficeERP.Domain.Requests.DeliveryChallan;
using CoreOfficeERP.Domain.Responses.Invoices;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface IInvoiceService
    {
        Task<int> CreateAsync(BillingRequest request);
        Task<InvoiceResponse?> GetInvoice(string number, int finYearId);
        Task<InvoiceResponse?> GetInvoice(int id);

        public Task<bool> CancelInvoice(int invoiceId);
    }
}
