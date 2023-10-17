/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Audiences.Commands.DeleteAudiences
{
    public interface IDeleteAudiencesCommand
    {
        Task<DeleteResult<List<Guid>>> ExecuteAsync(IList<Guid> audiencesToDeleteIds, Guid actioningUserId);
    }
}