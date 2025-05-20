using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class TicketStatusFacade
    {
        private readonly TicketStatusManager _manager = new();

        public IEnumerable<TicketStatus> GetAllTicketStatuses() => _manager.GetAllTicketStatuses();

        public TicketStatus? GetTicketStatusById(int id) => _manager.GetTicketStatusById(id);

        public void AddTicketStatus(TicketStatus status) => _manager.AddTicketStatus(status);

        public void UpdateTicketStatus(TicketStatus status) => _manager.UpdateTicketStatus(status);

        public void DeleteTicketStatus(int id) => _manager.DeleteTicketStatus(id);
    }
}