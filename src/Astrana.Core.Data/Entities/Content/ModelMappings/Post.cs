/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using PostDataEntity = Astrana.Core.Data.Entities.Content.Post;

using PostDomainEntity = Astrana.Core.Domain.Models.Posts.Post;
using PostAttachmentDomainEntity = Astrana.Core.Domain.Models.Posts.PostAttachment;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class Post
    {
        public static PostDomainEntity MapToDomainModel(PostDataEntity postDataEntity)
        {
            var domainModel = new PostDomainEntity
            {
                PostId = postDataEntity.PostId,

                Text = postDataEntity.Text,
                Attachments = new List<PostAttachmentDomainEntity>(),

                CreatedBy = postDataEntity.CreatedBy,
                CreatedTimestamp = postDataEntity.CreatedTimestamp,

                LastModifiedBy = postDataEntity.LastModifiedBy,
                LastModifiedTimestamp = postDataEntity.LastModifiedTimestamp,

                DeactivatedBy = postDataEntity.DeactivatedBy,
                DeactivatedTimestamp = postDataEntity.DeactivatedTimestamp,
                DeactivatedReason = postDataEntity.DeactivatedReason
            };

            if(postDataEntity.Attachments != null)
                domainModel.Attachments = postDataEntity.Attachments.Select(PostAttachment.MapToDomainModel).ToList();

            return domainModel;
        }
    }
}
