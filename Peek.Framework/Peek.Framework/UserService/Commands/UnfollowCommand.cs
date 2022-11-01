using System;
using System.ComponentModel.DataAnnotations;

namespace Peek.Framework.UserService.Commands
{
    public class UnfollowCommand
    {
        [Required]
        public Guid? UserId { get; set; }

        [Required]
        public Guid? FollowedUserId { get; set; }
    }
}
