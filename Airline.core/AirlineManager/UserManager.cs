using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class UserManager
    {
        private readonly IUserRepository _repository;

        public UserManager(IUserRepository? repository = null)
        {
            _repository = repository ?? new UserRepository();
        }

        public IEnumerable<User> GetAllUsers() => _repository.GetAll();

        public User? GetUserById(int id) => _repository.GetById(id);

        public void AddUser(User user) => _repository.Add(user);

        public void UpdateUser(User user) => _repository.Update(user);

        public void DeleteUser(int id) => _repository.Delete(id);
    }
}