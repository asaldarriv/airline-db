using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Flight> GetAvailableFlights(int originCityId, int destinationCityId, DateTime date)
        {
            var routeRepo = new RouteRepository();
            var allRoutes = routeRepo.GetAll()
                .Where(r => r.OriginCityId == originCityId && r.DestinationCityId == destinationCityId)
                .Select(r => r.RouteId)
                .ToHashSet();

            return _repository.GetAll()
                .Where(f =>
                    f.DepartureTime.Date == date.Date &&
                    f.FlightStatusId == 1 && // 1 = SCHEDULED
                    f.RouteId.HasValue &&
                    allRoutes.Contains(f.RouteId.Value)
                );
        }
    }
}