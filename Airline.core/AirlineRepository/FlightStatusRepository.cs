using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;
using System.Data;

namespace Airline.core.AirlineRepository
{
    public interface IFlightStatusRepository
    {
        IEnumerable<FlightStatus> GetAll();
        FlightStatus? GetById(int id);
        void Add(FlightStatus status);
        void Update(FlightStatus status);
        void Delete(int id);
    }

    public class FlightStatusRepository : IFlightStatusRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<FlightStatus> GetAll()
        {
            var statuses = new List<FlightStatus>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT flight_status_id, status_code, status_name, status_description, is_active FROM FLIGHT_STATUSES", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                statuses.Add(new FlightStatus
                {
                    FlightStatusId = reader.GetInt32("flight_status_id"),
                    StatusCode = reader.GetString("status_code"),
                    StatusName = reader.GetString("status_name"),
                    StatusDescription = reader.IsDBNull("status_description") ? null : reader.GetString("status_description"),
                    IsActive = reader.GetBoolean("is_active")
                });
            }
            return statuses;
        }

        public FlightStatus? GetById(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT flight_status_id, status_code, status_name, status_description, is_active FROM FLIGHT_STATUSES WHERE flight_status_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new FlightStatus
                {
                    FlightStatusId = reader.GetInt32("flight_status_id"),
                    StatusCode = reader.GetString("status_code"),
                    StatusName = reader.GetString("status_name"),
                    StatusDescription = reader.IsDBNull("status_description") ? null : reader.GetString("status_description"),
                    IsActive = reader.GetBoolean("is_active")
                };
            }
            return null;
        }

        public void Add(FlightStatus status)
        {
            if (status == null) throw new ArgumentNullException(nameof(status));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "INSERT INTO FLIGHT_STATUSES (status_code, status_name, status_description, is_active) VALUES (@code, @name, @desc, @active)", connection);
            command.Parameters.AddWithValue("@code", status.StatusCode);
            command.Parameters.AddWithValue("@name", status.StatusName);
            command.Parameters.AddWithValue("@desc", (object?)status.StatusDescription ?? DBNull.Value);
            command.Parameters.AddWithValue("@active", status.IsActive);
            command.ExecuteNonQuery();
        }

        public void Update(FlightStatus status)
        {
            if (status == null) throw new ArgumentNullException(nameof(status));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "UPDATE FLIGHT_STATUSES SET status_code = @code, status_name = @name, status_description = @desc, is_active = @active WHERE flight_status_id = @id", connection);
            command.Parameters.AddWithValue("@code", status.StatusCode);
            command.Parameters.AddWithValue("@name", status.StatusName);
            command.Parameters.AddWithValue("@desc", (object?)status.StatusDescription ?? DBNull.Value);
            command.Parameters.AddWithValue("@active", status.IsActive);
            command.Parameters.AddWithValue("@id", status.FlightStatusId);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM FLIGHT_STATUSES WHERE flight_status_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}