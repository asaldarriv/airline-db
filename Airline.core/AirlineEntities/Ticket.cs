namespace Airline.core.AirlineEntities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int? CustomerId { get; set; }
        public int? FlightId { get; set; }
        public int? TicketStatusId { get; set; }
        public decimal Price { get; set; }
        public string AssignedSeat { get; set; } = string.Empty;
        public DateTime SaleDate { get; set; }
    }
}