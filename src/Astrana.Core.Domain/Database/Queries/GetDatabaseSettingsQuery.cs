/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Configuration;
using Astrana.Core.Domain.Application.Configuration;
using Astrana.Core.Domain.Models.Database;
using Astrana.Core.Enums;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Database.Queries
{
    public class GetDatabaseSettingsQuery : IGetDatabaseSettingsQuery
    {
        private readonly ILogger<GetDatabaseSettingsQuery> _logger;
        private readonly IWebHostEnvironment _environment;
        
        private readonly IDataProtectionEncryptionUtility _dataProtectionEncryptionUtility;
        
        public GetDatabaseSettingsQuery(ILogger<GetDatabaseSettingsQuery> logger, IWebHostEnvironment environment,  IDataProtectionEncryptionUtility dataProtectionEncryptionUtility)
        {
            _logger = logger;
            _environment = environment;

            _dataProtectionEncryptionUtility = dataProtectionEncryptionUtility;
        }

        public DatabaseSettings Execute(Guid actioningUserId)
        {
            var appSettingsFilePath = Path.Join(_environment.ContentRootPath, Constants.Application.SettingsFileName);
            var appSettings = new ConfigurationManager(appSettingsFilePath, _dataProtectionEncryptionUtility).ApplicationSettings;

            var databaseSettings = new DatabaseSettings
            {
                DatabaseProvider = appSettings.DatabaseProvider,
                ConnectionString = new MsSqlServerConnectionString()
            };

            var connectionString = appSettings.ConnectionStrings[appSettings.DatabaseProvider.ToString()];

            if (string.IsNullOrWhiteSpace(connectionString))
                return databaseSettings;

            var decryptedConnectionString = appSettings.SetupMode == null ? _dataProtectionEncryptionUtility.DecryptString(connectionString) : connectionString;

            switch (appSettings.DatabaseProvider)
            {
                case DatabaseProvider.PostgreSQL:
                    databaseSettings.ConnectionString = new PostgreSqlConnectionString(decryptedConnectionString);
                    break;

                case DatabaseProvider.MySQL:
                    databaseSettings.ConnectionString = new MySqlConnectionString(decryptedConnectionString); 
                    break;

                case DatabaseProvider.MSSqlServer:
                    databaseSettings.ConnectionString = new MsSqlServerConnectionString(decryptedConnectionString);
                    break;
            }

            return databaseSettings;
        }
    }
}