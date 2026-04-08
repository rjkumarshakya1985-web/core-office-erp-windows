using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOfficeERP.Domain.Responses.Tally
{
    public class TallyProcessResponse
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int FinanceYearId { get; set; }
        public string? ReferenceNo { get; set; }
        public int ProcessType { get; set; }
        public int Step { get; set; }
        public bool IsSuccess { get; set; }
        public string? RequestData { get; set; }
        public string? ResponseData { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
