using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_MVC3.Models
{
    public class LoginForm
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email je povinný")]
        public string Email { get; set; }

        [Display(Name = "Heslo")]
        [Required(ErrorMessage = "Heslo je povinné")]
        [MinLength(5, ErrorMessage = "Minimální délka hesla je {0} znaků")]
        public string Password { get; set; }
    }
}
