/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Links;
using Astrana.Core.Domain.Models.Links.Contracts;
using Astrana.Core.Domain.Models.Links.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.Links
{
    public interface ILinkRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetLinksCountAsync(LinkQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<Link>> GetLinksAsync(LinkQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<Link?> GetLinkByIdAsync(Guid id);
        
        Task<IAddResult<List<Link>>> CreateAsync(IEnumerable<Link> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<Link>>> UpdateAsync(IEnumerable<ILink> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);
        
        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedLinksToRemoveIds, Guid actioningUserId);
    }
}
