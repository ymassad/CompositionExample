using DocumentIndexer.Data;
using DocumentIndexer.Interfaces;

namespace DocumentIndexer.Implementations
{
    public class DataContextFactory : IDataContextFactory
    {
        private readonly string connectionString;

        public DataContextFactory(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataContext Create()
        {
            return new DataContext(connectionString);
        }
    }
}