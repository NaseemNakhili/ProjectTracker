using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectDraft.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectManger ProjectManger { get; set; }
        public string ProjectMangerId { get; set; }

        public TeamLeader TeamLeader { get; set; }
        public List<ProjectDeveloper> ProjectDevelopers { get; set; }
        public List<Sprint> Sprints { get; set; }
        public ProjectStatus ProjectStatus { get; set; }
        public int ProjectStatusId { get; set; }



    }
}
