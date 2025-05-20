using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;
using Airline.core.AirlineUtils;

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

        public void AddUser(User user, string plainPassword)
        {
            user.PasswordHash = PasswordUtils.ComputeSha256Hash(plainPassword);
            _repository.Add(user);
        }

        public void UpdateUser(User user, string? plainPassword = null)
        {
            if (!string.IsNullOrEmpty(plainPassword))
                user.PasswordHash = PasswordUtils.ComputeSha256Hash(plainPassword);
            _repository.Update(user);
        }

        public void DeleteUser(int id) => _repository.Delete(id);
    }
}