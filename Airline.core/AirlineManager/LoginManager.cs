using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;
using Airline.core.AirlineUtils;

namespace Airline.core.AirlineManager
{
    /// <summary>
    /// Handles business logic for user login.
    /// </summary>
    public class LoginManager
    {
        private readonly ILoginRepository _repository;

        public LoginManager(ILoginRepository? repository = null)
        {
            _repository = repository ?? new LoginRepository();
        }

        /// <summary>
        /// Validates the login request.
        /// </summary>
        /// <param name="request">Login request.</param>
        /// <returns>Login result.</returns>
        public LoginResult ValidateLogin(LoginRequest request)
        {
            string hashedPassword = PasswordUtils.ComputeSha256Hash(request.Password);
            var hashedRequest = new LoginRequest
            {
                Username = request.Username,
                Password = hashedPassword
            };
            return _repository.ValidateLogin(hashedRequest);
        }
    }
}