using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class ContractsStatusFacade
    {
        private readonly ContractsStatusManager _manager = new();

        public IEnumerable<ContractsStatus> GetAllContractsStatuses() => _manager.GetAllContractsStatuses();

        public ContractsStatus? GetContractsStatusById(int id) => _manager.GetContractsStatusById(id);

        public void AddContractsStatus(ContractsStatus status) => _manager.AddContractsStatus(status);

        public void UpdateContractsStatus(ContractsStatus status) => _manager.UpdateContractsStatus(status);

        public void DeleteContractsStatus(int id) => _manager.DeleteContractsStatus(id);
    }
}