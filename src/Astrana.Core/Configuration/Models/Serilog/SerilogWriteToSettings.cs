/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Astrana.Core.Configuration.Models.Serilog
{
    public class SerilogWriteToSettings
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("Args")]
        public Dictionary<string, object> Args { get; set; } = new();
    }

    public class ReadOnlySerilogWriteToSettings
    {
        public ReadOnlySerilogWriteToSettings(SerilogWriteToSettings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            Name = settings.Name;
            Args = new ReadOnlyDictionary<string, object>(settings.Args);
        }

        [JsonPropertyName("Name")]
        public readonly string Name;

        [JsonPropertyName("Args")]
        public readonly ReadOnlyDictionary<string, object> Args;
    }
}