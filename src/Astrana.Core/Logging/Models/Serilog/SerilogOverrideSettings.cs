/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Text.Json.Serialization;

namespace Astrana.Core.Logging.Models.Serilog
{
    public class SerilogOverrideSettings
    {
        [JsonPropertyName("System")]
        public string System { get; set; } = "Warning";

        [JsonPropertyName("Microsoft")]
        public string Microsoft { get; set; } = "Warning";
    }

    public class ReadOnlySerilogOverrideSettings
    {
        public ReadOnlySerilogOverrideSettings(SerilogOverrideSettings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            System = settings.System;
            Microsoft = settings.Microsoft;
        }

        [JsonPropertyName("System")]
        public readonly string System;

        [JsonPropertyName("Microsoft")]
        public readonly string Microsoft;
    }
}