/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Application.ApplicationSettings.Models
{
    public class SslSettings
    {
        [JsonPropertyName("Port")]
        public string Port { get; set; } = "443";

        [JsonPropertyName("CertificateName")]
        public string CertificateName { get; set; }

        [JsonPropertyName("Password")]
        public string Password { get; set; }
    }

    public class ReadOnlySslSettings
    {
        public ReadOnlySslSettings(SslSettings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            Port = settings.Port;
            CertificateName = settings.CertificateName;
            Password = settings.Password;
        }

        [JsonPropertyName("Port")]
        public readonly string Port;

        [JsonPropertyName("CertificateName")]
        public readonly string CertificateName;

        [JsonPropertyName("Password")]
        public readonly string Password;
    }
}