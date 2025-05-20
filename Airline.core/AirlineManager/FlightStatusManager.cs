using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class FlightStatusManager
    {
        private readonly IFlightStatusRepository _repository;

        public FlightStatusManager(IFlightStatusRepository? repository = null)
        {
            _repository = repository ?? new FlightStatusRepository();
        }

        public IEnumerable<FlightStatus> GetAllFlightStatuses() => _repository.GetAll();

        public FlightStatus? GetFlightStatusById(int id) => _repository.GetById(id);

        public void AddFlightStatus(FlightStatus status) => _repository.Add(status);

        public void UpdateFlightStatus(FlightStatus status) => _repository.Update(status);

        public void DeleteFlightStatus(int id) => _repository.Delete(id);
    }
}