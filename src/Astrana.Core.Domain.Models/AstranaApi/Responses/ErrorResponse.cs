/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Astrana.Core.Domain.Models.AstranaApi.Responses
{
    /// <summary>
    /// Error response object to give more info with HTTP status code
    /// </summary>
    [DataContract]
    public class ErrorResponse
    {
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [Required]
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// A list of detailed errors
        /// </summary>
        /// <value>A list of detailed errors</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<ErrorResponseDetail> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorResponse {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions()
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                IgnoreNullValues = true
            });
        }
    }
}
