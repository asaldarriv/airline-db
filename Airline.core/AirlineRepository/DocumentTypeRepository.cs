using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;
using System.Data;

namespace Airline.core.AirlineRepository
{
    public interface IDocumentTypeRepository
    {
        IEnumerable<DocumentType> GetAll();
        DocumentType? GetById(int id);
        void Add(DocumentType documentType);
        void Update(DocumentType documentType);
        void Delete(int id);
    }

    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<DocumentType> GetAll()
        {
            var types = new List<DocumentType>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT document_type_id, type_code, name, description, is_active FROM DOCUMENT_TYPES", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                types.Add(new DocumentType
                {
                    DocumentTypeId = reader.GetInt32("document_type_id"),
                    TypeCode = reader.GetString("type_code"),
                    Name = reader.GetString("name"),
                    Description = reader.IsDBNull("description") ? null : reader.GetString("description"),
                    IsActive = reader.GetBoolean("is_active")
                });
            }
            return types;
        }

        public DocumentType? GetById(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT document_type_id, type_code, name, description, is_active FROM DOCUMENT_TYPES WHERE document_type_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new DocumentType
                {
                    DocumentTypeId = reader.GetInt32("document_type_id"),
                    TypeCode = reader.GetString("type_code"),
                    Name = reader.GetString("name"),
                    Description = reader.IsDBNull("description") ? null : reader.GetString("description"),
                    IsActive = reader.GetBoolean("is_active")
                };
            }
            return null;
        }

        public void Add(DocumentType documentType)
        {
            if (documentType == null) throw new ArgumentNullException(nameof(documentType));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "INSERT INTO DOCUMENT_TYPES (type_code, name, description, is_active) VALUES (@type_code, @name, @description, @is_active)", connection);
            command.Parameters.AddWithValue("@type_code", documentType.TypeCode);
            command.Parameters.AddWithValue("@name", documentType.Name);
            command.Parameters.AddWithValue("@description", (object?)documentType.Description ?? DBNull.Value);
            command.Parameters.AddWithValue("@is_active", documentType.IsActive);
            command.ExecuteNonQuery();
        }

        public void Update(DocumentType documentType)
        {
            if (documentType == null) throw new ArgumentNullException(nameof(documentType));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "UPDATE DOCUMENT_TYPES SET type_code = @type_code, name = @name, description = @description, is_active = @is_active WHERE document_type_id = @id", connection);
            command.Parameters.AddWithValue("@type_code", documentType.TypeCode);
            command.Parameters.AddWithValue("@name", documentType.Name);
            command.Parameters.AddWithValue("@description", (object?)documentType.Description ?? DBNull.Value);
            command.Parameters.AddWithValue("@is_active", documentType.IsActive);
            command.Parameters.AddWithValue("@id", documentType.DocumentTypeId);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM DOCUMENT_TYPES WHERE document_type_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}