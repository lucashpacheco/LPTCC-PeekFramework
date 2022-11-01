using System;
using System.ComponentModel.DataAnnotations;

namespace Peek.Framework.PeekServices.Domain
{
    public class Like
    {
        [Required]
        public Guid? UserId { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

    }
}