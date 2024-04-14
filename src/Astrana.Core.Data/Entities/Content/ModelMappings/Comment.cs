using CommentDataEntity = Astrana.Core.Data.Entities.Content.Comment;
using CommentDomainEntity = Astrana.Core.Domain.Models.Comments.Comment;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class Comment
    {
        public static CommentDomainEntity MapToDomainModel(CommentDataEntity commentDataEntity)
        {
            var domainModel = new CommentDomainEntity
            {
                CommentId = commentDataEntity.CommentId,

                Text = commentDataEntity.Text,
                
                // Target xyz...

                CreatedBy = commentDataEntity.CreatedBy,
                CreatedTimestamp = commentDataEntity.CreatedTimestamp,

                LastModifiedBy = commentDataEntity.LastModifiedBy,
                LastModifiedTimestamp = commentDataEntity.LastModifiedTimestamp
            };

            return domainModel;
        }
    }
}
