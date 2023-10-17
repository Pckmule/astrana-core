/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.UserProfiles;
using Astrana.Core.Domain.Models.UserProfiles.Contracts;
using Astrana.Core.Domain.Models.UserProfiles.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.UserProfiles
{
    public interface IUserProfileRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetUserProfilesCountAsync(UserProfileQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<UserProfile>> GetUserProfilesAsync(UserProfileQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<UserProfile?> GetUserProfileByIdAsync(Guid id);

        Task<UserProfile?> GetUserProfileByUserAccountIdAsync(Guid userAccountId);

        Task<IAddResult<UserProfile>> CreateAsync(IUserProfileToAdd requestedAddition, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<UserProfile>>> UpdateAsync(IEnumerable<UserProfile> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<UserProfile>> UpdateProfileIntroductionAsync(Guid userProfileId, string updatedUserProfileIntroduction, Guid actioningUserId, bool returnRecords = false);

        Task<IUpdateResult<UserProfile>> UpdateProfilePictureAsync(Guid userProfileId, Guid imageId, TUserId actioningUserId, bool returnRecords = false);

        Task<IUpdateResult<UserProfile>> UpdateCoverPictureAsync(Guid userProfileId, Guid imageId, TUserId actioningUserId, bool returnRecords = false);

        Task<IUpdateResult<List<Guid>>> DeactivateAsync(IEnumerable<Guid> validatedUserProfilesToDeactivateIds, Guid actioningUserId);

        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedUserProfilesToRemoveIds, Guid actioningUserId);


        Task<ICountResult> GetUserProfileDetailsCountAsync(UserProfileDetailQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<UserProfileDetail>> GetUserProfileDetailsAsync(UserProfileDetailQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<UserProfileDetail?> GetUserProfileDetailByIdAsync(Guid id);
        
        Task<IAddResult<List<UserProfileDetail>>> CreateProfileDetailsAsync(IEnumerable<IUserProfileDetailToAdd> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<UserProfileDetail>>> UpdateProfileDetailsAsync(IEnumerable<UserProfileDetail> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);
        
        Task<IDeleteResult<List<Guid>>> DeleteProfileDetailsAsync(IEnumerable<Guid> validatedUserProfileDetailsToRemoveIds, Guid actioningUserId);

    }
}
