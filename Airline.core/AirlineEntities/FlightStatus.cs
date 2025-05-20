namespace Airline.core.AirlineEntities
{
    public class FlightStatus
    {
        public int FlightStatusId { get; set; }
        public string StatusCode { get; set; } = string.Empty;
        public string StatusName { get; set; } = string.Empty;
        public string? StatusDescription { get; set; }
        public bool IsActive { get; set; }
    }
}