using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class RouteFacade
    {
        private readonly RouteManager _manager = new();

        public IEnumerable<Route> GetAllRoutes() => _manager.GetAllRoutes();

        public Route? GetRouteById(int id) => _manager.GetRouteById(id);

        public void AddRoute(Route route) => _manager.AddRoute(route);

        public void UpdateRoute(Route route) => _manager.UpdateRoute(route);

        public void DeleteRoute(int id) => _manager.DeleteRoute(id);
    }
}