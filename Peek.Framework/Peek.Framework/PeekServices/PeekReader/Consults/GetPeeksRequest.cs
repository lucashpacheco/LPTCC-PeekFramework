using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Peek.Framework.Common.Request;

namespace Peek.Framework.PeekServices.PeekReader.Consults
{
    public class GetPeeksRequest
    {
        [Required(ErrorMessage = "UserId is required")]
        public List<Guid> UserId { get; set; }


        [Required(ErrorMessage = "Page and page size is required")]
        public PageInformation PageInformation { get; set; }
    }
}
