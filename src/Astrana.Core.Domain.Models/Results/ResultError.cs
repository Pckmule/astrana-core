/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.Models.Results.Contracts;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Results
{
    public class ResultError : IResultError
    {
        [JsonConstructor]
        public ResultError()
        {
            TargetId = "Unknown";
            Reason = "Something went wrong.";
            Code = ErrorCodes.Default;
        }

        public ResultError(string targetId, string reason, string code = ErrorCodes.Default)
        {
            TargetId = targetId;
            Reason = reason;
            Code = code;
        }

        [Required]
        public string TargetId { get; set; }
        
        [Required]
        public string Reason { get; set; }

        public string Code { get; set; }
    }
}
