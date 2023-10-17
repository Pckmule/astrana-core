/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Framework.Domain
{
    public abstract class DomainAggregateEntity : DomainEntity { }

    public abstract class DomainAggregateEntity<TEntityId, TDomainTransferObject> : DomainEntity<TEntityId, TDomainTransferObject>
        where TDomainTransferObject : new()
    { }
}
