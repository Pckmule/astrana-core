/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Domain.Models.Pagination
{
    public interface IPaginationInformation
    {
        long ResultSetCount { get; set; }

        long ResultCount { get; set; }

        int PageSize { get; set; }

        int CurrentPage { get; set; }

        int PageCount { get; }

        int NextPage { get; }

        int PreviousPage { get; }

        int LastPage { get; }
    }
}
