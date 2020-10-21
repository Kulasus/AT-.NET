using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETWEBAPP.Models
{
    public class OrderForm
    {
        [Display(Name = "Jméno")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Příjmení")]
        [Required(ErrorMessage = "test")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Doprava")]
        [Required]
        public int? Transportation { get; set; }
    }
}
