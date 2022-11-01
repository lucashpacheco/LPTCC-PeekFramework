using System;
using System.ComponentModel.DataAnnotations;

namespace Peek.Framework.UserService.Consults
{
    public class GetUserByIdRequest
    {
        [Required(ErrorMessage = "UserId size is required")]
        public Guid? UserId { get; set; }
    }
}
