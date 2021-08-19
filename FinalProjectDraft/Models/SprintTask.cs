using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectDraft.Models
{
    public class SprintTask
    {
        public int SprintTaskId { get; set; }
        public string  SprintTaskTitle { get; set; }
        public string Description { get; set; }
        public Sprint Sprint { get; set; }
        public int SprintId { get; set; }
        public Developer Developer { get; set; }
        public string DeveloperId { get; set; }
        public List<Report> Reports { get; set; }
        public ProjectStatus ProjectStatus { get; set; }
        public int ProjectStatusId { get; set; }


    }
}
