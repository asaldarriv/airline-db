using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class CityFacade
    {
        private readonly CityManager _manager = new();

        public IEnumerable<City> GetAllCities() => _manager.GetAllCities();

        public City? GetCityById(int id) => _manager.GetCityById(id);

        public void AddCity(City city) => _manager.AddCity(city);

        public void UpdateCity(City city) => _manager.UpdateCity(city);

        public void DeleteCity(int id) => _manager.DeleteCity(id);
    }
}