namespace Airline.core.AirlineEntities
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string? AirplaneId { get; set; }
        public int? RouteId { get; set; }
        public int? FlightStatusId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}