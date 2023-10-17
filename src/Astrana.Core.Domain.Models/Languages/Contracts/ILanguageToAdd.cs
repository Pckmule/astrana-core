/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Domain.Models.Languages.Contracts
{
    public interface ILanguageToAdd
    {
        public string EnglishName { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string TwoLetterCode { get; set; }

        public string ThreeLetterCode { get; set; }
    }
}
