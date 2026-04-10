using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOfficeERP.Domain.Requests.Tally
{
    public class TallyConfigRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Remarks { get; set; }
        public Guid? CreatedBy { get; set; }
        public string? CreatedByUserName { get; set; }
        public DateTime CreatedOn { get; set; }


    }
}
