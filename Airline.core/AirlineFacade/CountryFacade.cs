using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class CountryFacade
    {
        private readonly CountryManager _manager = new();

        public IEnumerable<Country> GetAllCountries() => _manager.GetAllCountries();

        public Country? GetCountryById(int id) => _manager.GetCountryById(id);

        public void AddCountry(Country country) => _manager.AddCountry(country);

        public void UpdateCountry(Country country) => _manager.UpdateCountry(country);

        public void DeleteCountry(int id) => _manager.DeleteCountry(id);
    }
}