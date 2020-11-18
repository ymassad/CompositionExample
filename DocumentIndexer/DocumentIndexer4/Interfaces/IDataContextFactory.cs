using DocumentIndexer.Data;

namespace DocumentIndexer.Interfaces
{
    public interface IDataContextFactory
    {
        DataContext Create();
    }
}