namespace Airline.core.AirlineEntities
{
    public class User
    {
        public int UserId { get; set; }
        public int DocumentTypeId { get; set; }
        public int CountryId { get; set; }
        public int RoleId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string? SecondName { get; set; }
        public string FirstLastName { get; set; } = string.Empty;
        public string? SecondLastName { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string? TrainingInstitution { get; set; }
        public string? EducationLevel { get; set; }
        public string? DegreeTitle { get; set; }
        public int? ResidenceCountryId { get; set; }
        public int? BirthCountryId { get; set; }
        public int? ContractStatusId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}