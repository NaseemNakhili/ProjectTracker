using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectDraft.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public string ReportTitel { get; set; }
        public string Description { get; set; }
        public SprintTask SprintTask { get; set; }
        public int SprintTaskId { get; set; }
        public  List<Document>  Documents { get; set; }

        public List<Comment> Comments { get; set; }

        public ReportStatus ReportStatus { get; set; }
        public int ReportStatusId { get; set; }


    }
}
