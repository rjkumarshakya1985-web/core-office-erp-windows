namespace CoreOfficeERP.Domain.Requests.Tally
{
    public class TallyProcessBatchRequest
    {
        public int VoucherId { get; set; }
        public List<TallyProcessRequest> Steps { get; set; }
    }
}
