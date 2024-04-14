/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Domain.Models.Results.Enums;

namespace Astrana.Core.Domain.Models.Results
{
    public class ExecutionResult : IExecutionResult
    {
        public ExecutionResult(ResultOutcome outcome, string? message = "", string? resultCode = null)
        {
            Outcome = outcome;
            Message = message;
            ResultCode = resultCode;
        }

        public ResultOutcome Outcome { get; set; }

        public string? Message { get; set; }

        public string? ResultCode { get; set; }

        public IEnumerable<IResultError> Errors { get; set; } = new List<IResultError>();
    }

    public class ExecutionSuccessResult : ExecutionResult
    {
        public ExecutionSuccessResult(string? message = "", string? resultCode = null) : base(ResultOutcome.Success, message, resultCode) { }
    }

    public class ExecutionFailResult: ExecutionResult
    {
        public ExecutionFailResult(string? message = "", string? resultCode = null) : base(ResultOutcome.Failure, message, resultCode) { }
    }

    public class ExecutionResult<TData> : ExecutionResult, IExecutionResult<TData>
    {
        public ExecutionResult(ResultOutcome outcome, TData data, string? message = "", string? resultCode = null) : base(outcome, message, resultCode)
        {
            Data = data;
        }

        public TData Data { get; set; }
    }

    public class ExecutionSuccessResult<TData> : ExecutionResult<TData>
    {
        public ExecutionSuccessResult(TData data, string? message = "", string? resultCode = null) : base(ResultOutcome.Success, data, message, resultCode) { }
    }

    public class ExecutionFailResult<TData> : ExecutionResult<TData>
    {
        public ExecutionFailResult(TData queuedData, string? message = "", string? resultCode = null) : base(ResultOutcome.Failure, queuedData, message, resultCode) { }
    }
}
