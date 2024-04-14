/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Application.ApplicationSettings.Models;
using Astrana.Core.Domain.Application.Configuration.Attributes;
using Astrana.Core.Domain.Application.Logging.Models.Serilog;
using Astrana.Core.Domain.Application.Settings.Models;
using Astrana.Core.Enums;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Astrana.Core.Settings.Models
{
    public class ApplicationSettings
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("SetupMode")]
        public string SetupMode { get; set; }

        [JsonPropertyName("AllowedHosts")]
        public string AllowedHosts { get; set; } = "*";

        [JsonPropertyName("Logging")]
        public ApplicationLoggingSettings Logging { get; set; } = new();

        [JsonPropertyName("Ssl")]
        public SslSettings Ssl { get; set; } = new();

        [JsonPropertyName("DatabaseProvider")]
        public DatabaseProvider DatabaseProvider { get; set; } = DatabaseProvider.MSSqlServer;

        [EncryptedConfiguration]
        [JsonPropertyName("ConnectionStrings")]
        public Dictionary<string, string> ConnectionStrings { get; set; } = new();

        [JsonPropertyName("Serilog")]
        public SerilogSettings Serilog { get; set; } = new();

        [JsonPropertyName("Columns")]
        public Dictionary<string, object> Columns { get; set; } = new();

        [JsonPropertyName("Authentication")]
        public ApplicationAuthenticationSettings Authentication { get; set; } = new();
    }

    public class ReadOnlyApplicationSettings
    {
        public ReadOnlyApplicationSettings(ApplicationSettings applicationSettings)
        {
            if (applicationSettings == null)
                throw new ArgumentNullException(nameof(applicationSettings));

            SetupMode = applicationSettings.SetupMode;
            AllowedHosts = applicationSettings.AllowedHosts;
            Logging = new ReadOnlyApplicationLoggingSettings(applicationSettings.Logging);
            Ssl = new ReadOnlySslSettings(applicationSettings.Ssl);
            DatabaseProvider = applicationSettings.DatabaseProvider;
            ConnectionStrings = new ReadOnlyDictionary<string, string>(applicationSettings.ConnectionStrings);
            Serilog = new ReadOnlySerilogSettings(applicationSettings.Serilog);
            Columns = new ReadOnlyDictionary<string, object>(applicationSettings.Columns);
            Authentication = new ReadOnlyApplicationAuthenticationSettings(applicationSettings.Authentication);
        }

        [JsonPropertyName("SetupMode")]
        public readonly string? SetupMode;

        [JsonPropertyName("AllowedHosts")]
        public readonly string AllowedHosts;

        [JsonPropertyName("Logging")]
        public readonly ReadOnlyApplicationLoggingSettings Logging;

        [JsonPropertyName("Ssl")]
        public readonly ReadOnlySslSettings Ssl;

        [JsonPropertyName("DatabaseProvider")]
        public readonly DatabaseProvider DatabaseProvider;

        [EncryptedConfiguration]
        [JsonPropertyName("ConnectionStrings")]
        public readonly ReadOnlyDictionary<string, string> ConnectionStrings;

        [JsonPropertyName("Serilog")]
        public readonly ReadOnlySerilogSettings Serilog;

        [JsonPropertyName("Columns")]
        public readonly ReadOnlyDictionary<string, object> Columns;

        [JsonPropertyName("Authentication")]
        public readonly ReadOnlyApplicationAuthenticationSettings Authentication;
    }
}