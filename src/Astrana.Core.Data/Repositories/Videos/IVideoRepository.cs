/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Videos;
using Astrana.Core.Domain.Models.Videos.Contracts;
using Astrana.Core.Domain.Models.Videos.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.Videos
{
    public interface IVideoRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetVideosCountAsync(VideoQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<Video>> GetVideosAsync(VideoQueryOptions<Guid, TUserId> queryOptions = null);

        Task<Video?> GetVideoByIdAsync(Guid id);

        Task<IAddResult<List<Video>>> CreateAsync(IEnumerable<IVideoToAdd> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<Video>>> UpdateAsync(IEnumerable<Video> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);

        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedVideosToRemoveIds, Guid actioningUserId);
    }
}
