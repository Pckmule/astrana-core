/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Domain.Models.Results
{
    public class EnqueueResult<TQueuedData> : IEnqueueResult<TQueuedData>
    {
        public EnqueueResult(bool success, TQueuedData queuedData, long queuedCount = 0)
        {
            Success = success;
            QueuedData = queuedData;
            QueuedCount = queuedCount;
        }

        public bool Success { get; set; }

        public TQueuedData QueuedData { get; set; }

        public long QueuedCount { get; set; }
    }

    public class EnqueueSuccessResult<TQueuedData> : EnqueueResult<TQueuedData>
    {
        public EnqueueSuccessResult(TQueuedData queuedData, long queuedCount = 0) : base(true, queuedData, queuedCount) { }
    }

    public class EnqueueFailResult<TQueuedData> : EnqueueResult<TQueuedData>
    {
        public EnqueueFailResult(TQueuedData queuedData, long queuedCount = 0) : base(false, queuedData, queuedCount) { }
    }
}
