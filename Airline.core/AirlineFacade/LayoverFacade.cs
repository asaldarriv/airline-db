using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class LayoverFacade
    {
        private readonly LayoverManager _manager = new();

        public IEnumerable<Layover> GetAllLayovers() => _manager.GetAllLayovers();

        public Layover? GetLayoverById(int id) => _manager.GetLayoverById(id);

        public void AddLayover(Layover layover) => _manager.AddLayover(layover);

        public void UpdateLayover(Layover layover) => _manager.UpdateLayover(layover);

        public void DeleteLayover(int id) => _manager.DeleteLayover(id);
    }
}