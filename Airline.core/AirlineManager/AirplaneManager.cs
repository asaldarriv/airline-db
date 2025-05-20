using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class AirplaneManager
    {
        private readonly IAirplaneRepository _repository;

        public AirplaneManager(IAirplaneRepository? repository = null)
        {
            _repository = repository ?? new AirplaneRepository();
        }

        public IEnumerable<Airplane> GetAllAirplanes() => _repository.GetAll();

        public Airplane? GetAirplaneById(string registrationNumber) => _repository.GetById(registrationNumber);

        public void AddAirplane(Airplane airplane) => _repository.Add(airplane);

        public void UpdateAirplane(Airplane airplane) => _repository.Update(airplane);

        public void DeleteAirplane(string registrationNumber) => _repository.Delete(registrationNumber);
    }
}