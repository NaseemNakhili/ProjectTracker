using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectDraft.Models
{
    public class ProjectManger : IdentityUser
    {
        public List<Project> Projects { get; set; }
        

    }
}
