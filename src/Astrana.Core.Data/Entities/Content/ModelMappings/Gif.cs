/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using ImageDataEntity = Astrana.Core.Data.Entities.Content.Image;
using ImageDomainEntity = Astrana.Core.Domain.Models.Images.Image;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class Gif
    {
        public static ImageDomainEntity MapToDomainModel(ImageDataEntity gifDataEntity)
        {
            var domainModel = new ImageDomainEntity
            {
                ImageId = gifDataEntity.ImageId,

                Location = gifDataEntity.Location,
                Caption = gifDataEntity.Caption,
                Copyright = gifDataEntity.Copyright,

                CreatedBy = gifDataEntity.CreatedBy,
                CreatedTimestamp = gifDataEntity.CreatedTimestamp,

                LastModifiedBy = gifDataEntity.LastModifiedBy,
                LastModifiedTimestamp = gifDataEntity.LastModifiedTimestamp,

                DeactivatedBy = gifDataEntity.DeactivatedBy,
                DeactivatedTimestamp = gifDataEntity.DeactivatedTimestamp,
                DeactivatedReason = gifDataEntity.DeactivatedReason
            };

            return domainModel;
        }
    }
}
