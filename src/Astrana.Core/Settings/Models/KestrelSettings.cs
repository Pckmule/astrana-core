/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Application.Settings.Models
{
    public class KestrelSettings
    {
        [JsonPropertyName("Endpoints")]
        public KestrelEndpointsSettings Endpoints { get; set; } = new();
    }

    public class KestrelEndpointsSettings
    {
        [JsonPropertyName("Http")]
        public KestrelEndpointsHttpSettings Http { get; set; } = new();
    }

    public class KestrelEndpointsHttpSettings
    {
        [JsonPropertyName("Url")]
        public string Url { get; set; } = "https://*:9005";

        [JsonPropertyName("HttpsInlineCertAndKeyFile")]
        public KestrelEndpointsHttpsInlineCertAndKeyFileSettings HttpsInlineCertAndKeyFile { get; set; } = new();
    }

    public class KestrelEndpointsHttpsInlineCertAndKeyFileSettings
    {
        [JsonPropertyName("Url")]
        public string Url { get; set; } = "https://*:9005";

        [JsonPropertyName("Certificate")]
        public KestrelEndpointsHttpsInlineCertAndKeyFileCertificateSettings Certificate { get; set; } = new();
    }

    public class KestrelEndpointsHttpsInlineCertAndKeyFileCertificateSettings
    {
        [JsonPropertyName("Path")]
        public string Path { get; set; } = "";

        [JsonPropertyName("KeyPath")]
        public string KeyPath { get; set; } = "";

        [JsonPropertyName("Password")]
        public string Password { get; set; } = "";
    }
}