/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Domain.Models.Countries.Constants
{
    public static class DefaultCountries
    {
        public static readonly IReadOnlyCollection<Country> List = new List<Country>
        {
            new()
            {
                Id = 1,
                Name = "Australia",
                NameTrxCode = "country_name_au",
                TwoLetterCode = "au",
                ThreeLetterCode = "aus"
            },
            new()
            {
                Id = 2,
                Name = "Brazil",
                NameTrxCode = "country_name_br",
                TwoLetterCode = "br",
                ThreeLetterCode = "bra"
            },
            new()
            {
                Id = 3,
                Name = "China",
                NameTrxCode = "country_name_cn",
                TwoLetterCode = "cn",
                ThreeLetterCode = "chn"
            },
            new()
            {
                Id = 4,
                Name = "France",
                NameTrxCode = "country_name_fr",
                TwoLetterCode = "fr",
                ThreeLetterCode = "fra"
            },
            new()
            {
                Id = 5,
                Name = "India",
                NameTrxCode = "country_name_in",
                TwoLetterCode = "in",
                ThreeLetterCode = "ind"
            },
            new()
            {
                Id = 6,
                Name = "Israel",
                NameTrxCode = "country_name_il",
                TwoLetterCode = "il",
                ThreeLetterCode = "ilr"
            },
            new()
            {
                Id = 7,
                Name = "Russia",
                NameTrxCode = "country_name_ru",
                TwoLetterCode = "ru",
                ThreeLetterCode = "rus"
            },
            new()
            {
                Id = 8,
                Name = "South Africa",
                NameTrxCode = "country_name_za",
                TwoLetterCode = "za",
                ThreeLetterCode = "zaf"
            },
            new()
            {
                Id = 9,
                Name = "Spain",
                NameTrxCode = "country_name_es",
                TwoLetterCode = "es",
                ThreeLetterCode = "esp"
            },
            new()
            {
                Id = 10,
                Name = "United Kingdom",
                NameTrxCode = "country_name_gb",
                TwoLetterCode = "gb",
                ThreeLetterCode = "gbr"
            },
            new()
            {
                Id = 11,
                Name = "United States",
                NameTrxCode = "country_name_us",
                TwoLetterCode = "us",
                ThreeLetterCode = "usa"
            }
        };
    }
}
