using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectDraft.Models
{
    public class Document
    {
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string ContentType { get; set; }
        public byte[] DocumentFile { get; set; }
        public Report Report { get; set; }
        public int ReportId { get; set; }

    }
}
