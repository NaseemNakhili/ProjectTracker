using FinalProjectDraft.DAL;
using FinalProjectDraft.Data;
using FinalProjectDraft.Models;
using Microsoft.AspNetCore.Identity;
using FinalProjectDraft.RegistratonDTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectDraft.Controllers
{
    public class RegistrationController : Controller
    {

        private IUserDAL UserDAL;
        private ApplicationDbContext context;
        private ProjectMangerDAL ProjectMangerDAL;

        public RegistrationController(IUserDAL UserDAL, ApplicationDbContext context, ProjectMangerDAL ProjectMangerDAL)
        {
            this.UserDAL = UserDAL;
            this.context = context;
            this.ProjectMangerDAL = ProjectMangerDAL;
        }

        
        public IActionResult RegistUser()
        {



            ViewBag.Rols = UserDAL.getRoles(); ;
           
          
            return View();
        }


        [HttpPost]
        public IActionResult RegistUser(UserRegistDTO registratonDTO)
        {
            if (ModelState.IsValid)
            {


                if (registratonDTO.RoleId == (int)userRole.ProjectManger)
                {
                    ProjectManger PM = new ProjectManger();
                    PM.UserName = registratonDTO.FirstName + " " + registratonDTO.LastName;
                    PM.Email = registratonDTO.Email;
                    PM.PasswordHash = registratonDTO.Password.GetHashCode().ToString();
                    PM.PhoneNumber = registratonDTO.PhoneNumber;
                    PM.EmailConfirmed = true;
                   
                    
                    _ = ProjectMangerDAL.InsertUserAsync(PM);
                   


                }
                else if (registratonDTO.RoleId == (int)userRole.TeamLeader)
                {
                    TeamLeader TL = new TeamLeader();
                    TL.UserName = registratonDTO.FirstName + " " + registratonDTO.LastName;
                    TL.Email = registratonDTO.Email;
                    TL.PasswordHash = registratonDTO.Password;
                    TL.PhoneNumber = registratonDTO.PhoneNumber;
                    TL.EmailConfirmed = true;
                    _ = ProjectMangerDAL.InsertUserAsync(TL);

                }
                else
                {
                    Developer D = new Developer();

                    D.UserName = registratonDTO.FirstName + " " + registratonDTO.LastName;
                    D.Email = registratonDTO.Email;
                    D.PasswordHash = registratonDTO.Password;
                    D.PhoneNumber = registratonDTO.PhoneNumber;
                    D.EmailConfirmed = true;
                    _ = ProjectMangerDAL.InsertUserAsync(D);


                }


                return RedirectToAction("Index", "Home");
            }
            else
            {
               
               
                ViewBag.Rols = context.Roles.ToList();
                return View("RegistUser", registratonDTO);

            }

            
           
        }

        public enum userRole
        {
           
            ProjectManger = 1,
            TeamLeader = 2,
            Developer = 3
        }
    }
}
