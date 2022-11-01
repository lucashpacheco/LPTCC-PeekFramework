using System;
using System.ComponentModel.DataAnnotations;

namespace Peek.Framework.PeekServices.PeekReader.Consults
{
    public class GetCommentsCountRequest
    {
        [Required(ErrorMessage = "PeekId is required")]
        public Guid PeekId { get; set; }

    }
}
