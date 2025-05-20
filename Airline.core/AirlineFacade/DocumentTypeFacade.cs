using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class DocumentTypeFacade
    {
        private readonly DocumentTypeManager _manager = new();

        public IEnumerable<DocumentType> GetAllDocumentTypes() => _manager.GetAllDocumentTypes();

        public DocumentType? GetDocumentTypeById(int id) => _manager.GetDocumentTypeById(id);

        public void AddDocumentType(DocumentType documentType) => _manager.AddDocumentType(documentType);

        public void UpdateDocumentType(DocumentType documentType) => _manager.UpdateDocumentType(documentType);

        public void DeleteDocumentType(int id) => _manager.DeleteDocumentType(id);
    }
}