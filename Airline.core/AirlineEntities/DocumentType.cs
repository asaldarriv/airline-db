namespace Airline.core.AirlineEntities
{
    public class DocumentType
    {
        public int DocumentTypeId { get; set; }
        public string TypeCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}