using CoreOfficeERP.Domain.Responses.SalesPersons;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface ISalesPersonService
    {
        Task<List<SalePersonResponse>> GetActiveSalesPerson();
    }
}
