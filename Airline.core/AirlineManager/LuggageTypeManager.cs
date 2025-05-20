using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class LuggageTypeManager
    {
        private readonly ILuggageTypeRepository _repository;

        public LuggageTypeManager(ILuggageTypeRepository? repository = null)
        {
            _repository = repository ?? new LuggageTypeRepository();
        }

        public IEnumerable<LuggageType> GetAllLuggageTypes() => _repository.GetAll();

        public LuggageType? GetLuggageTypeById(int id) => _repository.GetById(id);

        public void AddLuggageType(LuggageType luggageType) => _repository.Add(luggageType);

        public void UpdateLuggageType(LuggageType luggageType) => _repository.Update(luggageType);

        public void DeleteLuggageType(int id) => _repository.Delete(id);
    }
}