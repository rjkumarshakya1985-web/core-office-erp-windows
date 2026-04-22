using CoreOfficeERP.Common.Enums;

namespace CoreOfficeERP.Domain.Requests.Tally
{
    public class TallyNameRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string TallyName { get; set; }
        public TallyType Type { get; set; }
    }
}
