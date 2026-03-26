using CoreOfficeERP.Domain.Responses.DeliveryChallanToInvoice;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface IDeliveryChallanToInvoiceService
    {
        Task<DeliverChallanToInvoiceResponse?> GetDeliveryChallanForInvoiceByNumber(string number, int finYearId);
    }
}
