/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Database.Contracts;
using Astrana.Core.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Database
{
    // Value Object?
    public class DatabaseSettings : DomainEntity, IDatabaseSettings
    {
        [JsonConstructor]
        public DatabaseSettings() { }

        [RequiredEnum]
        public DatabaseProvider DatabaseProvider { get; set; }

        [Required]
        public ConnectionString ConnectionString { get; set; }

        public virtual EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}