/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Text.Json.Serialization;
using Astrana.Core.Domain.Models.Options;
using Astrana.Core.Domain.Models.Tags.Enums;
using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.ExternalContentSubscriptions.Options
{
    public class ExternalContentSubscriptionQueryOptions<TRecordId, TOwnerUserId> : QueryOptions<TRecordId, TOwnerUserId>, Links.Options.ILinkQueryOptions
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonConstructor]
        public ExternalContentSubscriptionQueryOptions() { }

        public ExternalContentSubscriptionQueryOptions(List<TRecordId> ids) : base(ids) { }

        public List<string> Tags { get; set; } = new();

        public TagFilterMode TagsFilterMode { get; set; } = TagFilterMode.Default;
        
        public override List<string> ToQueryStringList()
        {
            var propertyValues = base.ToQueryStringList();

            propertyValues.Add($"{nameof(TagsFilterMode).ToCamelCase()}={TagsFilterMode}");
            propertyValues.AddRange(Tags.Select(tag => $"{nameof(Tags).ToCamelCase()}={tag}"));

            return propertyValues;
        }

        public override string ToString()
        {
            var baseString = base.ToString();

            var propertyValues = new List<string>
            {
                $"{nameof(TagsFilterMode).ToCamelCase()}={TagsFilterMode}"
            };

            propertyValues.AddRange(Tags.Select(tag => $"{nameof(Tags).ToCamelCase()}={tag}"));

            return string.Join(StringSeparator, baseString, string.Join(StringSeparator, propertyValues));
        }
    }
}
