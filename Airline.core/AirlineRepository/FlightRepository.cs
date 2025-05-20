using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;
using System.Data;

namespace Airline.core.AirlineRepository
{
    public interface IFlightRepository
    {
        IEnumerable<Flight> GetAll();
        Flight? GetById(int id);
        void Add(Flight flight);
        void Update(Flight flight);
        void Delete(int id);
    }

    public class FlightRepository : IFlightRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<Flight> GetAll()
        {
            var flights = new List<Flight>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT flight_id, airplane_id, route_id, flight_status_id, departure_time, arrival_time FROM FLIGHTS", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                flights.Add(new Flight
                {
                    FlightId = reader.GetInt32("flight_id"),
                    AirplaneId = reader.IsDBNull("airplane_id") ? null : reader.GetString("airplane_id"),
                    RouteId = reader.IsDBNull("route_id") ? null : reader.GetInt32("route_id"),
                    FlightStatusId = reader.IsDBNull("flight_status_id") ? null : reader.GetInt32("flight_status_id"),
                    DepartureTime = reader.GetDateTime("departure_time"),
                    ArrivalTime = reader.GetDateTime("arrival_time")
                });
            }
            return flights;
        }

        public Flight? GetById(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT flight_id, airplane_id, route_id, flight_status_id, departure_time, arrival_time FROM FLIGHTS WHERE flight_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Flight
                {
                    FlightId = reader.GetInt32("flight_id"),
                    AirplaneId = reader.IsDBNull("airplane_id") ? null : reader.GetString("airplane_id"),
                    RouteId = reader.IsDBNull("route_id") ? null : reader.GetInt32("route_id"),
                    FlightStatusId = reader.IsDBNull("flight_status_id") ? null : reader.GetInt32("flight_status_id"),
                    DepartureTime = reader.GetDateTime("departure_time"),
                    ArrivalTime = reader.GetDateTime("arrival_time")
                };
            }
            return null;
        }

        public void Add(Flight flight)
        {
            if (flight == null) throw new ArgumentNullException(nameof(flight));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "INSERT INTO FLIGHTS (airplane_id, route_id, flight_status_id, departure_time, arrival_time) VALUES (@airplane, @route, @status, @departure, @arrival)", connection);
            command.Parameters.AddWithValue("@airplane", (object?)flight.AirplaneId ?? DBNull.Value);
            command.Parameters.AddWithValue("@route", (object?)flight.RouteId ?? DBNull.Value);
            command.Parameters.AddWithValue("@status", (object?)flight.FlightStatusId ?? DBNull.Value);
            command.Parameters.AddWithValue("@departure", flight.DepartureTime);
            command.Parameters.AddWithValue("@arrival", flight.ArrivalTime);
            command.ExecuteNonQuery();
        }

        public void Update(Flight flight)
        {
            if (flight == null) throw new ArgumentNullException(nameof(flight));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "UPDATE FLIGHTS SET airplane_id = @airplane, route_id = @route, flight_status_id = @status, departure_time = @departure, arrival_time = @arrival WHERE flight_id = @id", connection);
            command.Parameters.AddWithValue("@airplane", (object?)flight.AirplaneId ?? DBNull.Value);
            command.Parameters.AddWithValue("@route", (object?)flight.RouteId ?? DBNull.Value);
            command.Parameters.AddWithValue("@status", (object?)flight.FlightStatusId ?? DBNull.Value);
            command.Parameters.AddWithValue("@departure", flight.DepartureTime);
            command.Parameters.AddWithValue("@arrival", flight.ArrivalTime);
            command.Parameters.AddWithValue("@id", flight.FlightId);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM FLIGHTS WHERE flight_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}