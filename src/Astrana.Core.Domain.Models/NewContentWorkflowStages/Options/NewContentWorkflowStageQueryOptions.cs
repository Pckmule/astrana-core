/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Options;
using Astrana.Core.Utilities;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.NewContentWorkflowStages.Options
{
    public class NewContentWorkflowStageQueryOptions<TRecordId, TOwnerUserId> : QueryOptions<TRecordId, TOwnerUserId>, INewContentWorkflowStageQueryOptions
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonConstructor]
        public NewContentWorkflowStageQueryOptions() { }

        public NewContentWorkflowStageQueryOptions(List<TRecordId> ids) : base(ids) { }

        public List<string> ContentTypeIds { get; set; } = new();
        
        public override List<string> ToQueryStringList()
        {
            var propertyValues = base.ToQueryStringList();
            
            propertyValues.AddRange(ContentTypeIds.Select(tag => $"{nameof(ContentTypeIds).ToCamelCase()}={tag}"));

            return propertyValues;
        }

        public override string ToString()
        {
            var baseString = base.ToString();

            var propertyValues = new List<string>();

            propertyValues.AddRange(ContentTypeIds.Select(tag => $"{nameof(ContentTypeIds).ToCamelCase()}={tag}"));

            return string.Join(StringSeparator, baseString, string.Join(StringSeparator, propertyValues));
        }
    }
}
