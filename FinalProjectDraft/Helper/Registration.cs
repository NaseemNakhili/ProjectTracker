using FinalProjectDraft.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectDraft.Helper
{
    public class Registration
    {
        private ApplicationDbContext context;
        public Registration( ApplicationDbContext context)
        {
            this.context = context;

        }
        

        public void rol()
        {
            var r = context.Roles.ToList();


        }

        public enum userRole
        {

            ProjectManger = 1,
            TeamLeader = 2,
            Developer = 3
        }

    }
}
