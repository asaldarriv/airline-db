using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class FlightManager
    {
        private readonly IFlightRepository _repository;

        public FlightManager(IFlightRepository? repository = null)
        {
            _repository = repository ?? new FlightRepository();
        }

        public IEnumerable<Flight> GetAllFlights() => _repository.GetAll();

        public Flight? GetFlightById(int id) => _repository.GetById(id);

        public void AddFlight(Flight flight) => _repository.Add(flight);

        public void UpdateFlight(Flight flight) => _repository.Update(flight);

        public void DeleteFlight(int id) => _repository.Delete(id);
    }
}