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
    public class ApiResponseFailedItem
    {
        [JsonConstructor]
        public ApiResponseFailedItem() { }

        public ApiResponseFailedItem(string message = null, dynamic itemId = null)
        {
            Message = message;
            ItemId = itemId;
        }

        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Message { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public dynamic ItemId { get; set; }
    }
}
