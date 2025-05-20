namespace Airline.core.AirlineEntities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}