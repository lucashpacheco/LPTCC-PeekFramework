using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Peek.Framework.Common.Request;

namespace Peek.Framework.UserService.Consults
{
    public class GetUsersRequest
    {
        public List<Guid> UsersIds { get; set; }

        [Required(ErrorMessage = "Page and page size is required")]
        public PageInformation PageInformation { get; set; }
    }
}
