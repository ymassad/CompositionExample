namespace DocumentIndexer.Interfaces.DTOs
{
    public class InputDocumentWithExtractedWords
    {
        public InputDocument InputDocument { get; }
        public string[] ExtractedWords { get; }

        public InputDocumentWithExtractedWords(InputDocument inputDocument, string[] extractedWords)
        {
            InputDocument = inputDocument;
            ExtractedWords = extractedWords;
        }
    }
}