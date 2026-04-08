using CoreOfficeERP.Domain.Responses.Tally;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface ITallyConfigService
    {
        Task<TallyConfigResponse> GetTallyConfig(int id);
    }
}
