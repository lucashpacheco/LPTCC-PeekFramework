using System;
using System.ComponentModel.DataAnnotations;

namespace Peek.Framework.UserService.Commands
{
    public class CreateUserCommand
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, ErrorMessage = "Must be between 8 and 50 characters", MinimumLength = 5)]
        public string Password { get; set; }

        [Required(ErrorMessage = "BithDate is required")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "ProfilePhoto is required")]
        public string ProfilePhoto { get; set; }

    }
}
