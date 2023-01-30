/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Domain.Models.Results
{
    public class CountResult : ICountResult
    {
        public CountResult(long count, string message = "")
        {
            Count = count;
            Message = message;
        }

        public long Count { get; }

        public string Message { get; }
    }
}
