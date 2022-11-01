using System.ComponentModel.DataAnnotations;

namespace Peek.Framework.UserService.Commands
{
    public class LoginCommand
    {
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

    }
}
