namespace Airline.core.AirlineEntities
{
    public class Layover
    {
        public int LayoverId { get; set; }
        public int? RouteId { get; set; }
        public int? CityId { get; set; }
        public int StopOrder { get; set; }
        public DateTime ScheduledArrivalTime { get; set; }
        public DateTime ScheduledDepartureTime { get; set; }
        public TimeSpan LayoverDuration { get; set; }
    }
}