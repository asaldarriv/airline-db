using System.Collections.Generic;
using Airline.core.AirlineEntities;
using Airline.core.AirlineRepository;

namespace Airline.core.AirlineManager
{
    public class DocumentTypeManager
    {
        private readonly IDocumentTypeRepository _repository;

        public DocumentTypeManager(IDocumentTypeRepository? repository = null)
        {
            _repository = repository ?? new DocumentTypeRepository();
        }

        public IEnumerable<DocumentType> GetAllDocumentTypes() => _repository.GetAll();

        public DocumentType? GetDocumentTypeById(int id) => _repository.GetById(id);

        public void AddDocumentType(DocumentType documentType) => _repository.Add(documentType);

        public void UpdateDocumentType(DocumentType documentType) => _repository.Update(documentType);

        public void DeleteDocumentType(int id) => _repository.Delete(id);
    }
}