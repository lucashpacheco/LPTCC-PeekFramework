using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Peek.Framework.PeekServices.PeekWriter.Commands
{
    public class CreatePeekCommand
    {
        public Guid? Id { get; set; } = Guid.NewGuid();
        [Required]
        public Guid? AuthorId { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
