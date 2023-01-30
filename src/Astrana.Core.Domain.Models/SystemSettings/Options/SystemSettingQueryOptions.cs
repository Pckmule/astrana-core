/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Options;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.SystemSettings.Options
{
    public class SystemSettingQueryOptions<TRecordId, TOwnerUserId> : QueryOptions<TRecordId, TOwnerUserId>, ISystemSettingQueryOptions
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonConstructor]
        public SystemSettingQueryOptions() { }

        public SystemSettingQueryOptions(List<TRecordId> ids) : base(ids) { }

        public List<string> Names { get; set; } = new();

        public List<string> Categories { get; set; } = new();
    }
}
