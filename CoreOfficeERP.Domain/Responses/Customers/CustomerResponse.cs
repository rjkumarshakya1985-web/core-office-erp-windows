using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOfficeERP.Domain.Responses.Customers
{
    public class CustomerResponse
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Mobile { get; set; }
    }
}
