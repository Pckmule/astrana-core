/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Options;
using Astrana.Core.Domain.Models.SystemUpdates.Enums;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.SystemUpdates.Options
{
    public class SystemUpdateQueryOptions<TRecordId, TOwnerUserId> : QueryOptions<TRecordId, TOwnerUserId>, ISystemUpdateQueryOptions
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonConstructor]
        public SystemUpdateQueryOptions() { }

        public SystemUpdateQueryOptions(List<TRecordId> ids) : base(ids) { }

        public List<SystemUpdateType> Types { get; set; } = new();
    }
}
