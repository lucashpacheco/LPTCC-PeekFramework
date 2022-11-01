using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using Peek.Framework.PeekServices.Domain;
using Peek.Framework.PeekServices.PeekWriter.Commands;

namespace Peek.Framework.PeekServices.Documents
{
    public class LikesDocument
    {
        [BsonId]
        public Guid? PeekId { get; set; }
        [BsonRequired]
        public List<Like> Likes { get; set; }

        public LikesDocument(CreateLikeCommand createLikeCommand)
        {
            PeekId = createLikeCommand.PeekId;
            Likes = new List<Like>();
            Likes.Add(createLikeCommand.Like);

        }
    }
}
