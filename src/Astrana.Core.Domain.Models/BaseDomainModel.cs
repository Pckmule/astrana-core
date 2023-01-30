/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.System.Contracts;
using Astrana.Core.Validation;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models
{
    public abstract class BaseDomainModel : IValidatable
    {
        [JsonIgnore]
        public string? NameUnique { get; set; }

        [JsonIgnore]
        public string? NameSingularForm { get; set; }

        [JsonIgnore]
        public string? NamePluralForm { get; set; }

        public virtual EntityValidationResult Validate()
        {
            throw new NotImplementedException();
        }

        [JsonIgnore]
        public bool IsValid  => Validate().IsSuccess;
    }
}
