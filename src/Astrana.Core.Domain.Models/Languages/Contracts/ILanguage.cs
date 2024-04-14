/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Enums;

namespace Astrana.Core.Domain.Models.Languages.Contracts
{
    public interface ILanguage
    {
        string Name { get; set; }

        string NameTrxCode { get; set; }

        string TwoLetterCode { get; set; }

        string ThreeLetterCode { get; set; }

        LanguageDirection Direction { get; set; }
    }
}