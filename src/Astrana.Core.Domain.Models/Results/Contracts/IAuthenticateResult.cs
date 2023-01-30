/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results.Enums;

namespace Astrana.Core.Domain.Models.Results.Contracts
{
    public interface IAuthenticateResult
    {
        ResultOutcome Outcome { get; set; }
        
        string? Token { get; }

        string Message { get; }

        IEnumerable<IResultError> Errors { get; set; }
    }
}
