using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;
using System.Security.Cryptography;
using System.Text;

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
            string hashedPassword = ComputeSha256Hash(request.Password);
            var hashedRequest = new LoginRequest
            {
                Username = request.Username,
                Password = hashedPassword
            };
            return _repository.ValidateLogin(hashedRequest);
        }

        /// <summary>
        /// Computes the SHA-256 hash of the input string.
        /// </summary>
        /// <param name="rawData">The input string to hash.</param>
        /// <returns>Hexadecimal string representation of the hash.</returns>
        private static string ComputeSha256Hash(string rawData)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
            var builder = new StringBuilder();
            foreach (var b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }
    }
}