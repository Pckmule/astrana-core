/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Database.Constants;
using Astrana.Core.Domain.Models.Database.Contracts;
using Astrana.Core.Extensions;
using Astrana.Core.Framework.Model.Validation;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Database
{
    public sealed class MsSqlServerConnectionString : ConnectionString, IMsSqlServerConnectionString
    {
        [JsonConstructor]
        public MsSqlServerConnectionString() { }

        public MsSqlServerConnectionString(string connectionString) : this()
        {
            Parse(connectionString);
        }

        public MsSqlServerConnectionString(string hostAddress, int? hostAddressPort, string databaseName, string userId, string password, bool encryptConnection = true, bool trustServerCertificate = true) : base(hostAddress, hostAddressPort, databaseName, userId, password) 
        {
            Encrypt = encryptConnection;
            TrustServerCertificate = trustServerCertificate;
        }

        public bool Encrypt { get; set; }

        public bool TrustServerCertificate { get; set; }

        public override void Parse(string connectionString)
        {
            var parts = connectionString.ToDictionary();

            if (parts.ContainsKey(ConnectionStringParts.MsSqlServer.Server))
            {
                var addressParts = parts[ConnectionStringParts.MsSqlServer.Server].Split(',');

                HostAddress = addressParts[0];

                if (addressParts.Length > 1)
                {
                    HostAddressPort = string.IsNullOrWhiteSpace(addressParts[1]) ? null : int.Parse(addressParts[1]);
                }
            }

            if (parts.ContainsKey(ConnectionStringParts.MsSqlServer.Database))
            {
                DatabaseName = parts[ConnectionStringParts.MsSqlServer.Database];
            }

            if (parts.ContainsKey(ConnectionStringParts.MsSqlServer.UserId))
            {
                UserId = parts[ConnectionStringParts.MsSqlServer.UserId];
            }

            if (parts.ContainsKey(ConnectionStringParts.MsSqlServer.Password))
            {
                Password = parts[ConnectionStringParts.MsSqlServer.Password];
            }

            if (parts.ContainsKey(ConnectionStringParts.MsSqlServer.Encrypt))
            {
                Encrypt = parts[ConnectionStringParts.MsSqlServer.Encrypt].ToBool();
            }

            if (parts.ContainsKey(ConnectionStringParts.MsSqlServer.TrustServerCertificate))
            {
                TrustServerCertificate = parts[ConnectionStringParts.MsSqlServer.TrustServerCertificate].ToBool();
            }
        }

        public string GetString()
        {
            var parts = new List<string>();

            if (!string.IsNullOrWhiteSpace(HostAddress) && HostAddressPort.HasValue)
            {
                parts.Add($"{ConnectionStringParts.MsSqlServer.Server}={HostAddress},{HostAddressPort}");
            }
            else if (!HostAddressPort.HasValue)
            {
                parts.Add($"{ConnectionStringParts.MsSqlServer.Server}={HostAddress}");
            }

            if (!string.IsNullOrWhiteSpace(DatabaseName))
                parts.Add($"{ConnectionStringParts.MsSqlServer.Database}={DatabaseName}");

            if (!string.IsNullOrWhiteSpace(UserId))
                parts.Add($"{ConnectionStringParts.MsSqlServer.UserId}={UserId}");

            if (!string.IsNullOrWhiteSpace(Password))
                parts.Add($"{ConnectionStringParts.MsSqlServer.Password}={Password}");

            parts.Add($"{ConnectionStringParts.MsSqlServer.Encrypt}={Encrypt}");
            parts.Add($"{ConnectionStringParts.MsSqlServer.TrustServerCertificate}={TrustServerCertificate}");

            return string.Join(";", parts);
        }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}