using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;
using System.Data;

namespace Airline.core.AirlineRepository
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetAll();
        Ticket? GetById(int id);
        void Add(Ticket ticket);
        void Update(Ticket ticket);
        void Delete(int id);
    }

    public class TicketRepository : ITicketRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<Ticket> GetAll()
        {
            var tickets = new List<Ticket>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT ticket_id, customer_id, flight_id, ticket_status_id, price, assigned_seat, sale_date FROM TICKETS", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                tickets.Add(new Ticket
                {
                    TicketId = reader.GetInt32("ticket_id"),
                    CustomerId = reader.IsDBNull("customer_id") ? null : reader.GetInt32("customer_id"),
                    FlightId = reader.IsDBNull("flight_id") ? null : reader.GetInt32("flight_id"),
                    TicketStatusId = reader.IsDBNull("ticket_status_id") ? null : reader.GetInt32("ticket_status_id"),
                    Price = reader.GetDecimal("price"),
                    AssignedSeat = reader.GetString("assigned_seat"),
                    SaleDate = reader.GetDateTime("sale_date")
                });
            }
            return tickets;
        }

        public Ticket? GetById(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT ticket_id, customer_id, flight_id, ticket_status_id, price, assigned_seat, sale_date FROM TICKETS WHERE ticket_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Ticket
                {
                    TicketId = reader.GetInt32("ticket_id"),
                    CustomerId = reader.IsDBNull("customer_id") ? null : reader.GetInt32("customer_id"),
                    FlightId = reader.IsDBNull("flight_id") ? null : reader.GetInt32("flight_id"),
                    TicketStatusId = reader.IsDBNull("ticket_status_id") ? null : reader.GetInt32("ticket_status_id"),
                    Price = reader.GetDecimal("price"),
                    AssignedSeat = reader.GetString("assigned_seat"),
                    SaleDate = reader.GetDateTime("sale_date")
                };
            }
            return null;
        }

        public void Add(Ticket ticket)
        {
            if (ticket == null) throw new ArgumentNullException(nameof(ticket));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "INSERT INTO TICKETS (customer_id, flight_id, ticket_status_id, price, assigned_seat, sale_date) VALUES (@customer, @flight, @status, @price, @seat, @sale_date)", connection);
            command.Parameters.AddWithValue("@customer", (object?)ticket.CustomerId ?? DBNull.Value);
            command.Parameters.AddWithValue("@flight", (object?)ticket.FlightId ?? DBNull.Value);
            command.Parameters.AddWithValue("@status", (object?)ticket.TicketStatusId ?? DBNull.Value);
            command.Parameters.AddWithValue("@price", ticket.Price);
            command.Parameters.AddWithValue("@seat", ticket.AssignedSeat);
            command.Parameters.AddWithValue("@sale_date", ticket.SaleDate);
            command.ExecuteNonQuery();
        }

        public void Update(Ticket ticket)
        {
            if (ticket == null) throw new ArgumentNullException(nameof(ticket));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "UPDATE TICKETS SET customer_id = @customer, flight_id = @flight, ticket_status_id = @status, price = @price, assigned_seat = @seat, sale_date = @sale_date WHERE ticket_id = @id", connection);
            command.Parameters.AddWithValue("@customer", (object?)ticket.CustomerId ?? DBNull.Value);
            command.Parameters.AddWithValue("@flight", (object?)ticket.FlightId ?? DBNull.Value);
            command.Parameters.AddWithValue("@status", (object?)ticket.TicketStatusId ?? DBNull.Value);
            command.Parameters.AddWithValue("@price", ticket.Price);
            command.Parameters.AddWithValue("@seat", ticket.AssignedSeat);
            command.Parameters.AddWithValue("@sale_date", ticket.SaleDate);
            command.Parameters.AddWithValue("@id", ticket.TicketId);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM TICKETS WHERE ticket_id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}