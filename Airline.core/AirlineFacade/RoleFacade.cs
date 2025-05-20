using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class RoleFacade
    {
        private readonly RoleManager _manager = new();

        public IEnumerable<Role> GetAllRoles() => _manager.GetAllRoles();

        public Role? GetRoleById(int id) => _manager.GetRoleById(id);

        public void AddRole(Role role) => _manager.AddRole(role);

        public void UpdateRole(Role role) => _manager.UpdateRole(role);

        public void DeleteRole(int id) => _manager.DeleteRole(id);
    }
}