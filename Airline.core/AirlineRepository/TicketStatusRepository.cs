using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;
using System.Data;

namespace Airline.core.AirlineRepository
{
    public interface ITicketStatusRepository
    {
        IEnumerable<TicketStatus> GetAll();
        TicketStatus? GetById(int id);
        void Add(TicketStatus status);
        void Update(TicketStatus status);
        void Delete(int id);
    }

    public class TicketStatusRepository : ITicketStatusRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<TicketStatus> GetAll()
        {
            var statuses = new List<TicketStatus>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT ticket_status_id, status_code, status_name, status_description, is_active FROM TICKET_STATUSES", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                statuses.Add(new TicketStatus
                {
                    TicketStatusId = reader.GetInt32("ticket_status_id"),
                    StatusCode = reader.GetString("status_code"),
                    StatusName = reader.GetString("status_name"),
                    StatusDescription = reader.IsDBNull("status_description") ? null : reader.GetString("status_description"),
                    IsActive = reader.GetBoolean("is_active")
                });
            }
            return statuses;
        }

        public TicketStatus? GetById(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT ticket_status_id, status_code, status_name, status_description, is_active FROM TICKET_STATUSES WHERE ticket_status_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new TicketStatus
                {
                    TicketStatusId = reader.GetInt32("ticket_status_id"),
                    StatusCode = reader.GetString("status_code"),
                    StatusName = reader.GetString("status_name"),
                    StatusDescription = reader.IsDBNull("status_description") ? null : reader.GetString("status_description"),
                    IsActive = reader.GetBoolean("is_active")
                };
            }
            return null;
        }

        public void Add(TicketStatus status)
        {
            if (status == null) throw new ArgumentNullException(nameof(status));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "INSERT INTO TICKET_STATUSES (status_code, status_name, status_description, is_active) VALUES (@code, @name, @desc, @active)", connection);
            command.Parameters.AddWithValue("@code", status.StatusCode);
            command.Parameters.AddWithValue("@name", status.StatusName);
            command.Parameters.AddWithValue("@desc", (object?)status.StatusDescription ?? DBNull.Value);
            command.Parameters.AddWithValue("@active", status.IsActive);
            command.ExecuteNonQuery();
        }

        public void Update(TicketStatus status)
        {
            if (status == null) throw new ArgumentNullException(nameof(status));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "UPDATE TICKET_STATUSES SET status_code = @code, status_name = @name, status_description = @desc, is_active = @active WHERE ticket_status_id = @id", connection);
            command.Parameters.AddWithValue("@code", status.StatusCode);
            command.Parameters.AddWithValue("@name", status.StatusName);
            command.Parameters.AddWithValue("@desc", (object?)status.StatusDescription ?? DBNull.Value);
            command.Parameters.AddWithValue("@active", status.IsActive);
            command.Parameters.AddWithValue("@id", status.TicketStatusId);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM TICKET_STATUSES WHERE ticket_status_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}