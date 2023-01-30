/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Domain.Models.Results.Enums;

namespace Astrana.Core.Domain.Models.Results
{
    public class AddResult : IAddResult
    {
        public AddResult(ResultOutcome outcome, long resultCount = 0, string message = "", string? resultCode = null)
        {
            Outcome = outcome;
            Count = resultCount;
            Message = message;
            ResultCode = resultCode;
        }

        public ResultOutcome Outcome { get; set; }

        public long Count { get; set; }

        public string Message { get; set; }

        public string? ResultCode { get; set; }

        public IEnumerable<IResultError> Errors { get; set; } = new List<IResultError>();
    }

    public class AddResult<TData> : AddResult, IAddResult<TData>
    {
        public AddResult(ResultOutcome outcome, TData resultData, long resultCount = 0, string message = "", string? resultCode = null) :base(outcome, resultCount, message, resultCode)
        {
            Data = resultData;
        }

        public TData Data { get; set; }
    }

    public class AddSuccessResult : AddResult
    {
        public AddSuccessResult(long resultCount = 0, string message = "", string? resultCode = null) : base(ResultOutcome.Success, resultCount, message, resultCode) { }
    }

    public class AddSuccessResult<TQueuedData> : AddResult<TQueuedData>
    {
        public AddSuccessResult(TQueuedData resultData, long resultCount = 0, string message = "", string? resultCode = null) : base(ResultOutcome.Success, resultData, resultCount, message, resultCode) { }
    }

    public class AddPartialSuccessResult : AddResult
    {
        public AddPartialSuccessResult(long resultCount = 0, string message = "", string? resultCode = null) : base(ResultOutcome.PartialSuccess, resultCount, message, resultCode) { }
    }

    public class AddPartialSuccessResult<TQueuedData> : AddResult<TQueuedData>
    {
        public AddPartialSuccessResult(TQueuedData resultData, long resultCount = 0, string message = "", string? resultCode = null) : base(ResultOutcome.PartialSuccess, resultData, resultCount, message, resultCode) { }
    }

    public class AddFailResult : AddResult
    {
        public AddFailResult(long resultCount = 0, string message = "", string? resultCode = null) : base(ResultOutcome.Failure, resultCount, message, resultCode) { }
    }

    public class AddFailResult<TQueuedData> : AddResult<TQueuedData>
    {
        public AddFailResult(TQueuedData resultData, long resultCount = 0, string message = "", string? resultCode = null) : base(ResultOutcome.Failure, resultData, resultCount, message, resultCode) { }
    }
}
