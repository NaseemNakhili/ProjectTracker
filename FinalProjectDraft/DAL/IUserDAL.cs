using FinalProjectDraft.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectDraft.DAL
{
   public interface IUserDAL
    {
        public List<IdentityRole> getRoles();
    }
}
