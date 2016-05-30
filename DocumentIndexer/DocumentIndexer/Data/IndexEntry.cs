using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentIndexer.Data
{
    public class IndexEntry
    {
        public long IndexEntryId { get; set; }
        [Index]
        [MaxLength(128)]
        public string Word { get; set; }

        public long DocumentId { get; set; }
        public virtual Document Document { get; set; }
    }
}
