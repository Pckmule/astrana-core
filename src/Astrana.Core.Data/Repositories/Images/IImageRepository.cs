/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Images.Contracts;
using Astrana.Core.Domain.Models.Images.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.Images
{
    public interface IImageRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetImagesCountAsync(ImageQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<Image>> GetImagesAsync(ImageQueryOptions<Guid, TUserId> queryOptions = null);

        Task<Image?> GetImageByIdAsync(Guid id);

        Task<IAddResult<List<Image>>> CreateAsync(IEnumerable<IImageToAdd> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<Image>>> UpdateAsync(IEnumerable<Image> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);

        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedImagesToRemoveIds, Guid actioningUserId);
    }
}
