using System;
using System.ComponentModel.DataAnnotations;

namespace Peek.Framework.PeekServices.Domain
{
    public class Comment
    {
        [Required]
        public Guid? Id { get; set; }

        [Required]
        public Guid? AuthorId { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

        public Comment(DateTime createdDate)
        {
            CreatedDate = DateTime.UtcNow;
        }
    }
}