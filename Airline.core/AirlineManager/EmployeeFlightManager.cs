using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class EmployeeFlightManager
    {
        private readonly IEmployeeFlightRepository _repository;

        public EmployeeFlightManager(IEmployeeFlightRepository? repository = null)
        {
            _repository = repository ?? new EmployeeFlightRepository();
        }

        public IEnumerable<EmployeeFlight> GetAllEmployeeFlights() => _repository.GetAll();

        public EmployeeFlight? GetEmployeeFlightByIds(int employeeId, int flightId) => _repository.GetByIds(employeeId, flightId);

        public void AddEmployeeFlight(EmployeeFlight employeeFlight) => _repository.Add(employeeFlight);

        public void DeleteEmployeeFlight(int employeeId, int flightId) => _repository.Delete(employeeId, flightId);
    }
}