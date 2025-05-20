using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;
using System.Data;

namespace Airline.core.AirlineRepository
{
    public interface IContractsStatusRepository
    {
        IEnumerable<ContractsStatus> GetAll();
        ContractsStatus? GetById(int id);
        void Add(ContractsStatus status);
        void Update(ContractsStatus status);
        void Delete(int id);
    }

    public class ContractsStatusRepository : IContractsStatusRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<ContractsStatus> GetAll()
        {
            var statuses = new List<ContractsStatus>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT contract_status_id, type_code, name, description, is_active FROM CONTRACTS_STATUSES", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                statuses.Add(new ContractsStatus
                {
                    ContractStatusId = reader.GetInt32("contract_status_id"),
                    TypeCode = reader.GetString("type_code"),
                    Name = reader.GetString("name"),
                    Description = reader.IsDBNull("description") ? null : reader.GetString("description"),
                    IsActive = reader.GetBoolean("is_active")
                });
            }
            return statuses;
        }

        public ContractsStatus? GetById(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT contract_status_id, type_code, name, description, is_active FROM CONTRACTS_STATUSES WHERE contract_status_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new ContractsStatus
                {
                    ContractStatusId = reader.GetInt32("contract_status_id"),
                    TypeCode = reader.GetString("type_code"),
                    Name = reader.GetString("name"),
                    Description = reader.IsDBNull("description") ? null : reader.GetString("description"),
                    IsActive = reader.GetBoolean("is_active")
                };
            }
            return null;
        }

        public void Add(ContractsStatus status)
        {
            if (status == null) throw new ArgumentNullException(nameof(status));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "INSERT INTO CONTRACTS_STATUSES (type_code, name, description, is_active) VALUES (@type_code, @name, @description, @is_active)", connection);
            command.Parameters.AddWithValue("@type_code", status.TypeCode);
            command.Parameters.AddWithValue("@name", status.Name);
            command.Parameters.AddWithValue("@description", (object?)status.Description ?? DBNull.Value);
            command.Parameters.AddWithValue("@is_active", status.IsActive);
            command.ExecuteNonQuery();
        }

        public void Update(ContractsStatus status)
        {
            if (status == null) throw new ArgumentNullException(nameof(status));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "UPDATE CONTRACTS_STATUSES SET type_code = @type_code, name = @name, description = @description, is_active = @is_active WHERE contract_status_id = @id", connection);
            command.Parameters.AddWithValue("@type_code", status.TypeCode);
            command.Parameters.AddWithValue("@name", status.Name);
            command.Parameters.AddWithValue("@description", (object?)status.Description ?? DBNull.Value);
            command.Parameters.AddWithValue("@is_active", status.IsActive);
            command.Parameters.AddWithValue("@id", status.ContractStatusId);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM CONTRACTS_STATUSES WHERE contract_status_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}