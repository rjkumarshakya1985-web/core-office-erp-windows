using CoreOfficeERP.Domain.Requests.Tally;
using CoreOfficeERP.Domain.Responses.Agent;
using CoreOfficeERP.Domain.Responses.Tally;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tally;

namespace CoreOfficeERP.Tally.Interfaces
{
    public interface ITallyProcessOrchestratorService
    {      
        List<TallyProcessRequest> ExecutePurchase(TallyPurchaseResponse data, TallyConfigResponse tallyConfig);
    }
}
