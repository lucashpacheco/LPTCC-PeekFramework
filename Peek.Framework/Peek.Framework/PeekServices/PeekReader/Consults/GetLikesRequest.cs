using System;
using System.ComponentModel.DataAnnotations;
using Peek.Framework.Common.Request;

namespace Peek.Framework.PeekServices.PeekReader.Consults
{
    public class GetLikesRequest
    {
        [Required(ErrorMessage = "PeekId is required")]
        public Guid PeekId { get; set; }

        [Required(ErrorMessage = "Page and page size is required")]
        public PageInformation PageInformation { get; set; }

    }
}
