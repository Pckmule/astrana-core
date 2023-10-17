/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.System.Enums;

namespace Astrana.Core.Domain.Models.Options.Contracts
{
    public interface IQueryOptions<TRecordId, TOwnerUserId>
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        List<TRecordId>? Ids { get; set; }

        List<TOwnerUserId>? OwnerUserIds { get; set; }

        DateTimeOffset? CreatedBefore { get; set; }

        DateTimeOffset? CreatedAfter { get; set; }

        /// <summary>
        /// Determines if the query should return paged results. The default value is False.
        /// </summary>
        bool PagingDisabled { get; set; }

        int? PageSize { get; set; }

        int? CurrentPage { get; set; }

        string? SortBy { get; set; }

        OrderByDirection OrderByDirection { get; set; }

        List<string> ToQueryStringList();

        string ToQueryString();

        string ToString();
    }
}
