using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Domain.Requests.Tally;
using CoreOfficeERP.Domain.Responses.Tally;
using CoreOfficeERP.Tally.Interfaces;
using Tally;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CoreOfficeERP.Tally.Services
{
    public class TallyProcessOrchestratorService:ITallyProcessOrchestratorService
    {
        private readonly ITallyPurchaseService _tally;        
        public TallyProcessOrchestratorService(ITallyPurchaseService tally)
        {
            _tally = tally;
        }

        public List<TallyProcessRequest> ExecutePurchase(TallyPurchaseResponse data,TallyConfigResponse config)
        {
            var logs = new List<TallyProcessRequest>();
            int step = 1;
            try
            {
                var supplier = data.SupplierResponse;
                ExecuteStep("Vendor Group", step++, () => _tally.CreateVendorGroup(supplier.AgentObj, config),logs,data,config);
                ExecuteStep("Vendor", step++, () => _tally.CreateVendor(supplier, config),logs,data,config);

                // Loop for Stock Categories
                foreach (var category in data.StockCategoryResponse)
                {
                    ExecuteStep($"Stock Category: {category.Name}", step++, () =>
                        _tally.CreateStockCategory(category, config),logs,data, config);
                }
                // Loop for Stock Groups
                foreach (var group in data.StockGroupResponse)
                {
                    ExecuteStep($"Stock Group: {group.Name}", step++,
                        () => _tally.CreateStockGroup(group, config),logs,data, config);
                }
                // Loop for Stock Items
                foreach (var item in data.StockitemResponse)
                {
                    ExecuteStep($"Stock Item: {item.ProductName}", step++,
                        () => _tally.CreateStockItem(item, config),logs,data, config);
                }
                ExecuteStep("Purchase Entry", step++, () => _tally.CreatePurchaseVoucher(data, config),logs,data, config);
            }
            catch (Exception ex)
            {
                logs.Add(new TallyProcessRequest
                {
                    Id = data.SaleVoucherPrint.Id,
                    Step = step,
                    IsSuccess = false,
                    ErrorMessage = ex.Message,
                    CreatedOn = DateTime.Now
                });

                throw;
            }
            return logs;

        }

        private void ExecuteStep(string stepName, int stepNo, Func<TallyResponse> action,List<TallyProcessRequest> logs,TallyPurchaseResponse data,TallyConfigResponse config)
        {
            var log = new TallyProcessRequest
            {
                Id = data.SaleVoucherPrint.Id,
                CompanyId = config.CompanyId, // map properly
                FinanceYearId = 1, // map properly
                ReferenceNo = data.SaleVoucherPrint.SupplierBillNumber,
                ProcessType = (int)TallyProcessType.Purchase,
                Step = stepNo,
                CreatedOn = DateTime.Now
            };

            try
            {
                var res = action();

                log.IsSuccess = res.errorCode == 0;
                log.ResponseData = res.errorMsg;

                if (!log.IsSuccess)
                {
                    log.ErrorMessage = res.errorMsg;
                    logs.Add(log);
                    throw new Exception($"{stepName} Failed: {res.errorMsg}");
                }
            }
            catch (Exception ex)
            {
                log.IsSuccess = false;
                log.ErrorMessage = ex.Message;
                logs.Add(log);
                throw;
            }

            logs.Add(log);
        }
       
    }
}