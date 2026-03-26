namespace CoreOfficeERP.Domain.Responses.MasterData
{
    public class CityResponse
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int StateId { get; set; }
    }
}
