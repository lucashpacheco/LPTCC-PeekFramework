using System;
using System.ComponentModel.DataAnnotations;
using Peek.Framework.PeekServices.Domain;

namespace Peek.Framework.PeekServices.PeekWriter.Commands
{
    public class UpdateCommentCommand
    {
        [Required]
        public Guid PeekId { get; set; }

        [Required]
        public Comment Comment { get; set; }
    }
}
