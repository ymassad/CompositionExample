namespace DocumentIndexer.Interfaces.DTOs
{
    public class InputDocument
    {
        public string DocumentName { get; }

        public string DocumentContent { get;  }

        public InputDocument(string documentName, string documentContent)
        {
            DocumentName = documentName;
            DocumentContent = documentContent;
        }
    }
}