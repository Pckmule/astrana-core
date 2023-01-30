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
    public class ApiGetResponse<TData> : ApiResponse<TData>
    {
        [JsonConstructor]
        public ApiGetResponse() { }

        public ApiGetResponse(TData? data, string? message = null, List<ApiResponseFailedItem>? failures = null) : base(data, message, failures)
        {
            Data = data;
        }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Order = 0)]
        public long? ResultSetCount { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Order = 1)]
        public long? ResultCount { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Order = 2)]
        public long? PageSize { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Order = 3)]
        public long? PageCount { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Order = 4)]
        public long? CurrentPage { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Order = 5)]
        public string NextPage { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Order = 6)]
        public string PreviousPage { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Order = 7)]
        public string LastPage { get; set; }
    }
}
