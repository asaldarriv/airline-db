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

        // Recibe la contraseña en texto plano
        public void AddUser(User user, string plainPassword) => _manager.AddUser(user, plainPassword);

        public void UpdateUser(User user, string? plainPassword = null) => _manager.UpdateUser(user, plainPassword);

        public void DeleteUser(int id) => _manager.DeleteUser(id);
    }
}