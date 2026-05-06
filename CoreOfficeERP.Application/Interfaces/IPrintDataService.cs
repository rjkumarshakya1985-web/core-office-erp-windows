using CoreOfficeERP.Domain.Responses.Print;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface IPrintDataService
    {
        public Task<PackingSlipPrintResponse?> GetPackingSlipPrint(int id);

    }
}
