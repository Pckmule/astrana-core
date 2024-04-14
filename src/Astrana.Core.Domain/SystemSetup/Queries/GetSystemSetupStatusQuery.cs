/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Configuration;
using Astrana.Core.Data.Repositories.SystemSettings;
using Astrana.Core.Data.Repositories.UserAccounts;
using Astrana.Core.Data.Utilities;
using Astrana.Core.Domain.Application.Configuration;
using Astrana.Core.Domain.Models.Database;
using Astrana.Core.Domain.Models.SystemSettings.Options;
using Astrana.Core.Domain.Models.SystemSetup.Enums;
using Astrana.Core.Enums;
using Astrana.Core.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using SystemSettingDefinitions = Astrana.Core.Domain.Models.System.Constants.SettingDefinitions;

namespace Astrana.Core.Domain.SystemSetup.Queries
{
    public class GetSystemSetupStatusQuery : IGetSystemSetupStatusQuery
    {
        private readonly ILogger<GetSystemSetupStatusQuery> _logger;
        
        private readonly IWebHostEnvironment _environment;
        private readonly IDataProtectionEncryptionUtility _dataProtectionEncryptionUtility;
        private readonly ISystemSettingRepository<Guid> _systemSettingRepository;
        private readonly IUserAccountRepository<Guid> _userAccountRepository;
        private readonly IDatabaseChecker _databaseChecker;

        public GetSystemSetupStatusQuery(
            ILogger<GetSystemSetupStatusQuery> logger,
            IWebHostEnvironment environment,
            IDataProtectionEncryptionUtility dataProtectionEncryptionUtility,
            ISystemSettingRepository<Guid> systemSettingRepository, 
            IUserAccountRepository<Guid> userAccountRepository,
            IDatabaseChecker databaseChecker)
        {
            _logger = logger;

            _environment = environment;
            _dataProtectionEncryptionUtility = dataProtectionEncryptionUtility;
            _systemSettingRepository = systemSettingRepository;
            _userAccountRepository = userAccountRepository;
            _databaseChecker = databaseChecker;
        }

        public async Task<SystemSetupStatus> ExecuteAsync(Guid actioningUserId)
        {
            var systemSetupStatus = SystemSetupStatus.Complete;

            if (!IsDatabaseSetup() && !await IsInstanceUserSetup() && !await IsInstanceHostAddressSet())
            {
                systemSetupStatus = SystemSetupStatus.New;
            }
            else if (!IsDatabaseSetup() || !await IsInstanceUserSetup() || !await IsInstanceHostAddressSet())
            {
                systemSetupStatus = SystemSetupStatus.InProgress;
            }

            _logger.LogTrace($"Executed {nameof(GetSystemSetupStatusQuery).SplitOnUpperCase()}");

            return systemSetupStatus;
        }

        private bool IsDatabaseSetup()
        {
            return IsDatabaseConfigured() && IsDatabaseCreated();
        }

        private bool IsDatabaseConfigured()
        {
            var appSettingsFilePath = Path.Join(_environment.ContentRootPath, Constants.Application.SettingsFileName);

            var appSettings = new ConfigurationManager(appSettingsFilePath, _dataProtectionEncryptionUtility).ApplicationSettings;

            if (appSettings.DatabaseProvider == DatabaseProvider.Default)
                return false;

            var connectionString = appSettings.ConnectionStrings[appSettings.DatabaseProvider.ToString()];

            if (string.IsNullOrWhiteSpace(connectionString))
                return false;

            var decryptedConnectionString = appSettings.SetupMode == null ? _dataProtectionEncryptionUtility.DecryptString(connectionString) : connectionString;

            ConnectionString connectionStringModel;
            switch (appSettings.DatabaseProvider)
            {
                case DatabaseProvider.PostgreSQL:
                    connectionStringModel = new PostgreSqlConnectionString(decryptedConnectionString);
                    break;

                case DatabaseProvider.MySQL:
                    connectionStringModel = new MySqlConnectionString(decryptedConnectionString);
                    break;

                case DatabaseProvider.MSSqlServer:
                    connectionStringModel = new MsSqlServerConnectionString(decryptedConnectionString);
                    break;

                default:
                    connectionStringModel = null;
                    break;
            }

            if (connectionStringModel == null)
                return false;

            if (string.IsNullOrWhiteSpace(connectionStringModel.HostAddress))
                return false;

            if (string.IsNullOrWhiteSpace(connectionStringModel.DatabaseName))
                return false;

            if (string.IsNullOrWhiteSpace(connectionStringModel.UserId))
                return false;

            if (string.IsNullOrWhiteSpace(connectionStringModel.Password))
                return false;

            return true;
        }

        private bool IsDatabaseCreated()
        {
            return _databaseChecker.Exists();
        }

        private bool HasRunDatabaseMigrations()
        {
            return _databaseChecker.HasRunMigrations();
        }

        private async Task<bool> IsInstanceUserSetup()
        {
            var result = await _userAccountRepository.GetInstanceUserAccountAsync();

            return result != null;
        }

        private async Task<bool> IsInstanceHostAddressSet()
        {
            var result = await _systemSettingRepository.GetSystemSettingsAsync(new SystemSettingQueryOptions<Guid, Guid>()
            {
                Names = new List<string> { SystemSettingDefinitions.Names.HostName }
            });

            var hostName = result.Data.FirstOrDefault(o => o.Name == SystemSettingDefinitions.Names.HostName)?.ValueOrDefault;

            return !string.IsNullOrWhiteSpace(hostName);
        }
    }
}