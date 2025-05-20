using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class AirplaneStatusFacade
    {
        private readonly AirplaneStatusManager _manager = new();

        public IEnumerable<AirplaneStatus> GetAllAirplaneStatuses() => _manager.GetAllAirplaneStatuses();

        public AirplaneStatus? GetAirplaneStatusById(int id) => _manager.GetAirplaneStatusById(id);

        public void AddAirplaneStatus(AirplaneStatus status) => _manager.AddAirplaneStatus(status);

        public void UpdateAirplaneStatus(AirplaneStatus status) => _manager.UpdateAirplaneStatus(status);

        public void DeleteAirplaneStatus(int id) => _manager.DeleteAirplaneStatus(id);
    }
}