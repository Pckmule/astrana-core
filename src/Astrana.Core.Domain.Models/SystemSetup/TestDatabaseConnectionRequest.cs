/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.SystemSetup.Constants;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Attributes;
using System.ComponentModel.DataAnnotations;
using Astrana.Core.Enums;

namespace Astrana.Core.Domain.Models.SystemSetup
{
    public class TestDatabaseConnectionRequest : InputModelBase, ITestDatabaseConnectionRequest
    {
        [RequiredEnum]
        public DatabaseProvider DatabaseProvider { get; set; }

        [Required]
        [MinLength(ModelProperties.TestDatabaseConnectionRequest.MinimumDatabaseUsernameLength)]
        [MaxLength(ModelProperties.TestDatabaseConnectionRequest.MaximumDatabaseUsernameLength)]
        public string DatabaseUsername { get; set; }

        [Required]
        [MinLength(ModelProperties.TestDatabaseConnectionRequest.MinimumDatabasePasswordLength)]
        [MaxLength(ModelProperties.TestDatabaseConnectionRequest.MaximumDatabasePasswordLength)]
        [DataType(DataType.Password)]
        public string DatabasePassword { get; set; }

        [Required]
        [MinLength(ModelProperties.TestDatabaseConnectionRequest.MinimumDatabaseHostLength)]
        [MaxLength(ModelProperties.TestDatabaseConnectionRequest.MaximumDatabaseHostLength)]
        public string DatabaseHost { get; set; }

        public int? DatabaseHostPort { get; set; }

        [Required]
        [MinLength(ModelProperties.TestDatabaseConnectionRequest.MinimumDatabaseNameLength)]
        [MaxLength(ModelProperties.TestDatabaseConnectionRequest.MaximumDatabaseNameLength)]
        public string DatabaseName { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
