/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using PostAttachmentDataEntity = Astrana.Core.Data.Entities.Content.PostAttachment;
using PostAttachmentDomainEntity = Astrana.Core.Domain.Models.Posts.PostAttachment;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class PostAttachment
    {
        public static PostAttachmentDomainEntity? MapToDomainModel(PostAttachmentDataEntity? postAttachmentDataEntity)
        {
            if (postAttachmentDataEntity == null)
                return null;

            var domainModel = new PostAttachmentDomainEntity
            {
                PostAttachmentId = postAttachmentDataEntity.PostAttachmentId,

                Type = postAttachmentDataEntity.Type,

                Title = postAttachmentDataEntity.Title,
                Caption = postAttachmentDataEntity.Caption,

                LinkId = postAttachmentDataEntity.LinkId,
                ImageId = postAttachmentDataEntity.ImageId,
                VideoId = postAttachmentDataEntity.VideoId,
                AudioId = postAttachmentDataEntity.AudioClipId,
                ContentCollectionId = postAttachmentDataEntity.ContentCollectionId,
                GifId = postAttachmentDataEntity.GifId,
                FeelingId = postAttachmentDataEntity.FeelingId,
                LocationId = postAttachmentDataEntity.LocationId,

                CreatedBy = postAttachmentDataEntity.CreatedBy,
                CreatedTimestamp = postAttachmentDataEntity.CreatedTimestamp,

                LastModifiedBy = postAttachmentDataEntity.LastModifiedBy,
                LastModifiedTimestamp = postAttachmentDataEntity.LastModifiedTimestamp
            };

            if (postAttachmentDataEntity.Link != null)
                domainModel.Link = Link.MapToDomainModel(postAttachmentDataEntity.Link);

            if (postAttachmentDataEntity.Image != null)
                domainModel.Image = Image.MapToDomainModel(postAttachmentDataEntity.Image);

            if (postAttachmentDataEntity.Video != null)
                domainModel.Video = Video.MapToDomainModel(postAttachmentDataEntity.Video);

            if (postAttachmentDataEntity.AudioClip != null)
                domainModel.Audio = AudioClip.MapToDomainModel(postAttachmentDataEntity.AudioClip);

            if (postAttachmentDataEntity.ContentCollection != null)
                domainModel.ContentCollection = ContentCollection.MapToDomainModel(postAttachmentDataEntity.ContentCollection);

            if (postAttachmentDataEntity.Gif != null)
                domainModel.Gif = Gif.MapToDomainModel(postAttachmentDataEntity.Gif);

            if (postAttachmentDataEntity.Feeling != null)
                domainModel.Feeling = Feeling.MapToDomainModel(postAttachmentDataEntity.Feeling);

            if (postAttachmentDataEntity.Location != null)
                domainModel.Location = Location.MapToDomainModel(postAttachmentDataEntity.Location);
            
            return domainModel;
        }
    }
}
