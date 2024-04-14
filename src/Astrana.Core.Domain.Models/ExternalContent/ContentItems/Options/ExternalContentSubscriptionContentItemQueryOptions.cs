/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Options;
using Astrana.Core.Domain.Models.Tags.Enums;
using Astrana.Core.Utilities;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.ExternalContent.ContentItems.Options
{
    public class ExternalContentSubscriptionContentItemQueryOptions<TRecordId, TOwnerUserId> : QueryOptions<TRecordId, TOwnerUserId> where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonConstructor]
        public ExternalContentSubscriptionContentItemQueryOptions() { }

        public ExternalContentSubscriptionContentItemQueryOptions(List<TRecordId> ids) : base(ids) { }

        public List<string> Categories { get; set; } = new();

        public TagFilterMode CategoryFilterMode { get; set; } = TagFilterMode.Default;

        public override List<string> ToQueryStringList()
        {
            var propertyValues = base.ToQueryStringList();

            propertyValues.Add($"{nameof(CategoryFilterMode).ToCamelCase()}={CategoryFilterMode}");
            propertyValues.AddRange(Categories.Select(tag => $"{nameof(Categories).ToCamelCase()}={tag}"));

            return propertyValues;
        }

        public override string ToString()
        {
            var baseString = base.ToString();

            var propertyValues = new List<string>
            {
                $"{nameof(CategoryFilterMode).ToCamelCase()}={CategoryFilterMode}"
            };

            propertyValues.AddRange(Categories.Select(category => $"{nameof(Categories).ToCamelCase()}={category}"));

            return string.Join(StringSeparator, baseString, string.Join(StringSeparator, propertyValues));
        }
    }
}
