using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOfficeERP.Domain.Requests.Customers
{
    public class CustomerRequest
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string? Alias { get; set; }
        public string? LedgerName { get; set; }
        public string? PrintName { get; set; }
        public string? GroupName { get; set; }
        public string? GstIn { get; set; }
        public string? Pan { get; set; }
        public int? RegType { get; set; }
        public string? BillingAddress { get; set; }
        public string? ShippingAddress { get; set; }
        public int CityId { get; set; }
        public string? PinCode { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? ContactPerson { get; set; }
        public decimal? OpeningBalance { get; set; }
        public int? CreditDays { get; set; }
        public decimal? CreditLimit { get; set; }
        public int? PriceLevel { get; set; }
        public int? TallyLedgerType { get; set; }
        public int? TallyCategory { get; set; }
        public int CustomerType { get; set; }
        public string? Remarks { get; set; }
    }
}
