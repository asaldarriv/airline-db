using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;
using System.Data;

namespace Airline.core.AirlineRepository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User? GetById(int id);
        void Add(User user);
        void Update(User user);
        void Delete(int id);
    }

    public class UserRepository : IUserRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<User> GetAll()
        {
            var users = new List<User>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT * FROM USERS", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new User
                {
                    UserId = reader.GetInt32("user_id"),
                    DocumentTypeId = reader.GetInt32("document_type_id"),
                    CountryId = reader.GetInt32("country_id"),
                    RoleId = reader.GetInt32("role_id"),
                    Email = reader.GetString("email"),
                    FirstName = reader.GetString("first_name"),
                    SecondName = reader.IsDBNull("second_name") ? null : reader.GetString("second_name"),
                    FirstLastName = reader.GetString("first_last_name"),
                    SecondLastName = reader.IsDBNull("second_last_name") ? null : reader.GetString("second_last_name"),
                    PhoneNumber = reader.GetString("phone_number"),
                    Address = reader.GetString("address"),
                    BirthDate = reader.GetDateTime("birth_date"),
                    TrainingInstitution = reader.IsDBNull("training_institution") ? null : reader.GetString("training_institution"),
                    EducationLevel = reader.IsDBNull("education_level") ? null : reader.GetString("education_level"),
                    DegreeTitle = reader.IsDBNull("degree_title") ? null : reader.GetString("degree_title"),
                    ResidenceCountryId = reader.IsDBNull("residence_country_id") ? null : reader.GetInt32("residence_country_id"),
                    BirthCountryId = reader.IsDBNull("birth_country_id") ? null : reader.GetInt32("birth_country_id"),
                    ContractStatusId = reader.IsDBNull("contract_status_id") ? null : reader.GetInt32("contract_status_id"),
                    Username = reader.GetString("username"),
                    PasswordHash = reader.GetString("password_hash"),
                    IsActive = reader.GetBoolean("is_active"),
                    CreatedAt = reader.GetDateTime("created_at")
                });
            }
            return users;
        }

        public User? GetById(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT * FROM USERS WHERE user_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    UserId = reader.GetInt32("user_id"),
                    DocumentTypeId = reader.GetInt32("document_type_id"),
                    CountryId = reader.GetInt32("country_id"),
                    RoleId = reader.GetInt32("role_id"),
                    Email = reader.GetString("email"),
                    FirstName = reader.GetString("first_name"),
                    SecondName = reader.IsDBNull("second_name") ? null : reader.GetString("second_name"),
                    FirstLastName = reader.GetString("first_last_name"),
                    SecondLastName = reader.IsDBNull("second_last_name") ? null : reader.GetString("second_last_name"),
                    PhoneNumber = reader.GetString("phone_number"),
                    Address = reader.GetString("address"),
                    BirthDate = reader.GetDateTime("birth_date"),
                    TrainingInstitution = reader.IsDBNull("training_institution") ? null : reader.GetString("training_institution"),
                    EducationLevel = reader.IsDBNull("education_level") ? null : reader.GetString("education_level"),
                    DegreeTitle = reader.IsDBNull("degree_title") ? null : reader.GetString("degree_title"),
                    ResidenceCountryId = reader.IsDBNull("residence_country_id") ? null : reader.GetInt32("residence_country_id"),
                    BirthCountryId = reader.IsDBNull("birth_country_id") ? null : reader.GetInt32("birth_country_id"),
                    ContractStatusId = reader.IsDBNull("contract_status_id") ? null : reader.GetInt32("contract_status_id"),
                    Username = reader.GetString("username"),
                    PasswordHash = reader.GetString("password_hash"),
                    IsActive = reader.GetBoolean("is_active"),
                    CreatedAt = reader.GetDateTime("created_at")
                };
            }
            return null;
        }

        public void Add(User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                @"INSERT INTO USERS (document_type_id, country_id, role_id, email, first_name, second_name, first_last_name, second_last_name, phone_number, address, birth_date, training_institution, education_level, degree_title, residence_country_id, birth_country_id, contract_status_id, username, password_hash, is_active, created_at)
                  VALUES (@docType, @country, @role, @email, @firstName, @secondName, @firstLastName, @secondLastName, @phone, @address, @birthDate, @training, @education, @degree, @residence, @birthCountry, @contractStatus, @username, @password, @active, @createdAt)", connection);
            command.Parameters.AddWithValue("@docType", user.DocumentTypeId);
            command.Parameters.AddWithValue("@country", user.CountryId);
            command.Parameters.AddWithValue("@role", user.RoleId);
            command.Parameters.AddWithValue("@email", user.Email);
            command.Parameters.AddWithValue("@firstName", user.FirstName);
            command.Parameters.AddWithValue("@secondName", (object?)user.SecondName ?? DBNull.Value);
            command.Parameters.AddWithValue("@firstLastName", user.FirstLastName);
            command.Parameters.AddWithValue("@secondLastName", (object?)user.SecondLastName ?? DBNull.Value);
            command.Parameters.AddWithValue("@phone", user.PhoneNumber);
            command.Parameters.AddWithValue("@address", user.Address);
            command.Parameters.AddWithValue("@birthDate", user.BirthDate);
            command.Parameters.AddWithValue("@training", (object?)user.TrainingInstitution ?? DBNull.Value);
            command.Parameters.AddWithValue("@education", (object?)user.EducationLevel ?? DBNull.Value);
            command.Parameters.AddWithValue("@degree", (object?)user.DegreeTitle ?? DBNull.Value);
            command.Parameters.AddWithValue("@residence", (object?)user.ResidenceCountryId ?? DBNull.Value);
            command.Parameters.AddWithValue("@birthCountry", (object?)user.BirthCountryId ?? DBNull.Value);
            command.Parameters.AddWithValue("@contractStatus", (object?)user.ContractStatusId ?? DBNull.Value);
            command.Parameters.AddWithValue("@username", user.Username);
            command.Parameters.AddWithValue("@password", user.PasswordHash);
            command.Parameters.AddWithValue("@active", user.IsActive);
            command.Parameters.AddWithValue("@createdAt", user.CreatedAt);
            command.ExecuteNonQuery();
        }

        public void Update(User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                @"UPDATE USERS SET document_type_id = @docType, country_id = @country, role_id = @role, email = @email, first_name = @firstName, second_name = @secondName, first_last_name = @firstLastName, second_last_name = @secondLastName, phone_number = @phone, address = @address, birth_date = @birthDate, training_institution = @training, education_level = @education, degree_title = @degree, residence_country_id = @residence, birth_country_id = @birthCountry, contract_status_id = @contractStatus, username = @username, password_hash = @password, is_active = @active WHERE user_id = @id", connection);
            command.Parameters.AddWithValue("@docType", user.DocumentTypeId);
            command.Parameters.AddWithValue("@country", user.CountryId);
            command.Parameters.AddWithValue("@role", user.RoleId);
            command.Parameters.AddWithValue("@email", user.Email);
            command.Parameters.AddWithValue("@firstName", user.FirstName);
            command.Parameters.AddWithValue("@secondName", (object?)user.SecondName ?? DBNull.Value);
            command.Parameters.AddWithValue("@firstLastName", user.FirstLastName);
            command.Parameters.AddWithValue("@secondLastName", (object?)user.SecondLastName ?? DBNull.Value);
            command.Parameters.AddWithValue("@phone", user.PhoneNumber);
            command.Parameters.AddWithValue("@address", user.Address);
            command.Parameters.AddWithValue("@birthDate", user.BirthDate);
            command.Parameters.AddWithValue("@training", (object?)user.TrainingInstitution ?? DBNull.Value);
            command.Parameters.AddWithValue("@education", (object?)user.EducationLevel ?? DBNull.Value);
            command.Parameters.AddWithValue("@degree", (object?)user.DegreeTitle ?? DBNull.Value);
            command.Parameters.AddWithValue("@residence", (object?)user.ResidenceCountryId ?? DBNull.Value);
            command.Parameters.AddWithValue("@birthCountry", (object?)user.BirthCountryId ?? DBNull.Value);
            command.Parameters.AddWithValue("@contractStatus", (object?)user.ContractStatusId ?? DBNull.Value);
            command.Parameters.AddWithValue("@username", user.Username);
            command.Parameters.AddWithValue("@password", user.PasswordHash);
            command.Parameters.AddWithValue("@active", user.IsActive);
            command.Parameters.AddWithValue("@id", user.UserId);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM USERS WHERE user_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}