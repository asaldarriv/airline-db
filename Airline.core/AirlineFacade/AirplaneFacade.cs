using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class AirplaneFacade
    {
        private readonly AirplaneManager _manager = new();

        public IEnumerable<Airplane> GetAllAirplanes() => _manager.GetAllAirplanes();

        public Airplane? GetAirplaneById(string registrationNumber) => _manager.GetAirplaneById(registrationNumber);

        public void AddAirplane(Airplane airplane) => _manager.AddAirplane(airplane);

        public void UpdateAirplane(Airplane airplane) => _manager.UpdateAirplane(airplane);

        public void DeleteAirplane(string registrationNumber) => _manager.DeleteAirplane(registrationNumber);
    }
}