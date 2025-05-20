using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class FlightFacade
    {
        private readonly FlightManager _manager = new();

        public IEnumerable<Flight> GetAllFlights() => _manager.GetAllFlights();

        public Flight? GetFlightById(int id) => _manager.GetFlightById(id);

        public void AddFlight(Flight flight) => _manager.AddFlight(flight);

        public void UpdateFlight(Flight flight) => _manager.UpdateFlight(flight);

        public void DeleteFlight(int id) => _manager.DeleteFlight(id);
    }
}