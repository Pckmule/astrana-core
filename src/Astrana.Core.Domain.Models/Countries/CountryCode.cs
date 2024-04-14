/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Framework.Domain;

namespace Astrana.Core.Domain.Models.Countries
{
    public sealed class CountryCode : DomainValueObject
    {
        public CountryCode(string twoLetterCode, string threeLetterCode)
        {
            TwoLetterCode = twoLetterCode;
            ThreeLetterCode = threeLetterCode;
        }

        public string TwoLetterCode { get; }

        public string ThreeLetterCode { get; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return TwoLetterCode;
            yield return ThreeLetterCode;
        }
    }
}