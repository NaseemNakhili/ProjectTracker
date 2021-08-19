using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectDraft.Models
{
    public class Developer : IdentityUser
    {
        public List<ProjectDeveloper> ProjectDevelopers { get; set; }
        public List<SprintTask> SprintTasks { get; set; }

    }
}
