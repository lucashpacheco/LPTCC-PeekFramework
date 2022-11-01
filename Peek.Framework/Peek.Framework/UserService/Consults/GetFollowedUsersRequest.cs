using System;
using System.ComponentModel.DataAnnotations;
using Peek.Framework.Common.Request;

namespace Peek.Framework.UserService.Consults
{
    public class GetFollowedUsersRequest

    {
        [Required(ErrorMessage = "UserId is required")]
        public Guid? UserId { get; set; }

        [Required(ErrorMessage = "Page and page size is required")]
        public PageInformation PageInformation { get; set; }
    }
}
