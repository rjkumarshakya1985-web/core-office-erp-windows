namespace CoreOfficeERP.Domain.Responses.PackingSlip
{
    public class BillPackingSlipsResponse
    {
        public int TotalPcs { get; set; }

        public decimal GrandTotal { get; set; }

        public List<PackingSlipResponse> PackingSlips { get; set; } = new List<PackingSlipResponse>();
    }
}
