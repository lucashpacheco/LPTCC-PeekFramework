using System;
using System.ComponentModel.DataAnnotations;

namespace Peek.Framework.PeekServices.PeekWriter.Commands
{
    public class DeleteCommentCommand
    {
        [Required]
        public Guid? PeekId { get; set; }
        [Required]
        public Guid? CommentId { get; set; }
    }
}
