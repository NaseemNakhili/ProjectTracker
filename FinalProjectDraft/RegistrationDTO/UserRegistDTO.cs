using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectDraft.RegistratonDTO
{
    public class UserRegistDTO
    {
        
        public int RoleId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string  FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
       
        [EmailAddress(ErrorMessage = "Invalid Email address,example@ex.com")]
       
        public string  Email { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
       


    }
}
