using FeelingDataEntity = Astrana.Core.Data.Entities.Configuration.Feeling;
using FeelingDomainEntity = Astrana.Core.Domain.Models.Feelings.Feeling;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class Feeling
    {
        public static FeelingDomainEntity MapToDomainModel(FeelingDataEntity contentCollectionDataEntity)
        {
            var domainModel = new FeelingDomainEntity
            {
                FeelingId = contentCollectionDataEntity.FeelingId,

                Name = contentCollectionDataEntity.Name,
                NameTrxCode = contentCollectionDataEntity.NameTrxCode,
                
                IconName = contentCollectionDataEntity.IconName,
                
                UnicodeIcon = contentCollectionDataEntity.UnicodeIcon,
                ShortCode = contentCollectionDataEntity.ShortCode,

                CreatedBy = contentCollectionDataEntity.CreatedBy,
                CreatedTimestamp = contentCollectionDataEntity.CreatedTimestamp,

                LastModifiedBy = contentCollectionDataEntity.LastModifiedBy,
                LastModifiedTimestamp = contentCollectionDataEntity.LastModifiedTimestamp,

                DeactivatedBy = contentCollectionDataEntity.DeactivatedBy,
                DeactivatedTimestamp = contentCollectionDataEntity.DeactivatedTimestamp,
                DeactivatedReason = contentCollectionDataEntity.DeactivatedReason
            };

            return domainModel;
        }
    }
}
