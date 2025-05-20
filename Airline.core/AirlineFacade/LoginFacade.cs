using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    /// <summary>
    /// Facade for user login operations.
    /// </summary>
    public class LoginFacade
    {
        private readonly LoginManager _manager = new();

        /// <summary>
        /// Validates the login credentials.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <param name="password">Password.</param>
        /// <returns>True if credentials are valid, otherwise false.</returns>
        public bool ValidateLogin(string username, string password)
        {
            var request = new LoginRequest
            {
                Username = username,
                Password = password
            };
            var result = _manager.ValidateLogin(request);
            return result.IsValid;
        }
    }
}