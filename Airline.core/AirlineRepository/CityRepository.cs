using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;

namespace Airline.core.AirlineRepository
{
    public interface ICityRepository
    {
        IEnumerable<City> GetAll();
        City? GetById(int id);
        void Add(City city);
        void Update(City city);
        void Delete(int id);
    }

    public class CityRepository : ICityRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<City> GetAll()
        {
            var cities = new List<City>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT city_id, name, is_active FROM CITIES", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                cities.Add(new City
                {
                    CityId = reader.GetInt32("city_id"),
                    Name = reader.GetString("name"),
                    IsActive = reader.GetBoolean("is_active")
                });
            }
            return cities;
        }

        public City? GetById(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT city_id, name, is_active FROM CITIES WHERE city_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new City
                {
                    CityId = reader.GetInt32("city_id"),
                    Name = reader.GetString("name"),
                    IsActive = reader.GetBoolean("is_active")
                };
            }
            return null;
        }

        public void Add(City city)
        {
            if (city == null) throw new ArgumentNullException(nameof(city));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "INSERT INTO CITIES (name, is_active) VALUES (@name, @active)", connection);
            command.Parameters.AddWithValue("@name", city.Name);
            command.Parameters.AddWithValue("@active", city.IsActive);
            command.ExecuteNonQuery();
        }

        public void Update(City city)
        {
            if (city == null) throw new ArgumentNullException(nameof(city));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "UPDATE CITIES SET name = @name, is_active = @active WHERE city_id = @id", connection);
            command.Parameters.AddWithValue("@name", city.Name);
            command.Parameters.AddWithValue("@active", city.IsActive);
            command.Parameters.AddWithValue("@id", city.CityId);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM CITIES WHERE city_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}