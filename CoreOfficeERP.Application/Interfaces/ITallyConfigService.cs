using CoreOfficeERP.Domain.Responses;
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
        public Task<TallyConfigResponse> GetTallyConfig(int id);
        public Task<IEnumerable<TallyCompanyResponse>> GetAllCompanies();
    }
}
