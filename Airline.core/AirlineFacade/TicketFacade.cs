using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class TicketFacade
    {
        private readonly TicketManager _manager = new();

        public IEnumerable<Ticket> GetAllTickets() => _manager.GetAllTickets();

        public Ticket? GetTicketById(int id) => _manager.GetTicketById(id);

        public void AddTicket(Ticket ticket) => _manager.AddTicket(ticket);

        public void UpdateTicket(Ticket ticket) => _manager.UpdateTicket(ticket);

        public void DeleteTicket(int id) => _manager.DeleteTicket(id);
    }
}