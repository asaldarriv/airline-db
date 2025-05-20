using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class FlightStatusFacade
    {
        private readonly FlightStatusManager _manager = new();

        public IEnumerable<FlightStatus> GetAllFlightStatuses() => _manager.GetAllFlightStatuses();

        public FlightStatus? GetFlightStatusById(int id) => _manager.GetFlightStatusById(id);

        public void AddFlightStatus(FlightStatus status) => _manager.AddFlightStatus(status);

        public void UpdateFlightStatus(FlightStatus status) => _manager.UpdateFlightStatus(status);

        public void DeleteFlightStatus(int id) => _manager.DeleteFlightStatus(id);
    }
}