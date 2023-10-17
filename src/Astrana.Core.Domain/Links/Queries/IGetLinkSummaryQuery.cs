/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Links;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Links.Queries
{
    public interface IGetLinkSummaryQuery
    {
        Task<ExecutionResult<LinkSummary>> ExecuteAsync(Uri url, Guid actioningUserId);
    }
}
