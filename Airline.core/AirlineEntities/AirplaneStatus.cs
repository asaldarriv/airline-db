namespace Airline.core.AirlineEntities
{
    public class AirplaneStatus
    {
        public int AirplaneStatusId { get; set; }
        public string StatusCode { get; set; } = string.Empty;
        public string StatusName { get; set; } = string.Empty;
        public string? StatusDescription { get; set; }
        public bool IsActive { get; set; }
    }
}