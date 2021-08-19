using FinalProjectDraft.Data;
using FinalProjectDraft.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectDraft.DAL
{
    public class UserDAL : IUserDAL
    {
        private ApplicationDbContext context;

        public UserDAL(ApplicationDbContext context)
        {
            this.context = context;

        }

        public List<IdentityRole> getRoles()
        {
            return context.Roles.ToList();
        }
    }
}
