using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.Models
{
    public class RegisterModel
    {

        [Required]
        public string Username { get; set; }

        [Required]
        public string FullName { set; get; }

        [Required]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { set; get; }
        
        [Required]
        public string Email { set; get; }

        [Required]
        public string PhoneNumber { set; get; }
        
    }
}
