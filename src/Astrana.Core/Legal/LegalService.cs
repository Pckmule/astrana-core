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

            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(licenseFileName);
            if (stream == null)
                throw new FileNotFoundException(licenseFileName);

            using var reader = new StreamReader(stream);
            return contentFormat switch
            {
                ContentFormat.Html => Markdown.ToHtml(reader.ReadToEnd()),
                ContentFormat.PlainText => Markdown.ToPlainText(reader.ReadToEnd()),
                _ => reader.ReadToEnd()
            };
        }

        private static string GetLicenseFileName(string languageCode)
        {
            var codeParts = languageCode.Split("-");

            var nomalizedCode = codeParts[0].ToLower();

            if(codeParts.Length > 1)
                nomalizedCode += "-" + codeParts[1].ToUpper();

            const string licenseFileNameTemplate = "Astrana.Core.Legal.License.LICENSE_{0}.md";
            var licenseFileName = string.Format(licenseFileNameTemplate, nomalizedCode);

            if (Assembly.GetExecutingAssembly().GetManifestResourceNames().All(r => r != licenseFileName))
                licenseFileName = string.Format(licenseFileNameTemplate, codeParts[0].ToLower());

            if (Assembly.GetExecutingAssembly().GetManifestResourceNames().All(r => r != licenseFileName))
                licenseFileName = string.Format(licenseFileNameTemplate, "en");

            return licenseFileName;
        }
    }
}
