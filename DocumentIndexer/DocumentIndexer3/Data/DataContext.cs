using System.Data.Entity;

namespace DocumentIndexer.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }
        public DbSet<IndexEntry> IndexEntries { get; set; }

        public DataContext(string connectionString)
            : base(connectionString)
        {

        }
    }
}