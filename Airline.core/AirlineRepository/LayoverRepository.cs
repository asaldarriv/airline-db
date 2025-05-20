using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;
using System.Data;

namespace Airline.core.AirlineRepository
{
    public interface ILayoverRepository
    {
        IEnumerable<Layover> GetAll();
        Layover? GetById(int id);
        void Add(Layover layover);
        void Update(Layover layover);
        void Delete(int id);
    }

    public class LayoverRepository : ILayoverRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<Layover> GetAll()
        {
            var layovers = new List<Layover>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT layover_id, route_id, city_id, stop_order, scheduled_arrival_time, scheduled_departure_time, layover_duration FROM LAYOVERS", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                layovers.Add(new Layover
                {
                    LayoverId = reader.GetInt32("layover_id"),
                    RouteId = reader.IsDBNull("route_id") ? null : reader.GetInt32("route_id"),
                    CityId = reader.IsDBNull("city_id") ? null : reader.GetInt32("city_id"),
                    StopOrder = reader.GetInt32("stop_order"),
                    ScheduledArrivalTime = reader.GetDateTime("scheduled_arrival_time"),
                    ScheduledDepartureTime = reader.GetDateTime("scheduled_departure_time"),
                    LayoverDuration = reader.GetTimeSpan("layover_duration")
                });
            }
            return layovers;
        }

        public Layover? GetById(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT layover_id, route_id, city_id, stop_order, scheduled_arrival_time, scheduled_departure_time, layover_duration FROM LAYOVERS WHERE layover_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Layover
                {
                    LayoverId = reader.GetInt32("layover_id"),
                    RouteId = reader.IsDBNull("route_id") ? null : reader.GetInt32("route_id"),
                    CityId = reader.IsDBNull("city_id") ? null : reader.GetInt32("city_id"),
                    StopOrder = reader.GetInt32("stop_order"),
                    ScheduledArrivalTime = reader.GetDateTime("scheduled_arrival_time"),
                    ScheduledDepartureTime = reader.GetDateTime("scheduled_departure_time"),
                    LayoverDuration = reader.GetTimeSpan("layover_duration")
                };
            }
            return null;
        }

        public void Add(Layover layover)
        {
            if (layover == null) throw new ArgumentNullException(nameof(layover));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "INSERT INTO LAYOVERS (route_id, city_id, stop_order, scheduled_arrival_time, scheduled_departure_time, layover_duration) VALUES (@route, @city, @order, @arr, @dep, @duration)", connection);
            command.Parameters.AddWithValue("@route", (object?)layover.RouteId ?? DBNull.Value);
            command.Parameters.AddWithValue("@city", (object?)layover.CityId ?? DBNull.Value);
            command.Parameters.AddWithValue("@order", layover.StopOrder);
            command.Parameters.AddWithValue("@arr", layover.ScheduledArrivalTime);
            command.Parameters.AddWithValue("@dep", layover.ScheduledDepartureTime);
            command.Parameters.AddWithValue("@duration", layover.LayoverDuration);
            command.ExecuteNonQuery();
        }

        public void Update(Layover layover)
        {
            if (layover == null) throw new ArgumentNullException(nameof(layover));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "UPDATE LAYOVERS SET route_id = @route, city_id = @city, stop_order = @order, scheduled_arrival_time = @arr, scheduled_departure_time = @dep, layover_duration = @duration WHERE layover_id = @id", connection);
            command.Parameters.AddWithValue("@route", (object?)layover.RouteId ?? DBNull.Value);
            command.Parameters.AddWithValue("@city", (object?)layover.CityId ?? DBNull.Value);
            command.Parameters.AddWithValue("@order", layover.StopOrder);
            command.Parameters.AddWithValue("@arr", layover.ScheduledArrivalTime);
            command.Parameters.AddWithValue("@dep", layover.ScheduledDepartureTime);
            command.Parameters.AddWithValue("@duration", layover.LayoverDuration);
            command.Parameters.AddWithValue("@id", layover.LayoverId);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM LAYOVERS WHERE layover_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}