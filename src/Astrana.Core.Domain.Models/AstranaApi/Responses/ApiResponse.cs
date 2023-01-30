/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.AstranaApi.Responses
{
    [DataContract]
    public class ApiResponse<TData>
    {
        [JsonConstructor]
        public ApiResponse()
        {
            Message = null;
            Failures = new List<ApiResponseFailedItem>();
        }

        public ApiResponse(TData? data, string? message = null, IList<ApiResponseFailedItem>? failures = null)
        {
            Data = data;
            Message = !string.IsNullOrWhiteSpace(message) ? message : null;
            Failures = failures;
        }

        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string? Message { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public TData? Data { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public IList<ApiResponseFailedItem>? Failures { get; set; }
    }
}
