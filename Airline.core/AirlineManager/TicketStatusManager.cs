using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class TicketStatusManager
    {
        private readonly ITicketStatusRepository _repository;

        public TicketStatusManager(ITicketStatusRepository? repository = null)
        {
            _repository = repository ?? new TicketStatusRepository();
        }

        public IEnumerable<TicketStatus> GetAllTicketStatuses() => _repository.GetAll();

        public TicketStatus? GetTicketStatusById(int id) => _repository.GetById(id);

        public void AddTicketStatus(TicketStatus status) => _repository.Add(status);

        public void UpdateTicketStatus(TicketStatus status) => _repository.Update(status);

        public void DeleteTicketStatus(int id) => _repository.Delete(id);
    }
}