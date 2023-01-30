/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Database.Constants;
using Astrana.Core.Domain.Models.Database.Contracts;
using Astrana.Core.Extensions;
using Astrana.Core.Validation;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Database
{
    public sealed class PostgreSqlConnectionString : ConnectionString, IPostgreSqlConnectionString
    {
        [JsonConstructor]
        public PostgreSqlConnectionString(): base()
        {
            NameUnique = ModelProperties.PostgreSqlConnectionString.NameUnique;
            NameSingularForm = ModelProperties.PostgreSqlConnectionString.NameSingularForm;
            NamePluralForm = ModelProperties.PostgreSqlConnectionString.NamePluralForm;
        }

        public PostgreSqlConnectionString(string connectionString) : this()
        {
            Parse(connectionString);
        }

        public PostgreSqlConnectionString(string hostAddress, int? hostAddressPort, string databaseName, string userId, string password) : base(hostAddress, hostAddressPort, databaseName, userId, password) { }

        public override void Parse(string connectionString)
        {
            var parts = connectionString.ToDictionary();

            if (parts.ContainsKey(ConnectionStringParts.PostgreSql.Host))
            {
                HostAddress = parts[ConnectionStringParts.PostgreSql.Host];
            }

            if (parts.ContainsKey(ConnectionStringParts.PostgreSql.Port))
            {
                HostAddressPort = string.IsNullOrWhiteSpace(parts[ConnectionStringParts.PostgreSql.Port]) ? null : int.Parse(parts[ConnectionStringParts.PostgreSql.Port]);
            }

            if (parts.ContainsKey(ConnectionStringParts.PostgreSql.Database))
            {
                DatabaseName = parts[ConnectionStringParts.PostgreSql.Database];
            }

            if (parts.ContainsKey(ConnectionStringParts.PostgreSql.UserId))
            {
                UserId = parts[ConnectionStringParts.PostgreSql.UserId];
            }

            if (parts.ContainsKey(ConnectionStringParts.PostgreSql.Password))
            {
                Password = parts[ConnectionStringParts.PostgreSql.Password];
            }
        }

        public string GetString()
        {
            var parts = new List<string>();

            if (!string.IsNullOrWhiteSpace(HostAddress))
                parts.Add($"{ConnectionStringParts.PostgreSql.Host}={HostAddress}");

            if (HostAddressPort.HasValue)
                parts.Add($"{ConnectionStringParts.PostgreSql.Port}={HostAddressPort}");

            if (!string.IsNullOrWhiteSpace(DatabaseName))
                parts.Add($"{ConnectionStringParts.PostgreSql.Database}={DatabaseName}");

            if (!string.IsNullOrWhiteSpace(UserId))
                parts.Add($"{ConnectionStringParts.PostgreSql.UserId}={UserId}");

            if (!string.IsNullOrWhiteSpace(Password))
                parts.Add($"{ConnectionStringParts.PostgreSql.Password}={Password}");

            return string.Join(";", parts);
        }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}