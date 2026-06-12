using System.Text.Json.Serialization;

namespace CoreOfficeERP.Domain.Responses.Print
{
    public class PackingSlipPrintResponse
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string PackingSlipNo { get; set; }
        public required string VisitorName { get; set; }
        public required string VisitorMobile { get; set; }
        public required string SalesManName { get; set; }
        public required string PackingSlipManName { get; set; }
        public required string Department { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalTaxableAmount { get; set; }
        public decimal TotalAmount { get; set; }

        public CompanyDetailResponse CompanyDetail { get; set; }
        public List<PackingSlipPrintItemResponse> Items { get; set; } = new List<PackingSlipPrintItemResponse>();
    }
    public class CompanyDetailResponse
    {
        public int Id { get; set; }

        [JsonPropertyName("companyName")]
        public string Name { get; set; }

        [JsonPropertyName("address1")]
        public string Address { get; set; }

        [JsonPropertyName("address2")]
        public string? Address2 { get; set; }

        [JsonPropertyName("gstIn")]
        public string GstIn { get; set; }

        // Added fallback properties to match your print requirements safely
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string StateCode { get; set; } = string.Empty;
    }
    public class PackingSlipPrintItemResponse
    {
        public int Id { get; set; }

        public required string StockGroupName { get; set; }
        public required string ProductName { get; set; }

        public required string Barcode { get; set; }
        public required string HsnCode { get; set; }
        public int Quantity { get; set; }
      
        public int GstPercentage { get; set; }
        public decimal Rate { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal Amount { get; set; }
    }
}
