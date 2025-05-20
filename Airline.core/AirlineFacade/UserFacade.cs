using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class UserFacade
    {
        private readonly UserManager _manager = new();

        public IEnumerable<User> GetAllUsers() => _manager.GetAllUsers();

        public User? GetUserById(int id) => _manager.GetUserById(id);

        public void AddUser(User user) => _manager.AddUser(user);

        public void UpdateUser(User user) => _manager.UpdateUser(user);

        public void DeleteUser(int id) => _manager.DeleteUser(id);
    }
}