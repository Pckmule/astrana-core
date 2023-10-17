/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Options.Contracts;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Domain.Models.Results
{
    public class GetResultMetadata<TUserId, TOwnerUserId> : IGetResultMetadata
        where TUserId : struct
        where TOwnerUserId : struct
    {
        public GetResultMetadata(long resultCount, IQueryOptions<TUserId, TOwnerUserId>? queryOptions = null, long resultSetCount = 0, string message = "")
        {
            queryOptions ??= new Options.QueryOptions<TUserId, TOwnerUserId>();

            ResultSetCount = resultSetCount > -1 ? resultSetCount : 0;
            ResultCount = resultCount;

            CurrentPage = queryOptions.CurrentPage is > 0 ? queryOptions.CurrentPage.Value : 1;
            PageSize = queryOptions.PageSize is > 0 ? queryOptions.PageSize.Value : 10;

            Message = message;
        }

        public long ResultSetCount { get; }

        public long ResultCount { get; }

        public int PageSize { get; }

        public int CurrentPage { get; }

        public int PageCount => (int)Math.Ceiling(ResultSetCount / (double)PageSize);

        public int NextPage => CurrentPage < PageCount ? CurrentPage + 1 : CurrentPage;

        public int PreviousPage => CurrentPage > 0 ? CurrentPage - 1 : 1;

        public int LastPage => PageCount;

        public string Message { get; }
    }
}
