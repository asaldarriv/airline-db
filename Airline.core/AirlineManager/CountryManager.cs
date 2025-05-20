using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class CountryManager
    {
        private readonly ICountryRepository _repository;

        public CountryManager(ICountryRepository? repository = null)
        {
            _repository = repository ?? new CountryRepository();
        }

        public IEnumerable<Country> GetAllCountries() => _repository.GetAll();

        public Country? GetCountryById(int id) => _repository.GetById(id);

        public void AddCountry(Country country) => _repository.Add(country);

        public void UpdateCountry(Country country) => _repository.Update(country);

        public void DeleteCountry(int id) => _repository.Delete(id);
    }
}