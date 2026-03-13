using CoreOfficeERP.Domain.Responses;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface IStockService
    {
        Task<IEnumerable<CurrentStockResponse>> GetStockItemsByBarcode(string barcode);
    }
}
