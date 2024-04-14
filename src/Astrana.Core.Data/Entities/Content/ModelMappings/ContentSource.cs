/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using ContentSourceDataEntity = Astrana.Core.Data.Entities.Content.ExternalContentSource;
using ContentSourceDomainEntity = Astrana.Core.Domain.Models.ExternalContent.ContentSources.ContentSource;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class ContentSource
    {
        public static ContentSourceDomainEntity MapToDomainModel(ContentSourceDataEntity contentSourceDataEntity)
        {
            var domainModel = new ContentSourceDomainEntity
            {
                ContentSourceId = contentSourceDataEntity.ExternalContentSourceId,

                Url = contentSourceDataEntity.Url,
                Name = contentSourceDataEntity.Name,
                IconUrl = contentSourceDataEntity.IconUrl,

                CreatedBy = contentSourceDataEntity.CreatedBy,
                CreatedTimestamp = contentSourceDataEntity.CreatedTimestamp,

                LastModifiedBy = contentSourceDataEntity.LastModifiedBy,
                LastModifiedTimestamp = contentSourceDataEntity.LastModifiedTimestamp
            };

            return domainModel;
        }
    }
}
