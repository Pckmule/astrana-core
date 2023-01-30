/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Configuration.Constants;
using Astrana.Core.Configuration.Exceptions;
using Astrana.Core.Configuration.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Astrana.Core.Configuration
{
    public class JsonConfigurationEncrypter
    {
        private readonly List<string> _configurationFilePaths;

        public JsonConfigurationEncrypter(List<string>? configurationFilePaths = null)
        {
            _configurationFilePaths = configurationFilePaths ?? new List<string>();
        }

        public async Task EncryptAsync(List<string>? configurationFiles = null)
        {
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
                        var settings = await JsonSerializer.DeserializeAsync<ApplicationSettings>(fileStream, new JsonSerializerOptions()
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
                            settings.ConnectionStrings[connectionString.Key] = EncryptionUtility.EncryptString(connectionString.Value);
                        }

                        var msSqlServerSinkSettings = settings.Serilog.WriteTo.FirstOrDefault(o => o.Name == ApplicationConfigurationKeys.SerilogSinkMsSqlServerName);
                        if (msSqlServerSinkSettings != null && msSqlServerSinkSettings.Args.Any(o => o.Key == ApplicationConfigurationKeys.SerilogSinkMsSqlServerArgConnectionString))
                        {
                            msSqlServerSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkMsSqlServerArgConnectionString] = EncryptionUtility.EncryptString(msSqlServerSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkMsSqlServerArgConnectionString].ToString()!);
                        }

                        var postgreSqlSinkSettings = settings.Serilog.WriteTo.FirstOrDefault(o => o.Name == ApplicationConfigurationKeys.SerilogSinkPostgreSqlName);
                        if (postgreSqlSinkSettings != null && postgreSqlSinkSettings.Args.Any(o => o.Key == ApplicationConfigurationKeys.SerilogSinkPostgreSqlArgConnectionString))
                        {
                            postgreSqlSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkPostgreSqlArgConnectionString] = EncryptionUtility.EncryptString(postgreSqlSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkPostgreSqlArgConnectionString].ToString()!);
                        }

                        var mySqlSinkSettings = settings.Serilog.WriteTo.FirstOrDefault(o => o.Name == ApplicationConfigurationKeys.SerilogSinkMySqlName);
                        if (mySqlSinkSettings != null && mySqlSinkSettings.Args.Any(o => o.Key == ApplicationConfigurationKeys.SerilogSinkMySqlArgConnectionString))
                        {
                            mySqlSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkMySqlArgConnectionString] = EncryptionUtility.EncryptString(mySqlSinkSettings.Args[ApplicationConfigurationKeys.SerilogSinkMySqlArgConnectionString].ToString()!);
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
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}