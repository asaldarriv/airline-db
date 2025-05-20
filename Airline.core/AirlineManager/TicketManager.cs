using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class TicketManager
    {
        private readonly ITicketRepository _repository;

        public TicketManager(ITicketRepository? repository = null)
        {
            _repository = repository ?? new TicketRepository();
        }

        public IEnumerable<Ticket> GetAllTickets() => _repository.GetAll();

        public Ticket? GetTicketById(int id) => _repository.GetById(id);

        public void AddTicket(Ticket ticket) => _repository.Add(ticket);

        public void UpdateTicket(Ticket ticket) => _repository.Update(ticket);

        public void DeleteTicket(int id) => _repository.Delete(id);
    }
}