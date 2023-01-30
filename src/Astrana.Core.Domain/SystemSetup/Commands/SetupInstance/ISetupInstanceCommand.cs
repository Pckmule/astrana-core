/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.IdentityAccessManagement.Models;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.SystemSetup;

namespace Astrana.Core.Domain.SystemSetup.Commands.SetupInstance
{
    public interface ISetupInstanceCommand
    {
        Task<AddResult<ApplicationUser>> ExecuteAsync(InstanceSetupRequest? instanceSetupRequest, Guid actioningUserId);
    }
}