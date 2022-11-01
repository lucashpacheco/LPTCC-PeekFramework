using System;

namespace Peek.Framework.PeekServices.Domain
{
    public class Peek
    {
        public Guid Id { get; set; }
        public Guid AuthorId { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
