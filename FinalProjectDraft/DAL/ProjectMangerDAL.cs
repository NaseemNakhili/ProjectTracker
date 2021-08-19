using FinalProjectDraft.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Providers.Entities;

namespace FinalProjectDraft.DAL
{
    public class ProjectMangerDAL 
    {
        private ApplicationDbContext context;
        private readonly UserManager<IdentityUser> _userManager;

       public ProjectMangerDAL(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            //change
            this.context = context;
        }
        public async Task InsertUserAsync(IdentityUser user)
        {
            var result = await _userManager.CreateAsync(user,user.PasswordHash);

            if(result.Succeeded)
            {
             IdentityUserRole<string> userRole = new IdentityUserRole<string>();

                userRole.RoleId = "1";
                userRole.UserId = user.Id;
                context.UserRoles.Add(userRole);
                context.SaveChanges();

            }
            

        }
    }
}
