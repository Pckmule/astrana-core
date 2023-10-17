/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Languages.Contracts;
using Astrana.Core.Enums;

namespace Astrana.Core.Domain.Models.Languages
{
    public class LanguageLite : ILanguage
    {
        public LanguageLite(Language fullModel)
        {
            if(fullModel == null)
                throw new ArgumentNullException(nameof(fullModel));

            Name = fullModel.Name;
            NameTrxCode = fullModel.NameTrxCode;
            Code = fullModel.Code;
            TwoLetterCode = fullModel.TwoLetterCode;
            ThreeLetterCode = fullModel.ThreeLetterCode;
            Direction = fullModel.Direction;
        }

        public string Name { get; set; }

        public string NameTrxCode { get; set; }

        public string Code { get; set; }

        public string TwoLetterCode { get; set; }

        public string ThreeLetterCode { get; set; }

        public LanguageDirection Direction { get; set; }
    }
}