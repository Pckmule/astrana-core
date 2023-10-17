using ImageDataEntity = Astrana.Core.Data.Entities.Content.Image;
using ImageDomainEntity = Astrana.Core.Domain.Models.Images.Image;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class Image
    {
        public static ImageDomainEntity MapToDomainModel(ImageDataEntity imageDataEntity)
        {
            var domainModel = new ImageDomainEntity
            {
                ImageId = imageDataEntity.ImageId,

                Location = imageDataEntity.Location,
                Caption = imageDataEntity.Caption,
                Copyright = imageDataEntity.Copyright,

                CreatedBy = imageDataEntity.CreatedBy,
                CreatedTimestamp = imageDataEntity.CreatedTimestamp,

                LastModifiedBy = imageDataEntity.LastModifiedBy,
                LastModifiedTimestamp = imageDataEntity.LastModifiedTimestamp,

                DeactivatedBy = imageDataEntity.DeactivatedBy,
                DeactivatedTimestamp = imageDataEntity.DeactivatedTimestamp,
                DeactivatedReason = imageDataEntity.DeactivatedReason
            };

            return domainModel;
        }
    }
}
