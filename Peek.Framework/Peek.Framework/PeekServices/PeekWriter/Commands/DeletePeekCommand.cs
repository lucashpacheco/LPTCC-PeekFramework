using System;
using System.ComponentModel.DataAnnotations;

namespace Peek.Framework.PeekServices.PeekWriter.Commands
{
    public class DeletePeekCommand
    {
        [Required]
        public Guid? Id { get; set; }
    }
}
