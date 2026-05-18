using CoreOfficeERP.Domain.Responses.Agent;
using CoreOfficeERP.Domain.Responses.Tally;
using Tally;

namespace CoreOfficeERP.Tally.Interfaces
{
    public interface ITallyPurchaseService
    {
        TallyResponse CreateVendorGroup(AgentTableResponse agent, TallyConfigResponse config);
        TallyResponse CreateVendor(SupplierResponse supplier, TallyConfigResponse config);
        TallyResponse CreateStockCategory(StockCategoryResponse category, TallyConfigResponse config);
        TallyResponse CreateStockGroup(StockGroupResponse group, TallyConfigResponse config);
        TallyResponse CreateStockItem(StockitemResponse item,TallyConfigResponse config, TallyPurchaseResponse data);
        TallyResponse CreatePurchaseVoucher(TallyPurchaseResponse data, TallyConfigResponse config,string sbillnumber);

    }
}