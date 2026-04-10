using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOfficeERP.Domain.Responses.Tally
{
    public class TallyConfigResponse
    {
        public int CompanyId { get; set; }
        public CompanyDto Company { get; set; }

        public LedgerGroupDto Purchase { get; set; }
        public LedgerGroupDto Sale { get; set; }
    }
    public class LedgerGroupDto
    {
        public string MainLedger { get; set; }
        public string CGST { get; set; }
        public string SGST { get; set; }
        public string IGST { get; set; }
    }

    public class CompanyDto
    {
        public string Name { get; set; }
        public int StateId { get; set; }
        public string GSTIN { get; set; }
    }
}
