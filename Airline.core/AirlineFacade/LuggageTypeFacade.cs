using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class LuggageTypeFacade
    {
        private readonly LuggageTypeManager _manager = new();

        public IEnumerable<LuggageType> GetAllLuggageTypes() => _manager.GetAllLuggageTypes();

        public LuggageType? GetLuggageTypeById(int id) => _manager.GetLuggageTypeById(id);

        public void AddLuggageType(LuggageType luggageType) => _manager.AddLuggageType(luggageType);

        public void UpdateLuggageType(LuggageType luggageType) => _manager.UpdateLuggageType(luggageType);

        public void DeleteLuggageType(int id) => _manager.DeleteLuggageType(id);
    }
}