namespace DocumentIndexer.Interfaces.DTOs
{
    public class InputDocumentWithExtractedWords
    {
        public InputDocument InputDocument { get; set; }
        public string[] ExtractedWords { get; set; }
    }
}