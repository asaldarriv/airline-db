using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;
using System.Data;

namespace Airline.core.AirlineRepository
{
    public interface ILuggageTypeRepository
    {
        IEnumerable<LuggageType> GetAll();
        LuggageType? GetById(int id);
        void Add(LuggageType luggageType);
        void Update(LuggageType luggageType);
        void Delete(int id);
    }

    public class LuggageTypeRepository : ILuggageTypeRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<LuggageType> GetAll()
        {
            var types = new List<LuggageType>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT luggage_type_id, type_code, name, description, is_active FROM LUGGAGES_TYPES", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                types.Add(new LuggageType
                {
                    LuggageTypeId = reader.GetInt32("luggage_type_id"),
                    TypeCode = reader.GetString("type_code"),
                    Name = reader.GetString("name"),
                    Description = reader.IsDBNull("description") ? null : reader.GetString("description"),
                    IsActive = reader.GetBoolean("is_active")
                });
            }
            return types;
        }

        public LuggageType? GetById(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT luggage_type_id, type_code, name, description, is_active FROM LUGGAGES_TYPES WHERE luggage_type_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new LuggageType
                {
                    LuggageTypeId = reader.GetInt32("luggage_type_id"),
                    TypeCode = reader.GetString("type_code"),
                    Name = reader.GetString("name"),
                    Description = reader.IsDBNull("description") ? null : reader.GetString("description"),
                    IsActive = reader.GetBoolean("is_active")
                };
            }
            return null;
        }

        public void Add(LuggageType luggageType)
        {
            if (luggageType == null) throw new ArgumentNullException(nameof(luggageType));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "INSERT INTO LUGGAGES_TYPES (type_code, name, description, is_active) VALUES (@type_code, @name, @description, @is_active)", connection);
            command.Parameters.AddWithValue("@type_code", luggageType.TypeCode);
            command.Parameters.AddWithValue("@name", luggageType.Name);
            command.Parameters.AddWithValue("@description", (object?)luggageType.Description ?? DBNull.Value);
            command.Parameters.AddWithValue("@is_active", luggageType.IsActive);
            command.ExecuteNonQuery();
        }

        public void Update(LuggageType luggageType)
        {
            if (luggageType == null) throw new ArgumentNullException(nameof(luggageType));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "UPDATE LUGGAGES_TYPES SET type_code = @type_code, name = @name, description = @description, is_active = @is_active WHERE luggage_type_id = @id", connection);
            command.Parameters.AddWithValue("@type_code", luggageType.TypeCode);
            command.Parameters.AddWithValue("@name", luggageType.Name);
            command.Parameters.AddWithValue("@description", (object?)luggageType.Description ?? DBNull.Value);
            command.Parameters.AddWithValue("@is_active", luggageType.IsActive);
            command.Parameters.AddWithValue("@id", luggageType.LuggageTypeId);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM LUGGAGES_TYPES WHERE luggage_type_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}