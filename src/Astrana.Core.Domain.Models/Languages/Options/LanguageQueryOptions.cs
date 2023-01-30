/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Options;
using Astrana.Core.Utilities;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Languages.Options
{
    public class LanguageQueryOptions<TRecordId, TOwnerUserId> : QueryOptions<TRecordId, TOwnerUserId>, ILanguageQueryOptions
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonConstructor]
        public LanguageQueryOptions() { }

        public LanguageQueryOptions(List<TRecordId> ids) : base(ids) { }

        public LanguageQueryOptions(List<string> codes)
        {
            Codes = codes;
        }

        public List<string> Codes { get; set; } = new();

        public override List<string> ToQueryStringList()
        {
            var propertyValues = base.ToQueryStringList();

            propertyValues.AddRange(Codes.Distinct().Select(code => $"{nameof(Codes).ToCamelCase()}={code}"));

            return propertyValues;
        }

        public override string ToString()
        {
            var baseString = base.ToString();

            var propertyValues = new List<string>();

            propertyValues.AddRange(Codes.Distinct().Select(code => $"{nameof(Codes).ToCamelCase()}={code}"));

            return string.Join(StringSeparator, baseString, string.Join(StringSeparator, propertyValues));
        }
    }
}
