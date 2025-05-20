namespace Airline.core.AirlineEntities
{
    /// <summary>
    /// Represents the result of a login attempt.
    /// </summary>
    public class LoginResult
    {
        public bool IsValid { get; set; }
        public int? UserId { get; set; }
        public string? Role { get; set; }
        public string? ErrorMessage { get; set; }
    }
}