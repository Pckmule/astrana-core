/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using ExternalContentSubscriptionContentItemDataEntity = Astrana.Core.Data.Entities.Content.ExternalContentSubscriptionContentItem;

using ExternalContentSubscriptionContentItemDomainEntity = Astrana.Core.Domain.Models.ExternalContent.ContentItems.ExternalContentSubscriptionContentItem;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class ExternalContentSubscriptionContentItem
    {
        public static ExternalContentSubscriptionContentItemDomainEntity MapToDomainModel(ExternalContentSubscriptionContentItemDataEntity externalContentSubscriptionDataEntity)
        {
            var domainModel = new ExternalContentSubscriptionContentItemDomainEntity
            {
                ExternalContentSubscriptionContentItemId = externalContentSubscriptionDataEntity.ExternalContentSubscriptionContentItemId,

                Url = externalContentSubscriptionDataEntity.Url,

                Title = externalContentSubscriptionDataEntity.Title,

                Summary = externalContentSubscriptionDataEntity.Summary,
                Content = externalContentSubscriptionDataEntity.Content,
                
                Rights = externalContentSubscriptionDataEntity.Rights,
                ContentRating = externalContentSubscriptionDataEntity.ContentRating,

                Published = externalContentSubscriptionDataEntity.Published,
                LastUpdated = externalContentSubscriptionDataEntity.LastUpdated,

                Source = ContentSource.MapToDomainModel(externalContentSubscriptionDataEntity.Source),

                CreatedBy = externalContentSubscriptionDataEntity.CreatedBy,
                CreatedTimestamp = externalContentSubscriptionDataEntity.CreatedTimestamp,

                LastModifiedBy = externalContentSubscriptionDataEntity.LastModifiedBy,
                LastModifiedTimestamp = externalContentSubscriptionDataEntity.LastModifiedTimestamp
            };

            if (externalContentSubscriptionDataEntity.Thumbnail != null)
                domainModel.Thumbnail = Image.MapToDomainModel(externalContentSubscriptionDataEntity.Thumbnail);

            if (externalContentSubscriptionDataEntity.Image != null)
                domainModel.Image = Image.MapToDomainModel(externalContentSubscriptionDataEntity.Image);

            //domainModel.Authors = externalContentSubscriptionDataEntity.Authors.Select(ContentAuthor.MapToDomainModel).ToList();
            //domainModel.Categories = externalContentSubscriptionDataEntity.Categories;
            //domainModel.Links = externalContentSubscriptionDataEntity.Authors.Select(ContentLink.MapToDomainModel).ToList();

            return domainModel;
        }
    }
}
