﻿/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Options;
using Astrana.Core.Domain.Models.Tags.Enums;
using Astrana.Core.Utilities;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Comments.Options
{
    public class CommentQueryOptions<TRecordId, TOwnerUserId> : QueryOptions<TRecordId, TOwnerUserId>, ICommentQueryOptions
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonConstructor]
        public CommentQueryOptions() { }

        public CommentQueryOptions(List<TRecordId> ids) : base(ids) { }

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