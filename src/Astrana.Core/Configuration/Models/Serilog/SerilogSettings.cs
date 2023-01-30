/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Text.Json.Serialization;

namespace Astrana.Core.Configuration.Models.Serilog
{
    public class SerilogSettings
    {
        [JsonPropertyName("Using")]
        public List<string> Using { get; set; } = new();

        [JsonPropertyName("MinimumLevel")]
        public SerilogMinimumLevelSettings MinimumLevel { get; set; } = new();

        [JsonPropertyName("Override")]
        public SerilogOverrideSettings Override { get; set; } = new();

        [JsonPropertyName("WriteTo")]
        public List<SerilogWriteToSettings> WriteTo { get; set; } = new();

        [JsonPropertyName("Enrich")]
        public List<string> Enrich { get; set; } = new();
    }

    public class ReadOnlySerilogSettings
    {
        public ReadOnlySerilogSettings(SerilogSettings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            Using = settings.Using;
            MinimumLevel = new ReadOnlySerilogMinimumLevelSettings(settings.MinimumLevel);
            Override = new ReadOnlySerilogOverrideSettings(settings.Override);
            WriteTo = settings.WriteTo;
            Enrich = settings.Enrich;
        }

        [JsonPropertyName("Using")]
        public readonly IReadOnlyList<string> Using;

        [JsonPropertyName("MinimumLevel")]
        public readonly ReadOnlySerilogMinimumLevelSettings MinimumLevel;

        [JsonPropertyName("Override")]
        public readonly ReadOnlySerilogOverrideSettings Override;

        [JsonPropertyName("WriteTo")]
        public readonly IReadOnlyList<SerilogWriteToSettings> WriteTo;

        [JsonPropertyName("Enrich")]
        public readonly IReadOnlyList<string> Enrich;
    }
}