using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;

namespace Airline.core.AirlineRepository
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAll();
        Country? GetById(int id);
        void Add(Country country);
        void Update(Country country);
        void Delete(int id);
    }

    public class CountryRepository : ICountryRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<Country> GetAll()
        {
            var countries = new List<Country>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT country_id, iso_code, name, is_active FROM COUNTRIES", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                countries.Add(new Country
                {
                    CountryId = reader.GetInt32("country_id"),
                    IsoCode = reader.GetString("iso_code"),
                    Name = reader.GetString("name"),
                    IsActive = reader.GetBoolean("is_active")
                });
            }
            return countries;
        }

        public Country? GetById(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT country_id, iso_code, name, is_active FROM COUNTRIES WHERE country_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Country
                {
                    CountryId = reader.GetInt32("country_id"),
                    IsoCode = reader.GetString("iso_code"),
                    Name = reader.GetString("name"),
                    IsActive = reader.GetBoolean("is_active")
                };
            }
            return null;
        }

        public void Add(Country country)
        {
            if (country == null) throw new ArgumentNullException(nameof(country));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "INSERT INTO COUNTRIES (iso_code, name, is_active) VALUES (@iso, @name, @active)", connection);
            command.Parameters.AddWithValue("@iso", country.IsoCode);
            command.Parameters.AddWithValue("@name", country.Name);
            command.Parameters.AddWithValue("@active", country.IsActive);
            command.ExecuteNonQuery();
        }

        public void Update(Country country)
        {
            if (country == null) throw new ArgumentNullException(nameof(country));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "UPDATE COUNTRIES SET iso_code = @iso, name = @name, is_active = @active WHERE country_id = @id", connection);
            command.Parameters.AddWithValue("@iso", country.IsoCode);
            command.Parameters.AddWithValue("@name", country.Name);
            command.Parameters.AddWithValue("@active", country.IsActive);
            command.Parameters.AddWithValue("@id", country.CountryId);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM COUNTRIES WHERE country_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}