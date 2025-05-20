using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class RoleManager
    {
        private readonly IRoleRepository _repository;

        public RoleManager(IRoleRepository? repository = null)
        {
            _repository = repository ?? new RoleRepository();
        }

        public IEnumerable<Role> GetAllRoles() => _repository.GetAll();

        public Role? GetRoleById(int id) => _repository.GetById(id);

        public void AddRole(Role role) => _repository.Add(role);

        public void UpdateRole(Role role) => _repository.Update(role);

        public void DeleteRole(int id) => _repository.Delete(id);
    }
}