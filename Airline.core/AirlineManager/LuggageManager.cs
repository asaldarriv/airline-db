using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class LuggageManager
    {
        private readonly ILuggageRepository _repository;

        public LuggageManager(ILuggageRepository? repository = null)
        {
            _repository = repository ?? new LuggageRepository();
        }

        public IEnumerable<Luggage> GetAllLuggages() => _repository.GetAll();

        public Luggage? GetLuggageById(int id) => _repository.GetById(id);

        public void AddLuggage(Luggage luggage) => _repository.Add(luggage);

        public void UpdateLuggage(Luggage luggage) => _repository.Update(luggage);

        public void DeleteLuggage(int id) => _repository.Delete(id);
    }
}