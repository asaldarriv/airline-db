using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;
using System.Data;

namespace Airline.core.AirlineRepository
{
    public interface IRoleRepository
    {
        IEnumerable<Role> GetAll();
        Role? GetById(int id);
        void Add(Role role);
        void Update(Role role);
        void Delete(int id);
    }

    public class RoleRepository : IRoleRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<Role> GetAll()
        {
            var roles = new List<Role>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT role_id, code, name, description FROM ROLES", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                roles.Add(new Role
                {
                    RoleId = reader.GetInt32("role_id"),
                    Code = reader.GetString("code"),
                    Name = reader.GetString("name"),
                    Description = reader.IsDBNull("description") ? null : reader.GetString("description")
                });
            }
            return roles;
        }

        public Role? GetById(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT role_id, code, name, description FROM ROLES WHERE role_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Role
                {
                    RoleId = reader.GetInt32("role_id"),
                    Code = reader.GetString("code"),
                    Name = reader.GetString("name"),
                    Description = reader.IsDBNull("description") ? null : reader.GetString("description")
                };
            }
            return null;
        }

        public void Add(Role role)
        {
            if (role == null) throw new ArgumentNullException(nameof(role));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "INSERT INTO ROLES (code, name, description) VALUES (@code, @name, @description)", connection);
            command.Parameters.AddWithValue("@code", role.Code);
            command.Parameters.AddWithValue("@name", role.Name);
            command.Parameters.AddWithValue("@description", (object?)role.Description ?? DBNull.Value);
            command.ExecuteNonQuery();
        }

        public void Update(Role role)
        {
            if (role == null) throw new ArgumentNullException(nameof(role));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "UPDATE ROLES SET code = @code, name = @name, description = @description WHERE role_id = @id", connection);
            command.Parameters.AddWithValue("@code", role.Code);
            command.Parameters.AddWithValue("@name", role.Name);
            command.Parameters.AddWithValue("@description", (object?)role.Description ?? DBNull.Value);
            command.Parameters.AddWithValue("@id", role.RoleId);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM ROLES WHERE role_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}