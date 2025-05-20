using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;

namespace Airline.core.AirlineRepository
{
    /// <summary>
    /// Provides methods to validate user login against the database.
    /// </summary>
    public interface ILoginRepository
    {
        LoginResult ValidateLogin(LoginRequest request);
    }

    public class LoginRepository : ILoginRepository
    {
        private readonly Connection _connectionManager = new();

        /// <summary>
        /// Validates the login credentials against the USERS table.
        /// </summary>
        /// <param name="request">Login request containing username and hashed password.</param>
        /// <returns>LoginResult with validation outcome.</returns>
        public LoginResult ValidateLogin(LoginRequest request)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                @"SELECT user_id, role_id FROM USERS 
                  WHERE username = @username AND password_hash = @passwordHash AND is_active = 1", connection);
            command.Parameters.AddWithValue("@username", request.Username);
            command.Parameters.AddWithValue("@passwordHash", request.Password);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new LoginResult
                {
                    IsValid = true,
                    UserId = reader.GetInt32("user_id"),
                    Role = reader.GetInt32("role_id").ToString()
                };
            }
            return new LoginResult
            {
                IsValid = false,
                ErrorMessage = "Invalid username or password."
            };
        }
    }
}