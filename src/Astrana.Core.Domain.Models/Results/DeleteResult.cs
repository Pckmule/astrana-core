/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Domain.Models.Results.Enums;

namespace Astrana.Core.Domain.Models.Results
{
    public class DeleteResult : IDeleteResult
    {
        public DeleteResult(ResultOutcome outcome, long resultCount = 0, string? message = "", string? resultCode = null)
        {
            Outcome = outcome;
            Count = resultCount;
            Message = message;
            ResultCode = resultCode;
        }

        public ResultOutcome Outcome { get; set; }
        
        public long Count { get; set; }

        public string? Message { get; set; }

        public bool? SoftDeleted { get; set; }

        public string? ResultCode { get; set; }

        public IEnumerable<IResultError> Errors { get; set; } = new List<IResultError>();
    }

    public class DeleteResult<TData> : DeleteResult, IDeleteResult<TData>
    {
        public DeleteResult(ResultOutcome outcome, TData resultData, long resultCount = 0, string? message = "", string? resultCode = null): base(outcome, resultCount, message, resultCode)
        {
            Data = resultData;
        }

        public TData Data { get; set; }
    }

    public class DeleteSuccessResult : DeleteResult
    {
        public DeleteSuccessResult(long resultCount = 0, string? message = "", string? resultCode = null) : base(ResultOutcome.Success, resultCount, message, resultCode) { }
    }

    public class DeleteSuccessResult<TData> : DeleteResult<TData>
    {
        public DeleteSuccessResult(TData resultData, long resultCount = 0, string? message = "", string? resultCode = null) : base(ResultOutcome.Success, resultData, resultCount, message, resultCode) { }
    }

    public class DeleteFailResult : DeleteResult
    {
        public DeleteFailResult(long resultCount = 0, string? message = "", string? resultCode = null) : base(ResultOutcome.Success, resultCount, message, resultCode) { }
    }

    public class DeleteFailResult<TData> : DeleteResult<TData>
    {
        public DeleteFailResult(TData resultData, long resultCount = 0, string? message = "", string? resultCode = null) : base(ResultOutcome.Success, resultData, resultCount, message, resultCode) { }
    }
}
