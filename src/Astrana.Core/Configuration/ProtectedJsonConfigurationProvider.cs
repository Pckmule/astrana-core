/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Configuration.Constants;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace Astrana.Core.Configuration
{
    public sealed class ProtectedJsonConfigurationProvider : JsonConfigurationProvider
    {
        private readonly IDataProtectionEncryptionUtility _dataProtectionEncryptionUtility;

        public ProtectedJsonConfigurationProvider(ProtectedJsonConfigurationSource source, IDataProtectionEncryptionUtility dataProtectionEncryptionUtility) : base(source)
        {
            _dataProtectionEncryptionUtility = dataProtectionEncryptionUtility;
        }

        public override void Load(Stream stream)
        {
            base.Load(stream);

            // NOTE: Setup Mode
            /*  The setup mode setting should only exist in the application settings during the initial installation
                and setup of the Astrana application.                

                Application settings are temporarily stored in plain text at the start of the installation process, 
                and are encrypted during the installation process.

                Therefore, if the setup mode setting is detected, decryption of protected settings is not required and 
                will not be performed.
            */

            if (Data.ContainsKey(ApplicationConfigurationKeys.SetupMode))
                return;

            if(Data.ContainsKey(ApplicationConfigurationKeys.ConnectionStringsPostgreSql))
                Data[ApplicationConfigurationKeys.ConnectionStringsPostgreSql] = _dataProtectionEncryptionUtility.DecryptString(Data[ApplicationConfigurationKeys.ConnectionStringsPostgreSql] ?? string.Empty);

            if (Data.ContainsKey(ApplicationConfigurationKeys.ConnectionStringsMySql))
                Data[ApplicationConfigurationKeys.ConnectionStringsMySql] = _dataProtectionEncryptionUtility.DecryptString(Data[ApplicationConfigurationKeys.ConnectionStringsMySql] ?? string.Empty);

            if (Data.ContainsKey(ApplicationConfigurationKeys.ConnectionStringsMsSqlServer))
                Data[ApplicationConfigurationKeys.ConnectionStringsMsSqlServer] = _dataProtectionEncryptionUtility.DecryptString(Data[ApplicationConfigurationKeys.ConnectionStringsMsSqlServer] ?? string.Empty);

            GetSerilogSinkIndex(ApplicationConfigurationKeys.SerilogSinkPostgreSqlName, out var serilogPostgreSqlIndex);
            if (serilogPostgreSqlIndex != null)
            {
                var sinkKey = string.Format(ApplicationConfigurationKeys.SerilogWriteToPostgreSqlArgsConnectionString, serilogPostgreSqlIndex);
                if (Data.ContainsKey(sinkKey))
                {
                    Data[sinkKey] = _dataProtectionEncryptionUtility.DecryptString(Data[sinkKey] ?? string.Empty);
                }
            }

            GetSerilogSinkIndex(ApplicationConfigurationKeys.SerilogSinkMySqlName, out var serilogMySqlIndex);
            if (serilogMySqlIndex != null)
            {
                var sinkKey = string.Format(ApplicationConfigurationKeys.SerilogWriteToMySqlArgsConnectionString, serilogMySqlIndex);
                if (Data.ContainsKey(sinkKey))
                {
                    Data[sinkKey] = _dataProtectionEncryptionUtility.DecryptString(Data[sinkKey] ?? string.Empty);
                }
            }

            GetSerilogSinkIndex(ApplicationConfigurationKeys.SerilogSinkMsSqlServerName, out var serilogMsSqlIndex);
            if (serilogMsSqlIndex != null)
            {
                var sinkKey = string.Format(ApplicationConfigurationKeys.SerilogWriteToMsSqlServerArgsConnectionString, serilogMsSqlIndex);
                if (Data.ContainsKey(sinkKey))
                {
                    Data[sinkKey] = _dataProtectionEncryptionUtility.DecryptString(Data[sinkKey] ?? string.Empty);
                }
            }
        }

        private bool GetSerilogSinkIndex(string sinkName, out string? serilogSinkIndex)
        {
            try
            {
                var setting = Data.FirstOrDefault(o => o.Key.StartsWith($"{ApplicationConfigurationKeys.SerilogWriteTo}:") && o.Key.EndsWith(":Name") && o.Value == sinkName);

                serilogSinkIndex = setting.Key.Replace($"{ApplicationConfigurationKeys.SerilogWriteTo}:", "").Replace(":Name", "");
                
                return true;
            }
            catch (Exception)
            {
                serilogSinkIndex = null;
            }

            return false;
        }
    }

    public class ProtectedJsonConfigurationSource : JsonConfigurationSource
    {
        private readonly IDataProtectionEncryptionUtility _dataProtectionEncryptionUtility;

        public ProtectedJsonConfigurationSource(IDataProtectionEncryptionUtility dataProtectionEncryptionUtility)
        {
            _dataProtectionEncryptionUtility = dataProtectionEncryptionUtility;
        }

        public override IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            EnsureDefaults(builder);

            return new ProtectedJsonConfigurationProvider(this, _dataProtectionEncryptionUtility);
        }
    }

    public static class ProtectedJsonConfigurationExtensions
    {
        public static IConfigurationBuilder AddProtectedJsonFile(this IConfigurationBuilder builder, IDataProtectionEncryptionUtility dataProtectionEncryptionUtility, string path, bool optional = true, bool reloadOnChange = true)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("File path must be a non-empty string.");

            var source = new ProtectedJsonConfigurationSource(dataProtectionEncryptionUtility)
            {
                FileProvider = null,
                Path = path,
                Optional = optional,
                ReloadOnChange = reloadOnChange
            };

            source.ResolveFileProvider();

            builder.Add(source);

            return builder;
        }
    }
}
