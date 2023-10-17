/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Configuration.Constants;
using Astrana.Core.Configuration.Exceptions;
using Astrana.Core.Enums;
using Astrana.Core.Extensions;
using Microsoft.Extensions.Configuration;

namespace Astrana.Core.Configuration.Extensions
{
    // ReSharper disable once InconsistentNaming
    public static class IConfigurationExtensions
    {
        public static bool HasKey(this IConfiguration configuration, string keyName)
        {
            return configuration.AsEnumerable().ToDictionary(x => x.Key, x => x.Value).ContainsKey(keyName);
        }

        public static bool IsSetupModeEnabled(this IConfiguration configuration)
        {
            return configuration.HasKey(ApplicationConfigurationKeys.SetupMode);
        }

        public static DatabaseProvider GetDatabaseProvider(this IConfiguration? configuration)
        {
            return configuration.GetDatabaseProviderString().ToEnum<DatabaseProvider>();
        }

        private static string GetDatabaseProviderString(this IConfiguration? configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            var databaseProviderName = configuration["DatabaseProvider"];

            if (string.IsNullOrWhiteSpace(databaseProviderName))
                throw new ApplicationConfigurationException("DatabaseProvider is invalid.");

            return databaseProviderName;
        }

        public static string GetConnectionStringByDatabaseProvider(this IConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            var databaseProviderName = configuration.GetDatabaseProviderString();

            var connectionString = configuration.GetConnectionString(databaseProviderName);

            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ApplicationConfigurationException($"{databaseProviderName} connection string is invalid.");

            return connectionString;
        }
    }
}
