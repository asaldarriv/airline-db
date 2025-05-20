namespace Airline.core.AirlineEntities
{
    public class TicketStatus
    {
        public int TicketStatusId { get; set; }
        public string StatusCode { get; set; } = string.Empty;
        public string StatusName { get; set; } = string.Empty;
        public string? StatusDescription { get; set; }
        public bool IsActive { get; set; }
    }
}