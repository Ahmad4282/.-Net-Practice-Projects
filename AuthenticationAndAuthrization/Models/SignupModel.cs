using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthenticationAndAuthrization.Models
{
    public class SignupModel
    {
        [Required(ErrorMessage = "User Name is required")]
        [DisplayName("User Name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]

        public string ConfirmPassword { get; set; }
    }
}