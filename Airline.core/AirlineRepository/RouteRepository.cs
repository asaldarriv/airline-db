using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;
using System.Data;

namespace Airline.core.AirlineRepository
{
    public interface IRouteRepository
    {
        IEnumerable<Route> GetAll();
        Route? GetById(int id);
        void Add(Route route);
        void Update(Route route);
        void Delete(int id);
    }

    public class RouteRepository : IRouteRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<Route> GetAll()
        {
            var routes = new List<Route>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT route_id, origin_city_id, destination_city_id FROM ROUTES", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                routes.Add(new Route
                {
                    RouteId = reader.GetInt32("route_id"),
                    OriginCityId = reader.IsDBNull("origin_city_id") ? null : reader.GetInt32("origin_city_id"),
                    DestinationCityId = reader.IsDBNull("destination_city_id") ? null : reader.GetInt32("destination_city_id")
                });
            }
            return routes;
        }

        public Route? GetById(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT route_id, origin_city_id, destination_city_id FROM ROUTES WHERE route_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Route
                {
                    RouteId = reader.GetInt32("route_id"),
                    OriginCityId = reader.IsDBNull("origin_city_id") ? null : reader.GetInt32("origin_city_id"),
                    DestinationCityId = reader.IsDBNull("destination_city_id") ? null : reader.GetInt32("destination_city_id")
                };
            }
            return null;
        }

        public void Add(Route route)
        {
            if (route == null) throw new ArgumentNullException(nameof(route));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "INSERT INTO ROUTES (origin_city_id, destination_city_id) VALUES (@origin, @dest)", connection);
            command.Parameters.AddWithValue("@origin", (object?)route.OriginCityId ?? DBNull.Value);
            command.Parameters.AddWithValue("@dest", (object?)route.DestinationCityId ?? DBNull.Value);
            command.ExecuteNonQuery();
        }

        public void Update(Route route)
        {
            if (route == null) throw new ArgumentNullException(nameof(route));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "UPDATE ROUTES SET origin_city_id = @origin, destination_city_id = @dest WHERE route_id = @id", connection);
            command.Parameters.AddWithValue("@origin", (object?)route.OriginCityId ?? DBNull.Value);
            command.Parameters.AddWithValue("@dest", (object?)route.DestinationCityId ?? DBNull.Value);
            command.Parameters.AddWithValue("@id", route.RouteId);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM ROUTES WHERE route_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}