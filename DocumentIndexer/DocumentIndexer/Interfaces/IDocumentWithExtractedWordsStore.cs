using DocumentIndexer.Interfaces.DTOs;

namespace DocumentIndexer.Interfaces
{
    public interface IDocumentWithExtractedWordsStore
    {
        void Store(InputDocumentWithExtractedWords inputDocumentWithExtractedWords);
    }
}