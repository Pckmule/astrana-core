/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Application.Configuration.Attributes;
using System.Text.Json.Serialization;

namespace Astrana.Core.Settings.Models
{
    public class ApplicationAuthenticationSettings
    {
        [EncryptedConfiguration]
        [JsonPropertyName("SecretForKey")]
        public string SecretForKey { get; set; } = "";

        [JsonPropertyName("Issuer")]
        public string Issuer { get; set; } = "";

        [JsonPropertyName("Audience")]
        public string Audience { get; set; } = "";
    }

    public class ReadOnlyApplicationAuthenticationSettings
    {
        public ReadOnlyApplicationAuthenticationSettings(ApplicationAuthenticationSettings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            SecretForKey = settings.SecretForKey;
            Issuer = settings.Issuer;
            Audience = settings.Audience;
        }

        [EncryptedConfiguration]
        [JsonPropertyName("SecretForKey")]
        public readonly string SecretForKey;

        [JsonPropertyName("Issuer")]
        public readonly string Issuer;

        [JsonPropertyName("Audience")]
        public readonly string Audience;
    }
}