using DocumentIndexer.Interfaces.DTOs;

namespace DocumentIndexer.Interfaces
{
    public interface IDocumentProcessor
    {
        void Process(InputDocument inputDocument);
    }
}