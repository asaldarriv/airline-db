namespace Airline.core.AirlineEntities
{
    public class Route
    {
        public int RouteId { get; set; }
        public int? OriginCityId { get; set; }
        public int? DestinationCityId { get; set; }
    }
}