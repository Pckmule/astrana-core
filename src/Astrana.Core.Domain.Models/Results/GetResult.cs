/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Options.Contracts;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Domain.Models.Results
{
    public class GetResult<TQueryOptions, TData, TUserId, TOwnerUserId> : IGetResult<TData>
        where TQueryOptions : class, IQueryOptions<TUserId, TOwnerUserId>, new()
        where TUserId : struct
        where TOwnerUserId : struct
    {
        public GetResult(List<TData> resultData, TQueryOptions? queryOptions = null, long resultSetCount = 0, string message = "")
        {
            if (resultSetCount < resultData.Count)
                throw new ArgumentException(nameof(resultSetCount));

            queryOptions ??= new TQueryOptions();

            Data = resultData;

            ResultSetCount = resultSetCount > -1 ? resultSetCount : 0;
            CurrentPage = queryOptions.CurrentPage.HasValue && queryOptions.CurrentPage.Value > 0 ? queryOptions.CurrentPage.Value : 1;
            PageSize = queryOptions.PageSize.HasValue && queryOptions.PageSize.Value > 0 ? queryOptions.PageSize.Value : 10;

            Message = message;
        }

        public List<TData> Data { get; }
        
        public long ResultSetCount { get; }

        public long ResultCount => Data.Count;

        public int PageSize { get; }

        public int CurrentPage { get; }

        public int PageCount => (int)Math.Ceiling(ResultSetCount / (double)PageSize);

        public int NextPage => CurrentPage < PageCount ? CurrentPage + 1 : CurrentPage;

        public int PreviousPage => CurrentPage > 0 ? CurrentPage - 1 : 1;

        public int LastPage => PageCount;

        public string Message { get; }
    }
}
