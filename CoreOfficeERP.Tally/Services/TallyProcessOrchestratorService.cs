using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Domain.Requests.Tally;
using CoreOfficeERP.Domain.Responses.Tally;
using CoreOfficeERP.Tally.Interfaces;
using System.Text.Json;
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

        public async Task<List<TallyProcessRequest>> ExecutePurchase(TallyPurchaseResponse data,TallyConfigResponse config,int finid, string sbillnumber)
        {
            var logs = new List<TallyProcessRequest>();
            int step = 1;
            try
            {
                var supplier = data.SupplierResponse;
                if (!ExecuteStep("Vendor Group", step++,supplier.AgentObj, () => _tally.CreateVendorGroup(supplier.AgentObj, config), logs, data, config,finid))
                    return logs;

                if (!ExecuteStep("Vendor", step++,supplier, () => _tally.CreateVendor(supplier, config), logs, data, config, finid))
                    return logs;


                // Loop for Stock Categories
                foreach (var category in data.StockCategoryResponse)
                {
                    if (!ExecuteStep($"Stock Category: {category.Name}", step++,category,
                        () => _tally.CreateStockCategory(category, config), logs, data, config, finid))
                        return logs;
                }

                // Loop for Stock Groups
                foreach (var group in data.StockGroupResponse)
                {
                    if (!ExecuteStep($"Stock Group: {group.Name}", step++,group,
                        () => _tally.CreateStockGroup(group, config), logs, data, config, finid))
                        return logs;
                }

                // Loop for Stock Items
                foreach (var item in data.StockitemResponse)
                {
                    if (!ExecuteStep($"Stock Item: {item.ProductName}", step++,item,
                        () => _tally.CreateStockItem(item, config, data), logs, data, config, finid))
                        return logs;
                }
                if (!ExecuteStep("Purchase Entry", step++,data,
                () => _tally.CreatePurchaseVoucher(data, config,sbillnumber), logs, data, config, finid))
                    return logs;              
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
            }
            return logs;

        }

        private bool ExecuteStep<TRequest>(string stepName, int stepNo, TRequest requestObj, Func<TallyResponse> action,List<TallyProcessRequest> logs,TallyPurchaseResponse data,TallyConfigResponse config,int finid)
        {
            var log = new TallyProcessRequest
            {               
                CompanyId = config.CompanyId, // map properly
                FinanceYearId = finid, // map properly
                ReferenceNo = data.SaleVoucherPrint.Id.ToString(),
                ProcessType = (int)TallyProcessType.Purchase,
                Step = stepNo,
                RequestData = JsonSerializer.Serialize(requestObj), // ✅ REAL DATA
                ResponseData =null, // This will be updated after action execution
                ErrorMessage = null,
                CreatedOn = DateTime.Now
            };

            try
            {
                var res = action();
                if (res == null)
                {
                    log.IsSuccess = false;
                    log.ErrorMessage = $"{stepName} returned null response";
                    log.ResponseData = JsonSerializer.Serialize(res); // ✅ FULL RESPONSE

                    logs.Add(log);
                    return false; // ❌ STOP but no exception
                }
                log.IsSuccess = res.errorCode == 0;
                log.ResponseData = res.errorMsg;

                if (!log.IsSuccess)
                {
                    log.ErrorMessage = res.errorMsg;
                    logs.Add(log);
                    return false; // ❌ STOP
                    //throw new Exception($"{stepName} Failed: {res.errorMsg}");
                }
            }
            catch (Exception ex)
            {
                log.IsSuccess = false;
                log.ErrorMessage = ex.Message;
                logs.Add(log);
                return false; // ❌ STOP               
            }

            logs.Add(log);
            return true; // ✅ CONTINUE
        }
       
    }
}