/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using VideoDataEntity = Astrana.Core.Data.Entities.Content.Video;
using VideoDomainEntity = Astrana.Core.Domain.Models.Videos.Video;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class Video
    {
        public static VideoDomainEntity? MapToDomainModel(VideoDataEntity? videoDataEntity)
        {
            if (videoDataEntity == null)
                return null;

            var domainModel = new VideoDomainEntity
            {
                VideoId = videoDataEntity.VideoId,

                Location = videoDataEntity.Location,
                Caption = videoDataEntity.Caption,
                Copyright = videoDataEntity.Copyright,

                CreatedBy = videoDataEntity.CreatedBy,
                CreatedTimestamp = videoDataEntity.CreatedTimestamp,

                LastModifiedBy = videoDataEntity.LastModifiedBy,
                LastModifiedTimestamp = videoDataEntity.LastModifiedTimestamp,

                DeactivatedBy = videoDataEntity.DeactivatedBy,
                DeactivatedTimestamp = videoDataEntity.DeactivatedTimestamp,
                DeactivatedReason = videoDataEntity.DeactivatedReason
            };

            return domainModel;
        }
    }
}
