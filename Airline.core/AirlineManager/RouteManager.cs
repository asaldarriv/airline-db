using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class RouteManager
    {
        private readonly IRouteRepository _repository;

        public RouteManager(IRouteRepository? repository = null)
        {
            _repository = repository ?? new RouteRepository();
        }

        public IEnumerable<Route> GetAllRoutes() => _repository.GetAll();

        public Route? GetRouteById(int id) => _repository.GetById(id);

        public void AddRoute(Route route) => _repository.Add(route);

        public void UpdateRoute(Route route) => _repository.Update(route);

        public void DeleteRoute(int id) => _repository.Delete(id);
    }
}