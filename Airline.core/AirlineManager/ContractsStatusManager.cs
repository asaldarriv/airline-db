using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class ContractsStatusManager
    {
        private readonly IContractsStatusRepository _repository;

        public ContractsStatusManager(IContractsStatusRepository? repository = null)
        {
            _repository = repository ?? new ContractsStatusRepository();
        }

        public IEnumerable<ContractsStatus> GetAllContractsStatuses() => _repository.GetAll();

        public ContractsStatus? GetContractsStatusById(int id) => _repository.GetById(id);

        public void AddContractsStatus(ContractsStatus status) => _repository.Add(status);

        public void UpdateContractsStatus(ContractsStatus status) => _repository.Update(status);

        public void DeleteContractsStatus(int id) => _repository.Delete(id);
    }
}