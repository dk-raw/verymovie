using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace doge.Models
{
    public class Actor
    {
        public int ActorId { get; set; }

        [Required(ErrorMessage = "a first name is required"), MaxLength(20), MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "a last name is required"), MaxLength(20), MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(30), MinLength(2)]
        public string Country { get; set; }

        [Display(Name = "Image")]
        public string PhotoUrl { get; set; }

        [Required(ErrorMessage = "a date fo birth is required")] //maybe make not required
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Date of Death")]
        public DateTime? DateofDeath { get; set; } //nullable

        [EmailAddress] //make a email address
        [Display(Name = "Contact")]
        public string Email { get; set; }

        [Display(Name ="Annula Salary")]
        public double? Salary { get; set; } //nullable
    }
}