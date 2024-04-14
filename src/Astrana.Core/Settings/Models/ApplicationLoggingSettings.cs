/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Application.Settings.Models
{
    public class ApplicationLoggingSettings
    {
        [JsonPropertyName("LogLevel")]
        public ApplicationLoggingLogLevelSettings LogLevel { get; set; } = new();

        [JsonPropertyName("EventLog")]
        public ApplicationLoggingEventLogLevelSettings EventLog { get; set; } = new();
    }

    public class ReadOnlyApplicationLoggingSettings
    {
        public ReadOnlyApplicationLoggingSettings(ApplicationLoggingSettings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            LogLevel = new ReadOnlyApplicationLoggingLogLevelSettings(settings.LogLevel);
            EventLog = new ApplicationLoggingEventLogLevelSettingsReadOnly(settings.EventLog);
        }

        [JsonPropertyName("LogLevel")]
        public readonly ReadOnlyApplicationLoggingLogLevelSettings LogLevel;

        [JsonPropertyName("EventLog")]
        public readonly ApplicationLoggingEventLogLevelSettingsReadOnly EventLog;
    }

    public class ApplicationLoggingLogLevelSettings
    {
        [JsonPropertyName("default")]
        public string Default { get; set; } = "Information";
    }

    public class ReadOnlyApplicationLoggingLogLevelSettings
    {
        public ReadOnlyApplicationLoggingLogLevelSettings(ApplicationLoggingLogLevelSettings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            Default = settings.Default;
        }

        [JsonPropertyName("default")]
        public readonly string Default;
    }

    public class ApplicationLoggingEventLogLevelSettings
    {
        [JsonPropertyName("LogLevel")]
        public ApplicationLoggingLogLevelSettings LogLevel { get; set; } = new();
    }

    public class ApplicationLoggingEventLogLevelSettingsReadOnly
    {
        public ApplicationLoggingEventLogLevelSettingsReadOnly(ApplicationLoggingEventLogLevelSettings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            LogLevel = new ReadOnlyApplicationLoggingLogLevelSettings(settings.LogLevel);
        }

        [JsonPropertyName("LogLevel")]
        public readonly ReadOnlyApplicationLoggingLogLevelSettings LogLevel;
    }
}