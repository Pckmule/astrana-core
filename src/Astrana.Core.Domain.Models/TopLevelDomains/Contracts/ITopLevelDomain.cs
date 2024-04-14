/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Countries;

namespace Astrana.Core.Domain.Models.TopLevelDomains.Contracts
{
    public interface ITopLevelDomain
    {
        Guid TopLevelDomainId { get; set; }

        string Domain { get; set; }
        
        Country Country { get; set; }

        bool IsImplemented { get; set; }
    }
}
