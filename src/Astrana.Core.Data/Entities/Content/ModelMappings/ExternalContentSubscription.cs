/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using ExternalContentSubscriptionDataEntity = Astrana.Core.Data.Entities.Content.ExternalContentSubscription;

using ExternalContentSubscriptionDomainEntity = Astrana.Core.Domain.Models.ExternalContent.Subscriptions.ExternalContentSubscription;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class ExternalContentSubscription
    {
        public static ExternalContentSubscriptionDomainEntity MapToDomainModel(ExternalContentSubscriptionDataEntity externalContentSubscriptionDataEntity)
        {
            var domainModel = new ExternalContentSubscriptionDomainEntity
            {
                ExternalContentSubscriptionId = externalContentSubscriptionDataEntity.ExternalContentSubscriptionId,

                Url = externalContentSubscriptionDataEntity.Url,

                Title = externalContentSubscriptionDataEntity.Title,
                SubTitle = externalContentSubscriptionDataEntity.SubTitle,

                Description = externalContentSubscriptionDataEntity.Description,
                WebsiteUrl = externalContentSubscriptionDataEntity.WebsiteUrl,
                Copyright = externalContentSubscriptionDataEntity.Copyright,

                Locale = externalContentSubscriptionDataEntity.Locale,
                Language = externalContentSubscriptionDataEntity.Language,

                AccessToken = externalContentSubscriptionDataEntity.AccessToken,

                CreatedBy = externalContentSubscriptionDataEntity.CreatedBy,
                CreatedTimestamp = externalContentSubscriptionDataEntity.CreatedTimestamp,

                LastModifiedBy = externalContentSubscriptionDataEntity.LastModifiedBy,
                LastModifiedTimestamp = externalContentSubscriptionDataEntity.LastModifiedTimestamp,

                DeactivatedBy = externalContentSubscriptionDataEntity.DeactivatedBy,
                DeactivatedTimestamp = externalContentSubscriptionDataEntity.DeactivatedTimestamp,
                DeactivatedReason = externalContentSubscriptionDataEntity.DeactivatedReason
            };

            if (externalContentSubscriptionDataEntity.IconImage != null)
                domainModel.IconImage = Image.MapToDomainModel(externalContentSubscriptionDataEntity.IconImage);

            if (externalContentSubscriptionDataEntity.LogoImage != null)
                domainModel.LogoImage = Image.MapToDomainModel(externalContentSubscriptionDataEntity.LogoImage);

            if (externalContentSubscriptionDataEntity.CoverImage != null)
                domainModel.CoverImage = Image.MapToDomainModel(externalContentSubscriptionDataEntity.CoverImage);

            return domainModel;
        }
    }
}
