using ContentCollectionDataEntity = Astrana.Core.Data.Entities.Content.ContentCollection;

using ContentCollectionDomainEntity = Astrana.Core.Domain.Models.ContentCollections.ContentCollection;
using ContentCollectionItemDomainEntity = Astrana.Core.Domain.Models.ContentCollections.ContentCollectionItem;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class ContentCollection
    {
        public static ContentCollectionDomainEntity MapToDomainModel(ContentCollectionDataEntity contentCollectionDataEntity)
        {
            var domainModel = new ContentCollectionDomainEntity
            {
                ContentCollectionId = contentCollectionDataEntity.ContentCollectionId,

                CollectionType = contentCollectionDataEntity.CollectionType,

                Name = contentCollectionDataEntity.Name,
                Caption = contentCollectionDataEntity.Caption,
                Copyright = contentCollectionDataEntity.Copyright,
                
                ContentItems = new List<ContentCollectionItemDomainEntity>(),

                CreatedBy = contentCollectionDataEntity.CreatedBy,
                CreatedTimestamp = contentCollectionDataEntity.CreatedTimestamp,

                LastModifiedBy = contentCollectionDataEntity.LastModifiedBy,
                LastModifiedTimestamp = contentCollectionDataEntity.LastModifiedTimestamp,

                DeactivatedBy = contentCollectionDataEntity.DeactivatedBy,
                DeactivatedTimestamp = contentCollectionDataEntity.DeactivatedTimestamp,
                DeactivatedReason = contentCollectionDataEntity.DeactivatedReason
            };

            domainModel.ContentItems = contentCollectionDataEntity.ContentCollectionItems.Select(ContentCollectionItem.MapToDomainModel).ToList();

            return domainModel;
        }
    }
}
