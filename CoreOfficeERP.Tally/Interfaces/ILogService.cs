using CoreOfficeERP.Domain.Requests.PackingSlip;
using CoreOfficeERP.Domain.Requests.Tally;
using CoreOfficeERP.Domain.Responses;
using CoreOfficeERP.Domain.Responses.Tally;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOfficeERP.Tally.Interfaces
{
    public interface ILogService
    {
        Task<int> CreateAsync(TallyProcessRequest request);
        Task<TallyProcessResponse?> GetTallyProcess(int companyId);

        Task<TallyProcessResponse?> GetTallyProcessSteps(int companyId, int financialYearId, int processType, string referenceNo);
    }
}
