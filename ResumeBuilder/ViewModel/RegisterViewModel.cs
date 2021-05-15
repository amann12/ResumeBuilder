using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeBuilder.ViewModel
{
    public class RegisterViewModel
    {

        [Required]
        [EmailAddress]
        [Remote(action: "isEmailValid", controller: "Account")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password does not match!! Try Again")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
