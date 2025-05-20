using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class CityManager
    {
        private readonly ICityRepository _repository;

        public CityManager(ICityRepository? repository = null)
        {
            _repository = repository ?? new CityRepository();
        }

        public IEnumerable<City> GetAllCities() => _repository.GetAll();

        public City? GetCityById(int id) => _repository.GetById(id);

        public void AddCity(City city) => _repository.Add(city);

        public void UpdateCity(City city) => _repository.Update(city);

        public void DeleteCity(int id) => _repository.Delete(id);
    }
}