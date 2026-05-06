using CoreOfficeERP.Domain.Responses.Company;

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
