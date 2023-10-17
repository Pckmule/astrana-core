/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.UserProfiles;
using Astrana.Core.Domain.Models.AstranaApi.Contracts;
using Astrana.Core.Domain.Models.Media.Enums;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Models.UserProfiles;
using Astrana.Core.Domain.Models.UserProfiles.Options;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.UserProfiles.Queries
{
    public class GetUserProfilesQuery : IGetUserProfileQuery
    {
        private readonly ILogger<GetUserProfilesQuery> _logger;
        private readonly IAstranaApiInfo _astranaApiInfo;
        private readonly IUserProfileRepository<Guid> _userProfileRepository;

        public GetUserProfilesQuery(ILogger<GetUserProfilesQuery> logger, IAstranaApiInfo astranaApiInfo, IUserProfileRepository<Guid> userProfileRepository)
        {
            _logger = logger;
            _astranaApiInfo = astranaApiInfo;
            _userProfileRepository = userProfileRepository;
        }

        public async Task<GetResult<UserProfileQueryOptions<Guid, Guid>, UserProfile, Guid, Guid>> ExecuteAsync(Guid actioningUserId, UserProfileQueryOptions<Guid, Guid> queryOptions)
        {
            var result = await _userProfileRepository.GetUserProfilesAsync(queryOptions);

            if (result.HasData)
            {
                foreach (var userProfile in result.Data)
                {
                    if (userProfile.CoverPicturesCollection != null && userProfile.CoverPicturesCollection.ContentItems != null)
                    {
                        foreach (var contentCollectionItem in userProfile.CoverPicturesCollection.ContentItems)
                        {
                            if (contentCollectionItem.MediaType == MediaType.Image && contentCollectionItem.Image != null)
                                contentCollectionItem.Image.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, contentCollectionItem.Image.Location);
                        }
                    }

                    if (userProfile.ProfilePicturesCollection == null || userProfile.ProfilePicturesCollection.ContentItems == null) 
                        continue;
                    
                    foreach (var contentCollectionItem in userProfile.ProfilePicturesCollection.ContentItems)
                    {
                        if (contentCollectionItem.MediaType == MediaType.Image && contentCollectionItem.Image != null)
                            contentCollectionItem.Image.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, contentCollectionItem.Image.Location);
                    }
                    
                }
            }

            _logger.LogTrace($"Executed {nameof(GetUserProfilesQuery).SplitOnUpperCase()}");

            return new GetResult<UserProfileQueryOptions<Guid, Guid>, UserProfile, Guid, Guid>(result.Data, queryOptions, result.ResultSetCount, result.Message);
        }
    }
}