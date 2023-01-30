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
    public class ApiHeadResponse : ApiResponse<dynamic>
    {
        [JsonConstructor]
        public ApiHeadResponse() { }

        public ApiHeadResponse(string? message = null, List<ApiResponseFailedItem>? failures = null) : base(null, message, failures) { }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Order = 0)]
        public Dictionary<string, string> Headers { get; set; } = new();

        [JsonIgnore]
        public Dictionary<string, string> CustomHeaders
        {
            get
            {
                return new Dictionary<string, string>(Headers.Where(o => o.Key.ToLower().StartsWith("x-")));
            }
        }
    }
}
