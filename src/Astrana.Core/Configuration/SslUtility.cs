/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Security.Cryptography.X509Certificates;

namespace Astrana.Core.Configuration
{
    public static class SslUtility
    {
        private const string CertificateDirectoryName = "Ssl";

        public static X509Certificate2 GetSslCertificate(string certificateFileName = "astrana.pfx", string certificatePassword = "astrana")
        {
            var certificateFilePath = Path.Join(FileSystemUtility.GetSecureSettingsDirectoryPath, CertificateDirectoryName);

            if (OperatingSystem.IsLinux())
                certificateFilePath = certificateFilePath.ToLower();

            return new X509Certificate2(Path.Combine(certificateFilePath, certificateFileName), certificatePassword);
        }
    }
}