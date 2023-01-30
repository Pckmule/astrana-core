/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Database.Contracts;
using Astrana.Core.Enums;
using Astrana.Core.Validation;
using Astrana.Core.Validation.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Database
{
    public class DatabaseSettings : BaseDomainModel, IDatabaseSettings
    {
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