namespace Airline.core.AirlineEntities
{
    /// <summary>
    /// Represents a login request with username and password.
    /// </summary>
    public class LoginRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}