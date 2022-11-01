using System.ComponentModel.DataAnnotations;

namespace Peek.Framework.UserService.Commands
{
    public class RefreshTokenCommand
    {
        [Required(ErrorMessage = "Token is required")]
        public string Token { get; set; }
    }
}
