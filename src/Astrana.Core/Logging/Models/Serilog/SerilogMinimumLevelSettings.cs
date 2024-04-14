/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Text.Json.Serialization;
using Astrana.Core.Domain.Application.Logging.Models.Serilog;

namespace Astrana.Core.Logging.Models.Serilog
{
    public class SerilogMinimumLevelSettings
    {
        [JsonPropertyName("Default")]
        public string Default { get; set; } = "Error";

        [JsonPropertyName("Override")]
        public SerilogOverrideSettings Override { get; set; } = new();
    }

    public class ReadOnlySerilogMinimumLevelSettings
    {
        public ReadOnlySerilogMinimumLevelSettings(SerilogMinimumLevelSettings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            Default = settings.Default;
            Override = new ReadOnlySerilogOverrideSettings(settings.Override);
        }

        [JsonPropertyName("Default")]
        public readonly string Default;

        [JsonPropertyName("Override")]
        public readonly ReadOnlySerilogOverrideSettings Override;
    }
}