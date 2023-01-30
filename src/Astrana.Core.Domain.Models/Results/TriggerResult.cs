/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Domain.Models.Results
{
    public class TriggerResult<T> : ITriggerResult<T>
    {
        public TriggerResult(bool success, T resultData, string message = "")
        {
            Success = success;
            Data = resultData;
            Message = message;
        }

        public bool Success { get; set; }

        public T Data { get; set; }

        public string Message { get; set; }
    }

    public class TriggerSuccessResult<T> : TriggerResult<T>
    {
        public TriggerSuccessResult(T resultData, string message = "") : base(true, resultData, message) { }
    }

    public class TriggerFailResult<T> : TriggerResult<T>
    {
        public TriggerFailResult(T resultData, string message = "") : base(false, resultData, message) { }
    }
}
