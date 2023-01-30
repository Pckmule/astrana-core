/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Configuration;
using Astrana.Core.Domain.Models.Database;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Database.Queries
{
    public class GetDatabaseSettingsQuery : IGetDatabaseSettingsQuery
    {
        private readonly ILogger<GetDatabaseSettingsQuery> _logger;
        private readonly IWebHostEnvironment _environment;

        public GetDatabaseSettingsQuery(ILogger<GetDatabaseSettingsQuery> logger, IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }

        public DatabaseSettings Execute(Guid actioningUserId)
        {
            var appSettingsFilePath = Path.Join(_environment.ContentRootPath, Constants.Application.SettingsFileName);
            var appSettings = new ConfigurationManager(appSettingsFilePath).ApplicationSettings;

            var databaseSettings = new DatabaseSettings()
            {
                DatabaseProvider = appSettings.DatabaseProvider,
                ConnectionString = new MsSqlServerConnectionString()
            };

            var connectionString = appSettings.ConnectionStrings[appSettings.DatabaseProvider.ToString()];

            if (string.IsNullOrWhiteSpace(connectionString))
                return databaseSettings;

            switch (appSettings.DatabaseProvider)
            {
                case Enums.DatabaseProvider.PostgreSQL:
                    databaseSettings.ConnectionString = new PostgreSqlConnectionString(EncryptionUtility.DecryptString(connectionString));
                    break;

                case Enums.DatabaseProvider.MySQL:
                    databaseSettings.ConnectionString = new MySqlConnectionString(EncryptionUtility.DecryptString(connectionString)); 
                    break;

                case Enums.DatabaseProvider.MSSqlServer:
                    databaseSettings.ConnectionString = new MsSqlServerConnectionString(EncryptionUtility.DecryptString(connectionString));
                    break;
            }

            return databaseSettings;
        }
    }
}