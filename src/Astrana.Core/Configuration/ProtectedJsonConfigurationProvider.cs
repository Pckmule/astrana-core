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
    public class ProtectedJsonConfigurationProvider : JsonConfigurationProvider
    {
        public ProtectedJsonConfigurationProvider(ProtectedJsonConfigurationSource source) : base(source) { }

        public override void Load(Stream stream)
        {
            base.Load(stream);

            Data[ApplicationConfigurationKeys.ConnectionStringsPostgreSql] = EncryptionUtility.DecryptString(Data[ApplicationConfigurationKeys.ConnectionStringsPostgreSql]);
            Data[ApplicationConfigurationKeys.ConnectionStringsMySql] = EncryptionUtility.DecryptString(Data[ApplicationConfigurationKeys.ConnectionStringsMySql]);
            Data[ApplicationConfigurationKeys.ConnectionStringsMsSqlServer] = EncryptionUtility.DecryptString(Data[ApplicationConfigurationKeys.ConnectionStringsMsSqlServer]);

            var serilogPostgreSqlIndex = GetSerilogSinkIndex(ApplicationConfigurationKeys.SerilogSinkPostgreSqlName);
            if (serilogPostgreSqlIndex != null)
            {
                Data[string.Format(ApplicationConfigurationKeys.SerilogWriteToPostgreSqlArgsConnectionString, serilogPostgreSqlIndex)] = EncryptionUtility.DecryptString(Data[string.Format(ApplicationConfigurationKeys.SerilogWriteToPostgreSqlArgsConnectionString, serilogPostgreSqlIndex)]);
            }

            var serilogMySqlIndex = GetSerilogSinkIndex(ApplicationConfigurationKeys.SerilogSinkMySqlName);
            if (serilogMySqlIndex != null)
            {
                Data[string.Format(ApplicationConfigurationKeys.SerilogWriteToMySqlArgsConnectionString, serilogMySqlIndex)] = EncryptionUtility.DecryptString(Data[string.Format(ApplicationConfigurationKeys.SerilogWriteToMySqlArgsConnectionString, serilogMySqlIndex)]);
            }

            var serilogMsSqlIndex = GetSerilogSinkIndex(ApplicationConfigurationKeys.SerilogSinkMsSqlServerName);
            if (serilogMsSqlIndex != null)
            {
                Data[string.Format(ApplicationConfigurationKeys.SerilogWriteToMsSqlServerArgsConnectionString, serilogMsSqlIndex)] = EncryptionUtility.DecryptString(Data[string.Format(ApplicationConfigurationKeys.SerilogWriteToMsSqlServerArgsConnectionString, serilogMsSqlIndex)]);
            }
        }

        private string? GetSerilogSinkIndex(string sinkName)
        {
            try
            {
                var setting = Data.FirstOrDefault(o => o.Key.StartsWith($"{ApplicationConfigurationKeys.SerilogWriteTo}:") && o.Key.EndsWith(":Name") && o.Value == sinkName);

                return setting.Key.Replace($"{ApplicationConfigurationKeys.SerilogWriteTo}:", "").Replace(":Name", "");
            }
            catch (Exception)
            {
                return null;
            }
        }
    }

    public class ProtectedJsonConfigurationSource : JsonConfigurationSource
    {
        public override IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            EnsureDefaults(builder);

            return new ProtectedJsonConfigurationProvider(this);
        }
    }

    public static class ProtectedJsonConfigurationExtensions
    {
        public static IConfigurationBuilder AddProtectedJsonFile(this IConfigurationBuilder builder, string path, bool optional = true, bool reloadOnChange = true)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("File path must be a non-empty string.");

            var source = new ProtectedJsonConfigurationSource
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
