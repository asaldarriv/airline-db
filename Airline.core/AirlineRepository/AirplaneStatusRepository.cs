using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;
using System.Data;

namespace Airline.core.AirlineRepository
{
    public interface IAirplaneStatusRepository
    {
        IEnumerable<AirplaneStatus> GetAll();
        AirplaneStatus? GetById(int id);
        void Add(AirplaneStatus status);
        void Update(AirplaneStatus status);
        void Delete(int id);
    }

    public class AirplaneStatusRepository : IAirplaneStatusRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<AirplaneStatus> GetAll()
        {
            var statuses = new List<AirplaneStatus>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT airplane_status_id, status_code, status_name, status_description, is_active FROM AIRPLANES_STATUSES", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                statuses.Add(new AirplaneStatus
                {
                    AirplaneStatusId = reader.GetInt32("airplane_status_id"),
                    StatusCode = reader.GetString("status_code"),
                    StatusName = reader.GetString("status_name"),
                    StatusDescription = reader.IsDBNull("status_description") ? null : reader.GetString("status_description"),
                    IsActive = reader.GetBoolean("is_active")
                });
            }
            return statuses;
        }

        public AirplaneStatus? GetById(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT airplane_status_id, status_code, status_name, status_description, is_active FROM AIRPLANES_STATUSES WHERE airplane_status_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new AirplaneStatus
                {
                    AirplaneStatusId = reader.GetInt32("airplane_status_id"),
                    StatusCode = reader.GetString("status_code"),
                    StatusName = reader.GetString("status_name"),
                    StatusDescription = reader.IsDBNull("status_description") ? null : reader.GetString("status_description"),
                    IsActive = reader.GetBoolean("is_active")
                };
            }
            return null;
        }

        public void Add(AirplaneStatus status)
        {
            if (status == null) throw new ArgumentNullException(nameof(status));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "INSERT INTO AIRPLANES_STATUSES (status_code, status_name, status_description, is_active) VALUES (@code, @name, @desc, @active)", connection);
            command.Parameters.AddWithValue("@code", status.StatusCode);
            command.Parameters.AddWithValue("@name", status.StatusName);
            command.Parameters.AddWithValue("@desc", (object?)status.StatusDescription ?? DBNull.Value);
            command.Parameters.AddWithValue("@active", status.IsActive);
            command.ExecuteNonQuery();
        }

        public void Update(AirplaneStatus status)
        {
            if (status == null) throw new ArgumentNullException(nameof(status));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "UPDATE AIRPLANES_STATUSES SET status_code = @code, status_name = @name, status_description = @desc, is_active = @active WHERE airplane_status_id = @id", connection);
            command.Parameters.AddWithValue("@code", status.StatusCode);
            command.Parameters.AddWithValue("@name", status.StatusName);
            command.Parameters.AddWithValue("@desc", (object?)status.StatusDescription ?? DBNull.Value);
            command.Parameters.AddWithValue("@active", status.IsActive);
            command.Parameters.AddWithValue("@id", status.AirplaneStatusId);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM AIRPLANES_STATUSES WHERE airplane_status_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}