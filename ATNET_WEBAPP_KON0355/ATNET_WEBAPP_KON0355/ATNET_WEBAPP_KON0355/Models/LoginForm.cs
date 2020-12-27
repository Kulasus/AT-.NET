using System.ComponentModel.DataAnnotations;


namespace ATNET_WEBAPP_KON0355.Models
{
    public class LoginForm
    {
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
    }
}
