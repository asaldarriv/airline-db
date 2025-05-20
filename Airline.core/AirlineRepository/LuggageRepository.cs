using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;

namespace Airline.core.AirlineRepository
{
    public interface ILuggageRepository
    {
        IEnumerable<Luggage> GetAll();
        Luggage? GetById(int id);
        void Add(Luggage luggage);
        void Update(Luggage luggage);
        void Delete(int id);
    }

    public class LuggageRepository : ILuggageRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<Luggage> GetAll()
        {
            var luggages = new List<Luggage>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT luggage_id, ticket_id, luggage_type_id, quantity FROM LUGGAGES", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                luggages.Add(new Luggage
                {
                    LuggageId = reader.GetInt32("luggage_id"),
                    TicketId = reader.GetInt32("ticket_id"),
                    LuggageTypeId = reader.GetInt32("luggage_type_id"),
                    Quantity = reader.GetInt32("quantity")
                });
            }
            return luggages;
        }

        public Luggage? GetById(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT luggage_id, ticket_id, luggage_type_id, quantity FROM LUGGAGES WHERE luggage_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Luggage
                {
                    LuggageId = reader.GetInt32("luggage_id"),
                    TicketId = reader.GetInt32("ticket_id"),
                    LuggageTypeId = reader.GetInt32("luggage_type_id"),
                    Quantity = reader.GetInt32("quantity")
                };
            }
            return null;
        }

        public void Add(Luggage luggage)
        {
            if (luggage == null) throw new ArgumentNullException(nameof(luggage));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "INSERT INTO LUGGAGES (ticket_id, luggage_type_id, quantity) VALUES (@ticket_id, @luggage_type_id, @quantity)", connection);
            command.Parameters.AddWithValue("@ticket_id", luggage.TicketId);
            command.Parameters.AddWithValue("@luggage_type_id", luggage.LuggageTypeId);
            command.Parameters.AddWithValue("@quantity", luggage.Quantity);
            command.ExecuteNonQuery();
        }

        public void Update(Luggage luggage)
        {
            if (luggage == null) throw new ArgumentNullException(nameof(luggage));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "UPDATE LUGGAGES SET ticket_id = @ticket_id, luggage_type_id = @luggage_type_id, quantity = @quantity WHERE luggage_id = @id", connection);
            command.Parameters.AddWithValue("@ticket_id", luggage.TicketId);
            command.Parameters.AddWithValue("@luggage_type_id", luggage.LuggageTypeId);
            command.Parameters.AddWithValue("@quantity", luggage.Quantity);
            command.Parameters.AddWithValue("@id", luggage.LuggageId);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM LUGGAGES WHERE luggage_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}