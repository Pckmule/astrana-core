/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Domain.Models.Results.Enums;

namespace Astrana.Core.Domain.Models.Results
{
    public class AuthenticateResult: IAuthenticateResult
    {
        public AuthenticateResult(ResultOutcome outcome, string? token, string message = "")
        {
            Outcome = outcome;
            Token = token;
            Message = message;
        }

        public ResultOutcome Outcome { get; set; }
        
        public string Token { get; }

        public string Message { get; }

        public IEnumerable<IResultError> Errors { get; set; } = new List<IResultError>();
    }

    public class AuthenticateSuccessResult : AuthenticateResult
    {
        public AuthenticateSuccessResult(string token, string message = "") : base(ResultOutcome.Success, token, message) { }
    }

    public class AuthenticateFailResult : AuthenticateResult
    {
        public AuthenticateFailResult(string message = "") : base(ResultOutcome.Failure, null, message) { }
    }
}
