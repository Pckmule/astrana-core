/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Astrana.Core.Data.Entities
{
    [Obsolete]
    public abstract class BaseDeactivatableEntity<TPrimaryKeyId, TUserId> : BaseEntity<TPrimaryKeyId, TUserId>, IDeactivatableEntity<TUserId>
        where TPrimaryKeyId : struct
        where TUserId : struct
    {
        [Column(Order = 99993)]
        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        [Column(Order = 99994)]
        public string? DeactivatedReason { get; set; } = null;

        [Column(Order = 99995)]
        public TUserId? DeactivatedBy { get; set; }
    }
}
