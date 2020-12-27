using System.ComponentModel.DataAnnotations;


namespace ATNET_WEBAPP_KON0355.Models
{
    public class LoginForm
    {
        [Required(ErrorMessageResourceType = typeof(GlobalizationResources.Resources),
            ErrorMessageResourceName = "UsernameError")]
        public string Username { get; set; }

        [Required(ErrorMessageResourceType = typeof(GlobalizationResources.Resources),
            ErrorMessageResourceName = "PasswordError")]
        public string Password { get; set; }
    }
}
