using PostAttachmentDataEntity = Astrana.Core.Data.Entities.Content.PostAttachment;
using PostAttachmentDomainEntity = Astrana.Core.Domain.Models.Posts.PostAttachment;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class PostAttachment
    {
        public static PostAttachmentDomainEntity? MapToDomainModel(PostAttachmentDataEntity? postAttachmentDataEntity)
        {
            if (postAttachmentDataEntity == null)
                return null;

            var domainModel = new PostAttachmentDomainEntity
            {
                PostAttachmentId = postAttachmentDataEntity.Id,

                Type = postAttachmentDataEntity.Type,

                Title = postAttachmentDataEntity.Title,
                Caption = postAttachmentDataEntity.Caption,

                LinkId = postAttachmentDataEntity.LinkId,
                ImageId = postAttachmentDataEntity.ImageId,
                VideoId = postAttachmentDataEntity.VideoId,
                AudioId = postAttachmentDataEntity.AudioId,
                ContentCollectionId = postAttachmentDataEntity.ContentCollectionId,
                FeelingId = postAttachmentDataEntity.FeelingId,
                GifId = postAttachmentDataEntity.GifId,

                CreatedBy = postAttachmentDataEntity.CreatedBy,
                CreatedTimestamp = postAttachmentDataEntity.CreatedTimestamp,

                LastModifiedBy = postAttachmentDataEntity.LastModifiedBy,
                LastModifiedTimestamp = postAttachmentDataEntity.LastModifiedTimestamp
            };

            if (postAttachmentDataEntity.Link != null)
                domainModel.Link = Link.MapToDomainModel(postAttachmentDataEntity.Link);

            if (postAttachmentDataEntity.Image != null)
                domainModel.Image = Image.MapToDomainModel(postAttachmentDataEntity.Image);

            if (postAttachmentDataEntity.Video != null)
                domainModel.Video = Video.MapToDomainModel(postAttachmentDataEntity.Video);

            if (postAttachmentDataEntity.Audio != null)
                domainModel.Audio = Audio.MapToDomainModel(postAttachmentDataEntity.Audio);

            if (postAttachmentDataEntity.Feeling != null)
                domainModel.Feeling = Feeling.MapToDomainModel(postAttachmentDataEntity.Feeling);

            //if (postAttachmentDataEntity.Gif != null)
            //    domainModel.Gif = Gif.MapToDomainModel(postAttachmentDataEntity.Gif);

            if (postAttachmentDataEntity.ContentCollection != null)
                domainModel.ContentCollection = ContentCollection.MapToDomainModel(postAttachmentDataEntity.ContentCollection);
            
            return domainModel;
        }
    }
}
