using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class EmployeeFlightFacade
    {
        private readonly EmployeeFlightManager _manager = new();

        public IEnumerable<EmployeeFlight> GetAllEmployeeFlights() => _manager.GetAllEmployeeFlights();

        public EmployeeFlight? GetEmployeeFlightByIds(int employeeId, int flightId) => _manager.GetEmployeeFlightByIds(employeeId, flightId);

        public void AddEmployeeFlight(EmployeeFlight employeeFlight) => _manager.AddEmployeeFlight(employeeFlight);

        public void DeleteEmployeeFlight(int employeeId, int flightId) => _manager.DeleteEmployeeFlight(employeeId, flightId);
    }
}