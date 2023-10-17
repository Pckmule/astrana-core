﻿/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Options;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Videos.Options
{
    public class VideoQueryOptions<TRecordId, TOwnerUserId> : QueryOptions<TRecordId, TOwnerUserId>, IVideoQueryOptions
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonConstructor]
        public VideoQueryOptions() { }

        public VideoQueryOptions(List<TRecordId> ids) : base(ids) { }
    }
}