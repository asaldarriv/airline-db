namespace Airline.core.AirlineEntities
{
    public class Luggage
    {
        public int LuggageId { get; set; }
        public int TicketId { get; set; }
        public int LuggageTypeId { get; set; }
        public int Quantity { get; set; }
    }
}