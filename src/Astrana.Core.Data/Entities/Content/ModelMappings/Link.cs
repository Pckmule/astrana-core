using LinkDataEntity = Astrana.Core.Data.Entities.Content.Link;
using LinkDomainEntity = Astrana.Core.Domain.Models.Links.Link;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class Link
    {
        public static LinkDomainEntity MapToDomainModel(LinkDataEntity linkDataEntity)
        {
            if (linkDataEntity == null)
                return null;

            var domainModel = new LinkDomainEntity
            {
                LinkId = linkDataEntity.LinkId,

                Url = linkDataEntity.Url,

                Title = linkDataEntity.Title,
                Description = linkDataEntity.Description,

                // Caption = linkDataEntity.Caption,
                Locale = linkDataEntity.Locale,
                CharSet = linkDataEntity.CharSet,
                Robots = linkDataEntity.Robots,
                SiteName = linkDataEntity.SiteName,

                CreatedBy = linkDataEntity.CreatedBy,
                CreatedTimestamp = linkDataEntity.CreatedTimestamp,

                LastModifiedBy = linkDataEntity.LastModifiedBy,
                LastModifiedTimestamp = linkDataEntity.LastModifiedTimestamp,

                DeactivatedBy = linkDataEntity.DeactivatedBy,
                DeactivatedTimestamp = linkDataEntity.DeactivatedTimestamp,
                DeactivatedReason = linkDataEntity.DeactivatedReason
            };

            if(linkDataEntity.PreviewImage != null)
            {
                domainModel.PreviewImage = Image.MapToDomainModel(linkDataEntity.PreviewImage);
            }

            return domainModel;
        }
    }
}
