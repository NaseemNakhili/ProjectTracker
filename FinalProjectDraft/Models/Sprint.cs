using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectDraft.Models
{
    public class Sprint
    {
        public int SprintId { get; set; }
        public string SprintName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndtDate { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public List<SprintTask> Sprints { get; set; }
        public ProjectStatus ProjectStatus { get; set; }
        public int ProjectStatusId { get; set; }

    }
}
