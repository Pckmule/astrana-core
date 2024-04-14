/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Configuration.Constants;
using Astrana.Core.Configuration.Exceptions;
using Astrana.Core.Settings.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Astrana.Core.Configuration
{
    public class ConfigurationManager
    {
        private readonly string _applicationSettingsFilePath;
        private readonly IDataProtectionEncryptionUtility _dataProtectionEncryptionUtility;

        private ApplicationSettings _applicationSettings = new();

        public ConfigurationManager(string applicationSettingsFilePath, IDataProtectionEncryptionUtility dataProtectionEncryptionUtility)
        {
            _applicationSettingsFilePath = applicationSettingsFilePath;
            _dataProtectionEncryptionUtility = dataProtectionEncryptionUtility;

            LoadApplicationSettingsAsync(applicationSettingsFilePath).Wait();
        }

        public ReadOnlyApplicationSettings ApplicationSettings => new(_applicationSettings);

        public async Task<bool> SecureAfterSetupAsync()
        {
            LoadApplicationSettingsAsync(_applicationSettingsFilePath).Wait();
            
            await EncryptApplicationSettingsFileAsync(_applicationSettingsFilePath);

            await RemoveSetupModeAsync();

            return true;
        }

        public async Task RemoveSetupModeAsync()
        {
            var applicationSettings = await ReadAppSettingsJsonFileAsync(_applicationSettingsFilePath);

            applicationSettings.SetupMode = null;

            await SaveAppSettingsJsonFileAsync(_applicationSettingsFilePath, applicationSettings);
        }

        public ApplicationSettings EncryptApplicationSettings(ApplicationSettings settings)
        {
            if (settings == null)
                throw new ApplicationConfigurationException("Configuration is null.");

            foreach (var connectionString in settings.ConnectionStrings)
            {
                settings.ConnectionStrings[connectionString.Key] = _dataProtectionEncryptionUtility.EncryptString(connectionString.Value);
            }

            var msSqlServerSinkSettings = settings.Serilog.WriteTo.FirstOrDefault(o => o.Name == ApplicationConfigurationKeys.SerilogSinkMsSqlServerName);
            if (msSqlServerSinkSettings != null && msSqlServerSinkSettings.Args.Any(o => o.Key == ApplicationConfigurationKeys.SerilogSinkMsSqlServerArgConnectionString))
            {
                msSqlServerSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkMsSqlServerArgConnectionString] = _dataProtectionEncryptionUtility.EncryptString(msSqlServerSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkMsSqlServerArgConnectionString].ToString()!);
            }

            var postgreSqlSinkSettings = settings.Serilog.WriteTo.FirstOrDefault(o => o.Name == ApplicationConfigurationKeys.SerilogSinkPostgreSqlName);
            if (postgreSqlSinkSettings != null && postgreSqlSinkSettings.Args.Any(o => o.Key == ApplicationConfigurationKeys.SerilogSinkPostgreSqlArgConnectionString))
            {
                postgreSqlSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkPostgreSqlArgConnectionString] = _dataProtectionEncryptionUtility.EncryptString(postgreSqlSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkPostgreSqlArgConnectionString].ToString()!);
            }

            var mySqlSinkSettings = settings.Serilog.WriteTo.FirstOrDefault(o => o.Name == ApplicationConfigurationKeys.SerilogSinkMySqlName);
            if (mySqlSinkSettings != null && mySqlSinkSettings.Args.Any(o => o.Key == ApplicationConfigurationKeys.SerilogSinkMySqlArgConnectionString))
            {
                mySqlSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkMySqlArgConnectionString] = _dataProtectionEncryptionUtility.EncryptString(mySqlSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkMySqlArgConnectionString].ToString()!);
            }

            return settings;
        }

        public async Task EncryptApplicationSettingsFileAsync(string applicationSettingsFilePath)
        {
            try
            {
                await SaveAppSettingsJsonFileAsync(applicationSettingsFilePath, EncryptApplicationSettings(_applicationSettings));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task LoadApplicationSettingsAsync(string applicationSettingsFilePath)
        {
            if (string.IsNullOrWhiteSpace(applicationSettingsFilePath))
                throw new ArgumentNullException(nameof(applicationSettingsFilePath));

            _applicationSettings = await ReadAppSettingsJsonFileAsync(applicationSettingsFilePath);
        }

        private static async Task<ApplicationSettings> ReadAppSettingsJsonFileAsync(string filePath)
        {
            try
            {
                await using var fileStream = File.OpenRead(filePath);

                return await JsonSerializer.DeserializeAsync<ApplicationSettings>(fileStream, new JsonSerializerOptions
                {
                    Converters = { new JsonStringEnumConverter() }

                }) ?? new ApplicationSettings();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private static async Task SaveAppSettingsJsonFileAsync(string filePath, ApplicationSettings applicationSettings)
        {
            try
            {
                await File.WriteAllTextAsync(filePath, JsonSerializer.Serialize(applicationSettings, new JsonSerializerOptions
                    {
                        Converters = { new JsonStringEnumConverter() },
                        WriteIndented = true,
                    })
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
