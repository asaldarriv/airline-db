namespace Airline.core.AirlineEntities
{
    public class Airplane
    {
        public string RegistrationNumber { get; set; } = string.Empty;
        public int? AirplaneStatusId { get; set; }
        public int PassengerCapacity { get; set; }
        public string Manufacturer { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public DateTime AcquisitionDate { get; set; }
    }
}