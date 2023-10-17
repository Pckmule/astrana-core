/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Database.Constants;
using Astrana.Core.Domain.Models.Database.Contracts;
using Astrana.Core.Extensions;
using System.Text.Json.Serialization;
using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Domain.Models.Database
{
    public sealed class MySqlConnectionString : ConnectionString, IMySqlConnectionString
    {
        [JsonConstructor]
        public MySqlConnectionString()
        {
            NameUnique = ModelProperties.MySqlConnectionString.NameUnique;
            NameSingularForm = ModelProperties.MySqlConnectionString.NameSingularForm;
            NamePluralForm = ModelProperties.MySqlConnectionString.NamePluralForm;
        }

        public MySqlConnectionString(string connectionString) : this()
        {
            Parse(connectionString);
        }

        public MySqlConnectionString(string hostAddress, int? hostAddressPort, string databaseName, string userId, string password) : base(hostAddress, hostAddressPort, databaseName, userId, password) { }

        public override void Parse(string connectionString)
        {
            var parts = connectionString.ToDictionary();

            if (parts.ContainsKey(ConnectionStringParts.MySql.Server))
            {
                HostAddress = parts[ConnectionStringParts.MySql.Server];
            }

            if (parts.ContainsKey(ConnectionStringParts.MySql.Port))
            {
                HostAddressPort = string.IsNullOrWhiteSpace(parts[ConnectionStringParts.MySql.Port]) ? null : int.Parse(parts[ConnectionStringParts.MySql.Port]);
            }

            if (parts.ContainsKey(ConnectionStringParts.MySql.Database))
            {
                DatabaseName = parts[ConnectionStringParts.MySql.Database];
            }

            if (parts.ContainsKey(ConnectionStringParts.MySql.Uid))
            {
                UserId = parts[ConnectionStringParts.MySql.Uid];
            }

            if (parts.ContainsKey(ConnectionStringParts.MySql.Password))
            {
                Password = parts[ConnectionStringParts.MySql.Password];
            }
        }

        public string GetString()
        {
            var parts = new List<string>();

            if (!string.IsNullOrWhiteSpace(HostAddress))
                parts.Add($"{ConnectionStringParts.MySql.Server}={HostAddress}");

            if (HostAddressPort.HasValue)
                parts.Add($"{ConnectionStringParts.MySql.Port}={HostAddressPort}");

            if (!string.IsNullOrWhiteSpace(DatabaseName))
                parts.Add($"{ConnectionStringParts.MySql.Database}={DatabaseName}");

            if (!string.IsNullOrWhiteSpace(UserId))
                parts.Add($"{ConnectionStringParts.MySql.Uid}={UserId}");

            if (!string.IsNullOrWhiteSpace(Password))
                parts.Add($"{ConnectionStringParts.MySql.Password}={Password}");

            return string.Join(";", parts);
        }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}