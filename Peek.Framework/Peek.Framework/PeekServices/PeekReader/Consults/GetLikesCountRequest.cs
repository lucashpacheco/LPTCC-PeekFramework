using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peek.Framework.PeekServices.PeekReader.Consults
{
    public class GetLikesCountRequest
    {
        [Required(ErrorMessage = "PeekId is required")]
        public Guid PeekId { get; set; }
    }
}
