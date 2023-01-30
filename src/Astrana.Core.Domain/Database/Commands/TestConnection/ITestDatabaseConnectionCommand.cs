/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.SystemSetup;

namespace Astrana.Core.Domain.Database.Commands.TestConnection
{
    public interface ITestDatabaseConnectionCommand
    {
        Task<ExecutionResult> ExecuteAsync(TestDatabaseConnectionRequest request, Guid actioningUserId);
    }
}
