/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Images.Commands.SaveRemoteImage
{
    public interface ISaveRemoteImageCommand
    {
        Task<AddResult<List<Image>>> ExecuteAsync(Uri url, Guid actioningUserId);
    }
}
