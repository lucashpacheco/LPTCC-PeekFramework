using System;
using System.ComponentModel.DataAnnotations;

namespace Peek.Framework.PeekServices.PeekWriter.Commands
{
    public class UpdatePeekCommand
    {
        [Required]
        public Guid? Id { get; set; }
        [Required]
        public Guid? AuthorId { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
