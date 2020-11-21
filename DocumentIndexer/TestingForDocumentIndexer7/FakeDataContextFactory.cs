using System.Data.Common;
using DocumentIndexer.Data;
using DocumentIndexer.Interfaces;

namespace TestingForDocumentIndexer7
{
    public class FakeDataContextFactory : IDataContextFactory
    {
        private readonly DbConnection connection;

        public FakeDataContextFactory(DbConnection connection)
        {
            this.connection = connection;
        }

        public DataContext Create()
        {
            return new DataContext(connection, false);
        }
    }
}
