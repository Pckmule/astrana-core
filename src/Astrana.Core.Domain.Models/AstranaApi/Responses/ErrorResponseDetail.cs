/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Runtime.Serialization;

namespace Astrana.Core.Domain.Models.AstranaApi.Responses
{
    /// <summary>
    /// Error detail
    /// </summary>
    [DataContract]
    public class ErrorResponseDetail
    {
        /// <summary>
        /// Gets or Sets ErrorType
        /// </summary>
        [DataMember(Name = "errorType", EmitDefaultValue = false)]
        public string ErrorType { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }
    }
}
