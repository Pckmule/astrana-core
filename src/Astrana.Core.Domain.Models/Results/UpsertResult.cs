/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Domain.Models.Results
{
    public class UpsertResult<TData> : IUpsertResult<TData>
    {
        public UpsertResult(TData resultData, int resultCountAdded = 0, int resultCountUpdated = 0, string message = "Operation Successful.")
        {
            Data = resultData;
            CountAdded = resultCountAdded;
            CountUpdated = resultCountUpdated;
            Message = message;
        }

        public TData Data { get; }

        public int CountAdded { get; }

        public int CountUpdated { get; }

        public int Count => CountAdded + CountUpdated;

        public string Message { get; }

        public IEnumerable<IResultError> Errors { get; set; } = new List<IResultError>();
    }
}
