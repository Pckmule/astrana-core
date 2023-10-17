/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.UserProfiles;
using Astrana.Core.Domain.ContentCollections.Queries;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.User;
using Astrana.Core.Domain.Models.AstranaApi.Contracts;
using Astrana.Core.Domain.Models.ContentCollections.Enums;
using Astrana.Core.Domain.Models.ContentCollections.Options;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Images.Options;
using Astrana.Core.Domain.Models.Media.Enums;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Astrana.Core.Domain.UserProfiles.Queries
{
    public class GetProfilePhotosQuery : IGetProfilePhotosQuery
    {
        private readonly ILogger<GetProfilePhotosQuery> _logger;
        private readonly IAstranaApiInfo _astranaApiInfo;
        private readonly IUserManager _userManager;
        private readonly IUserProfileRepository<Guid> _userProfileRepository;
        private readonly IGetContentCollectionsQuery _getContentCollectionsQuery;

        public GetProfilePhotosQuery(ILogger<GetProfilePhotosQuery> logger, IAstranaApiInfo astranaApiInfo, IUserManager userManager, IUserProfileRepository<Guid> userProfileRepository, IGetContentCollectionsQuery getContentCollectionsQuery)
        {
            _logger = logger;

            _astranaApiInfo = astranaApiInfo;
            _userManager = userManager;
            _userProfileRepository = userProfileRepository;
            _getContentCollectionsQuery = getContentCollectionsQuery;
        }

        public async Task<GetResult<ImageQueryOptions<Guid, Guid>, Image, Guid, Guid>> ExecuteAsync(Guid actioningUserId, ImageQueryOptions<Guid, Guid>? options = null)
        {
            var queryOptions = new ContentCollectionQueryOptions<Guid, Guid>
            {
                OwnerUserIds = options?.OwnerUserIds,

                CreatedAfter = options?.CreatedAfter,
                CreatedBefore = options?.CreatedBefore,

                PageSize = options?.PageSize,
                CurrentPage = options?.CurrentPage,

                OrderByDirection = options?.OrderByDirection ?? OrderByDirection.Default,
                OrderBy = options?.OrderBy,

                IncludeCollectionItems = true,
                CollectionType = ContentCollectionType.Generic
            };

            var instanceUser = await _userManager.GetInstanceUserAsync();

            if (instanceUser == null)
                throw new ArgumentNullException(nameof(instanceUser));

            var instanceUserProfile = await _userProfileRepository.GetUserProfileByIdAsync(instanceUser.ProfileId);

            if (instanceUserProfile == null)
                throw new ArgumentNullException(nameof(instanceUserProfile));

            if (instanceUserProfile.ProfilePicturesCollection != null)
                queryOptions.ExcludeIds.Add(instanceUserProfile.ProfilePicturesCollection.Id);

            if (instanceUserProfile.CoverPicturesCollection != null)
                queryOptions.ExcludeIds.Add(instanceUserProfile.CoverPicturesCollection.Id);

            var result = await _getContentCollectionsQuery.ExecuteAsync(actioningUserId, queryOptions);

            var images = new List<Image>();

            if (result.HasData)
            {
                foreach (var contentCollection in result.Data)
                {
                    foreach (var contentCollectionItem in contentCollection.ContentItems)
                    {
                        if (contentCollectionItem.MediaType != MediaType.Image || contentCollectionItem.Image == null)
                            continue;

                        if (contentCollectionItem.Image.Location.StartsWith('/'))
                            contentCollectionItem.Image.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, contentCollectionItem.Image.Location);

                        images.Add(contentCollectionItem.Image);
                    }
                }
            }

            images = images.Skip((queryOptions.CurrentPage!.Value - 1) * queryOptions.PageSize!.Value).Take(queryOptions.PageSize.Value).ToList();

            _logger.LogTrace($"Executed {nameof(GetProfilePhotosQuery).SplitOnUpperCase()}");

            return new GetResult<ImageQueryOptions<Guid, Guid>, Image, Guid, Guid>(images, options, images.Count, result.Message);
        }
    }
}