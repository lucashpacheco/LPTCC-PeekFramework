using System;
using System.ComponentModel.DataAnnotations;

namespace Peek.Framework.PeekServices.PeekWriter.Commands
{
    public class DeleteLikeCommand
    {
        [Required]
        public Guid? PeekId { get; set; }
        [Required]
        public Guid? UserId { get; set; }
    }
}
