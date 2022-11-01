using System;
using MongoDB.Bson.Serialization.Attributes;
using Peek.Framework.PeekServices.PeekWriter.Commands;

namespace Peek.Framework.PeekServices.Documents
{
    public class PeekDocument
    {
        [BsonId]
        public Guid Id { get; set; }
        [BsonRequired]
        public Guid AuthorId { get; set; }
        [BsonRequired]
        public string Message { get; set; }
        [BsonRequired]
        public DateTime CreatedDate { get; set; }

        public PeekDocument(CreatePeekCommand createPeekCommand)
        {
            Id = (Guid)createPeekCommand.Id;
            AuthorId = (Guid)createPeekCommand.AuthorId;
            Message = createPeekCommand.Message;
            CreatedDate = DateTime.UtcNow;
        }

        public PeekDocument(UpdatePeekCommand updatePeekCommand)
        {
            Id = (Guid)updatePeekCommand.Id;
            AuthorId = (Guid)updatePeekCommand.AuthorId;
            Message = updatePeekCommand.Message;
            CreatedDate = DateTime.UtcNow;
        }

        public PeekDocument()
        {
        }
    }
}
