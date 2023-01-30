/*
* This Source Code Form is subject to the licenses of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Enums;
using Markdig;
using System.Reflection;

namespace Astrana.Core.Legal
{
    public class LegalService : ILegalService
    {
        public string GetLicense(string languageCode, ContentFormat contentFormat = ContentFormat.Markdown)
        {
            languageCode = languageCode.ToLower();

            var licenseFileName = GetLicenseFileName(languageCode);

            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(licenseFileName))
            {
                if (stream == null)
                    throw new FileNotFoundException(licenseFileName);

                using (var reader = new StreamReader(stream))
                {
                    if (contentFormat == ContentFormat.Html)
                        return Markdown.ToHtml(reader.ReadToEnd());

                    if (contentFormat == ContentFormat.PlainText)
                        return Markdown.ToPlainText(reader.ReadToEnd());

                    return reader.ReadToEnd();
                }
            }
        }

        private static string GetLicenseFileName(string languageCode)
        {
            var codeParts = languageCode.Split("-");

            var licenseFileNameTemplate = "Astrana.Core.Legal.License.LICENSE_{0}.md";
            var licenseFileName = string.Format(licenseFileNameTemplate, languageCode);

            if (Assembly.GetExecutingAssembly().GetManifestResourceNames().All(r => r != licenseFileName))
                licenseFileName = string.Format(licenseFileNameTemplate, codeParts[0]);

            return licenseFileName;
        }
    }
}
