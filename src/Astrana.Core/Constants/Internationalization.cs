/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Enums;

namespace Astrana.Core.Constants
{
    public static class Internationalization
    {
        public const string DefaultLanguageName = "English";
        public const string DefaultLanguageNameTrxCode = "language_name_en";
        public const string DefaultLanguageTwoLetterCode = "en";
        public const string DefaultLanguageThreeLetterCode = "eng";
        public const LanguageDirection DefaultLanguageDirection = LanguageDirection.Ltr;
        

        public const string DefaultCountryName = "Australia";
        public const string DefaultCountryNameTrxCode = "country_name_au";
        public const string DefaultCountryTwoLetterCode = "au";
        public const string DefaultCountryThreeLetterCode = "aus";

        public const string DefaultCultureCode = $"{DefaultLanguageTwoLetterCode}-{DefaultCountryTwoLetterCode}";

        public const short MinimumCountryCodeLength = 2;
        public const short MaximumCountryCodeLength = 3;

        public const short MinimumLanguageCodeLength = 2;
        public const short MaximumLanguageCodeLength = 5;

        public const short MinimumPhoneCountryCodeISOLength = 1;
        public const short MaximumPhoneCountryCodeISOLength = 6;
    }
}
