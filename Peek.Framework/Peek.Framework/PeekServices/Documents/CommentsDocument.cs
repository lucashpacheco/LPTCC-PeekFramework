using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using Peek.Framework.PeekServices.Domain;
using Peek.Framework.PeekServices.PeekWriter.Commands;

namespace Peek.Framework.PeekServices.Documents
{
    public class CommentsDocument
    {
        [BsonId]
        public Guid PeekId { get; set; }

        [BsonRequired]
        public List<Comment> Comments { get; set; }

        public CommentsDocument(CreateCommentCommand createCommentCommand)
        {
            PeekId = createCommentCommand.PeekId;
            Comments = new List<Comment>();
            Comments.Add(createCommentCommand.Comment);
        }
        public CommentsDocument(UpdateCommentCommand updateCommentCommand)
        {
            PeekId = updateCommentCommand.PeekId;
            Comments = new List<Comment>();
            Comments.Add(updateCommentCommand.Comment);
        }
    }
}
