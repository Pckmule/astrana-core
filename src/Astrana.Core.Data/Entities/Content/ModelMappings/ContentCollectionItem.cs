using ContentCollectionItemDataEntity = Astrana.Core.Data.Entities.Content.ContentCollectionItem;
using ContentCollectionItemDomainEntity = Astrana.Core.Domain.Models.ContentCollections.ContentCollectionItem;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class ContentCollectionItem
    {
        public static ContentCollectionItemDomainEntity MapToDomainModel(ContentCollectionItemDataEntity contentCollectionItemDataEntity)
        {
            var domainModel = new ContentCollectionItemDomainEntity
            {
                ContentCollectionItemId = contentCollectionItemDataEntity.ContentCollectionItemId,

                MediaType = contentCollectionItemDataEntity.MediaType,

                ImageId = contentCollectionItemDataEntity.ImageId,
                VideoId = contentCollectionItemDataEntity.VideoId,
                AudioId = contentCollectionItemDataEntity.AudioId,
                LinkId = contentCollectionItemDataEntity.LinkId,

                CreatedBy = contentCollectionItemDataEntity.CreatedBy,
                CreatedTimestamp = contentCollectionItemDataEntity.CreatedTimestamp,

                LastModifiedBy = contentCollectionItemDataEntity.LastModifiedBy,
                LastModifiedTimestamp = contentCollectionItemDataEntity.LastModifiedTimestamp,

                DeactivatedBy = contentCollectionItemDataEntity.DeactivatedBy,
                DeactivatedTimestamp = contentCollectionItemDataEntity.DeactivatedTimestamp,
                DeactivatedReason = contentCollectionItemDataEntity.DeactivatedReason
            };

            if (contentCollectionItemDataEntity.Image != null)
                domainModel.Image = Image.MapToDomainModel(contentCollectionItemDataEntity.Image);

            if (contentCollectionItemDataEntity.Video != null)
                domainModel.Video = Video.MapToDomainModel(contentCollectionItemDataEntity.Video);

            if (contentCollectionItemDataEntity.Audio != null)
                domainModel.Audio = Audio.MapToDomainModel(contentCollectionItemDataEntity.Audio);

            if (contentCollectionItemDataEntity.Link != null)
                domainModel.Link = Link.MapToDomainModel(contentCollectionItemDataEntity.Link);

            return domainModel;
        }
    }
}
