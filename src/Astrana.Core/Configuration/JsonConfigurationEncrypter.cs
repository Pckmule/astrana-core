/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Text.Json;
using System.Text.Json.Serialization;
using Astrana.Core.Configuration.Constants;
using Astrana.Core.Configuration.Exceptions;

namespace Astrana.Core.Configuration
{
    public class JsonConfigurationEncrypter
    {
        private readonly List<string> _configurationFilePaths;

        public JsonConfigurationEncrypter(List<string>? configurationFilePaths = null)
        {
            _configurationFilePaths = configurationFilePaths ?? new List<string>();
        }

        public async Task EncryptAsync(IDataProtectionEncryptionUtility dataProtectionEncryptionUtility, List<string>? configurationFiles = null)
        {
            if (dataProtectionEncryptionUtility == null)
                throw new ArgumentNullException(nameof(dataProtectionEncryptionUtility));

            configurationFiles ??= _configurationFilePaths;

            foreach (var configurationFile in configurationFiles)
            {
                if (!File.Exists(configurationFile))
                    throw new FileNotFoundException($"Configuration file not found: {configurationFile}");
            }

            foreach (var configurationFile in configurationFiles)
            {
                try
                {
                    string encryptedContents;

                    await using (var fileStream = File.OpenRead(configurationFile))
                    {
                        var settings = await JsonSerializer.DeserializeAsync<Core.Settings.Models.ApplicationSettings>(fileStream, new JsonSerializerOptions()
                        {
                            Converters =
                            {
                                new JsonStringEnumConverter()
                            }
                        });

                        if (settings == null)
                            throw new ApplicationConfigurationException("Configuration is null.");

                        foreach (var connectionString in settings.ConnectionStrings)
                        {
                            settings.ConnectionStrings[connectionString.Key] = dataProtectionEncryptionUtility.EncryptString(connectionString.Value);
                        }

                        var msSqlServerSinkSettings = settings.Serilog.WriteTo.FirstOrDefault(o => o.Name == ApplicationConfigurationKeys.SerilogSinkMsSqlServerName);
                        if (msSqlServerSinkSettings != null && msSqlServerSinkSettings.Args.Any(o => o.Key == ApplicationConfigurationKeys.SerilogSinkMsSqlServerArgConnectionString))
                        {
                            msSqlServerSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkMsSqlServerArgConnectionString] = dataProtectionEncryptionUtility.EncryptString(msSqlServerSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkMsSqlServerArgConnectionString].ToString()!);
                        }

                        var postgreSqlSinkSettings = settings.Serilog.WriteTo.FirstOrDefault(o => o.Name == ApplicationConfigurationKeys.SerilogSinkPostgreSqlName);
                        if (postgreSqlSinkSettings != null && postgreSqlSinkSettings.Args.Any(o => o.Key == ApplicationConfigurationKeys.SerilogSinkPostgreSqlArgConnectionString))
                        {
                            postgreSqlSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkPostgreSqlArgConnectionString] = dataProtectionEncryptionUtility.EncryptString(postgreSqlSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkPostgreSqlArgConnectionString].ToString()!);
                        }

                        var mySqlSinkSettings = settings.Serilog.WriteTo.FirstOrDefault(o => o.Name == ApplicationConfigurationKeys.SerilogSinkMySqlName);
                        if (mySqlSinkSettings != null && mySqlSinkSettings.Args.Any(o => o.Key == ApplicationConfigurationKeys.SerilogSinkMySqlArgConnectionString))
                        {
                            mySqlSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkMySqlArgConnectionString] = dataProtectionEncryptionUtility.EncryptString(mySqlSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkMySqlArgConnectionString].ToString()!);
                        }

                        encryptedContents = JsonSerializer.Serialize(settings, new JsonSerializerOptions
                        {
                            Converters =
                            {
                                new JsonStringEnumConverter()
                            },
                            WriteIndented = true
                        });
                    }

                    await File.WriteAllTextAsync(configurationFile, encryptedContents);
                }
                catch (Exception ex)
                {
                    // TODO: _logger.LogError(ex, ex.Message);

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}