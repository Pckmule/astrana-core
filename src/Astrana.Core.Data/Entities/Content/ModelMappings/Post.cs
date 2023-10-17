using PostDataEntity = Astrana.Core.Data.Entities.Content.Post;

using PostDomainEntity = Astrana.Core.Domain.Models.Posts.Post;
using PostAttachmentDomainEntity = Astrana.Core.Domain.Models.Posts.PostAttachment;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class Post
    {
        public static PostDomainEntity MapToDomainModel(PostDataEntity contentCollectionDataEntity)
        {
            var domainModel = new PostDomainEntity
            {
                PostId = contentCollectionDataEntity.PostId,

                Text = contentCollectionDataEntity.Text,
                Attachments = new List<PostAttachmentDomainEntity>(),

                CreatedBy = contentCollectionDataEntity.CreatedBy,
                CreatedTimestamp = contentCollectionDataEntity.CreatedTimestamp,

                LastModifiedBy = contentCollectionDataEntity.LastModifiedBy,
                LastModifiedTimestamp = contentCollectionDataEntity.LastModifiedTimestamp,

                DeactivatedBy = contentCollectionDataEntity.DeactivatedBy,
                DeactivatedTimestamp = contentCollectionDataEntity.DeactivatedTimestamp,
                DeactivatedReason = contentCollectionDataEntity.DeactivatedReason
            };

            if(contentCollectionDataEntity.Attachments != null)
                domainModel.Attachments = contentCollectionDataEntity.Attachments.Select(PostAttachment.MapToDomainModel).ToList();

            return domainModel;
        }
    }
}
