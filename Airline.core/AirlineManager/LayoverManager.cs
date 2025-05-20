using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class LayoverManager
    {
        private readonly ILayoverRepository _repository;

        public LayoverManager(ILayoverRepository? repository = null)
        {
            _repository = repository ?? new LayoverRepository();
        }

        public IEnumerable<Layover> GetAllLayovers() => _repository.GetAll();

        public Layover? GetLayoverById(int id) => _repository.GetById(id);

        public void AddLayover(Layover layover) => _repository.Add(layover);

        public void UpdateLayover(Layover layover) => _repository.Update(layover);

        public void DeleteLayover(int id) => _repository.Delete(id);
    }
}