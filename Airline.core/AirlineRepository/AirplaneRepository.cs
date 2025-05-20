using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;
using System.Data;

namespace Airline.core.AirlineRepository
{
    public interface IAirplaneRepository
    {
        IEnumerable<Airplane> GetAll();
        Airplane? GetById(string registrationNumber);
        void Add(Airplane airplane);
        void Update(Airplane airplane);
        void Delete(string registrationNumber);
    }

    public class AirplaneRepository : IAirplaneRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<Airplane> GetAll()
        {
            var airplanes = new List<Airplane>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT registration_number, airplane_status_id, passenger_capacity, manufacturer, model, acquisition_date FROM AIRPLANES", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                airplanes.Add(new Airplane
                {
                    RegistrationNumber = reader.GetString("registration_number"),
                    AirplaneStatusId = reader.IsDBNull("airplane_status_id") ? null : reader.GetInt32("airplane_status_id"),
                    PassengerCapacity = reader.GetInt32("passenger_capacity"),
                    Manufacturer = reader.GetString("manufacturer"),
                    Model = reader.GetString("model"),
                    AcquisitionDate = reader.GetDateTime("acquisition_date")
                });
            }
            return airplanes;
        }

        public Airplane? GetById(string registrationNumber)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT registration_number, airplane_status_id, passenger_capacity, manufacturer, model, acquisition_date FROM AIRPLANES WHERE registration_number = @reg", connection);
            command.Parameters.AddWithValue("@reg", registrationNumber);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Airplane
                {
                    RegistrationNumber = reader.GetString("registration_number"),
                    AirplaneStatusId = reader.IsDBNull("airplane_status_id") ? null : reader.GetInt32("airplane_status_id"),
                    PassengerCapacity = reader.GetInt32("passenger_capacity"),
                    Manufacturer = reader.GetString("manufacturer"),
                    Model = reader.GetString("model"),
                    AcquisitionDate = reader.GetDateTime("acquisition_date")
                };
            }
            return null;
        }

        public void Add(Airplane airplane)
        {
            if (airplane == null) throw new ArgumentNullException(nameof(airplane));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "INSERT INTO AIRPLANES (registration_number, airplane_status_id, passenger_capacity, manufacturer, model, acquisition_date) VALUES (@reg, @status, @capacity, @man, @model, @date)", connection);
            command.Parameters.AddWithValue("@reg", airplane.RegistrationNumber);
            command.Parameters.AddWithValue("@status", (object?)airplane.AirplaneStatusId ?? DBNull.Value);
            command.Parameters.AddWithValue("@capacity", airplane.PassengerCapacity);
            command.Parameters.AddWithValue("@man", airplane.Manufacturer);
            command.Parameters.AddWithValue("@model", airplane.Model);
            command.Parameters.AddWithValue("@date", airplane.AcquisitionDate);
            command.ExecuteNonQuery();
        }

        public void Update(Airplane airplane)
        {
            if (airplane == null) throw new ArgumentNullException(nameof(airplane));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "UPDATE AIRPLANES SET airplane_status_id = @status, passenger_capacity = @capacity, manufacturer = @man, model = @model, acquisition_date = @date WHERE registration_number = @reg", connection);
            command.Parameters.AddWithValue("@reg", airplane.RegistrationNumber);
            command.Parameters.AddWithValue("@status", (object?)airplane.AirplaneStatusId ?? DBNull.Value);
            command.Parameters.AddWithValue("@capacity", airplane.PassengerCapacity);
            command.Parameters.AddWithValue("@man", airplane.Manufacturer);
            command.Parameters.AddWithValue("@model", airplane.Model);
            command.Parameters.AddWithValue("@date", airplane.AcquisitionDate);
            command.ExecuteNonQuery();
        }

        public void Delete(string registrationNumber)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM AIRPLANES WHERE registration_number = @reg", connection);
            command.Parameters.AddWithValue("@reg", registrationNumber);
            command.ExecuteNonQuery();
        }
    }
}