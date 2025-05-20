using Airline.core.AirlineEntities;
using MySql.Data.MySqlClient;

namespace Airline.core.AirlineRepository
{
    public interface IEmployeeFlightRepository
    {
        IEnumerable<EmployeeFlight> GetAll();
        EmployeeFlight? GetByIds(int employeeId, int flightId);
        void Add(EmployeeFlight employeeFlight);
        void Delete(int employeeId, int flightId);
    }

    public class EmployeeFlightRepository : IEmployeeFlightRepository
    {
        private readonly Connection _connectionManager = new();

        public IEnumerable<EmployeeFlight> GetAll()
        {
            var list = new List<EmployeeFlight>();
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT employee_id, flight_id FROM EMPLOYEES_FLIGHTS", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new EmployeeFlight
                {
                    EmployeeId = reader.GetInt32("employee_id"),
                    FlightId = reader.GetInt32("flight_id")
                });
            }
            return list;
        }

        public EmployeeFlight? GetByIds(int employeeId, int flightId)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("SELECT employee_id, flight_id FROM EMPLOYEES_FLIGHTS WHERE employee_id = @emp AND flight_id = @flight", connection);
            command.Parameters.AddWithValue("@emp", employeeId);
            command.Parameters.AddWithValue("@flight", flightId);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new EmployeeFlight
                {
                    EmployeeId = reader.GetInt32("employee_id"),
                    FlightId = reader.GetInt32("flight_id")
                };
            }
            return null;
        }

        public void Add(EmployeeFlight employeeFlight)
        {
            if (employeeFlight == null) throw new ArgumentNullException(nameof(employeeFlight));
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand(
                "INSERT INTO EMPLOYEES_FLIGHTS (employee_id, flight_id) VALUES (@emp, @flight)", connection);
            command.Parameters.AddWithValue("@emp", employeeFlight.EmployeeId);
            command.Parameters.AddWithValue("@flight", employeeFlight.FlightId);
            command.ExecuteNonQuery();
        }

        public void Delete(int employeeId, int flightId)
        {
            using var connection = _connectionManager.OpenConnection();
            using var command = new MySqlCommand("DELETE FROM EMPLOYEES_FLIGHTS WHERE employee_id = @emp AND flight_id = @flight", connection);
            command.Parameters.AddWithValue("@emp", employeeId);
            command.Parameters.AddWithValue("@flight", flightId);
            command.ExecuteNonQuery();
        }
    }
}