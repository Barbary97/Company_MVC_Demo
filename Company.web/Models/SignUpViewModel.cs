﻿using System.ComponentModel.DataAnnotations;

namespace Company.web.Models
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage ="First name is Required")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last name is Required")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage ="Invalid format of email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password is Required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{6,}$", ErrorMessage = "Password must have at least one lowercase letter, one uppercase letter, one digit, one non-alphanumeric character, and be at least 6 characters long.")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Password is Required")]
        [Compare(nameof(Password) , ErrorMessage = "Confirm Password does not match Password")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage ="Required to Agree")]
        public bool IsAgree { get; set; }
    }
}
