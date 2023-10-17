/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Database.Constants;
using Astrana.Core.Domain.Models.Database.Contracts;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Domain.Models.Database
{
    public abstract class ConnectionString : DomainEntity, IConnectionString
    {
        [JsonConstructor]
        protected ConnectionString() { }

        protected ConnectionString(string connectionString) : this() => Parse(connectionString);

        protected ConnectionString(string hostAddress, int? hostAddressPort, string databaseName, string userId, string password) : this()
        {
            HostAddress = hostAddress;
            HostAddressPort = hostAddressPort;
            DatabaseName = databaseName;
            UserId = userId;
            Password = password;
        }

        [Required]
        [MinLength(ModelProperties.ConnectionString.MinimumHostAddressLength)]
        [MaxLength(ModelProperties.ConnectionString.MaximumHostAddressLength)]
        public string HostAddress { get; set; }

        [MinLength(ModelProperties.ConnectionString.MinimumHostAddressPortLength)]
        [MaxLength(ModelProperties.ConnectionString.MaximumHostAddressPortLength)]
        public int? HostAddressPort { get; set; }

        [Required]
        [MinLength(ModelProperties.ConnectionString.MinimumDatabaseNameLength)]
        [MaxLength(ModelProperties.ConnectionString.MaximumDatabaseNameLength)]
        public string DatabaseName { get; set; }

        [Required]
        [MinLength(ModelProperties.ConnectionString.MinimumUsernameLength)]
        [MaxLength(ModelProperties.ConnectionString.MaximumUsernameLength)]
        public string UserId { get; set; }

        [Required]
        [MinLength(ModelProperties.ConnectionString.MinimumPasswordLength)]
        [MaxLength(ModelProperties.ConnectionString.MaximumPasswordLength)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public abstract void Parse(string connectionString);

        public new virtual EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}