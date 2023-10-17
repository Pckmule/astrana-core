/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Domain.Models.Results.Contracts
{
    public interface IGetResult<TData>
    {
        List<TData> Data { get; }

        long ResultSetCount { get; }

        long ResultCount { get; }

        int PageSize { get; }

        int CurrentPage { get; }

        int PageCount { get; }

        int NextPage { get; }

        int PreviousPage { get; }

        int LastPage { get; }

        string Message { get; }

        bool HasData { get; }
    }
}
