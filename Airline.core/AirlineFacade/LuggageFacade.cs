using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class LuggageFacade
    {
        private readonly LuggageManager _manager = new();

        public IEnumerable<Luggage> GetAllLuggages() => _manager.GetAllLuggages();

        public Luggage? GetLuggageById(int id) => _manager.GetLuggageById(id);

        public void AddLuggage(Luggage luggage) => _manager.AddLuggage(luggage);

        public void UpdateLuggage(Luggage luggage) => _manager.UpdateLuggage(luggage);

        public void DeleteLuggage(int id) => _manager.DeleteLuggage(id);
    }
}