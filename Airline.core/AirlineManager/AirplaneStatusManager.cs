using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class AirplaneStatusManager
    {
        private readonly IAirplaneStatusRepository _repository;

        public AirplaneStatusManager(IAirplaneStatusRepository? repository = null)
        {
            _repository = repository ?? new AirplaneStatusRepository();
        }

        public IEnumerable<AirplaneStatus> GetAllAirplaneStatuses() => _repository.GetAll();

        public AirplaneStatus? GetAirplaneStatusById(int id) => _repository.GetById(id);

        public void AddAirplaneStatus(AirplaneStatus status) => _repository.Add(status);

        public void UpdateAirplaneStatus(AirplaneStatus status) => _repository.Update(status);

        public void DeleteAirplaneStatus(int id) => _repository.Delete(id);
    }
}