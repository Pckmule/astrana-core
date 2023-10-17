/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Videos;
using Astrana.Core.Domain.Models.Results;
using Microsoft.AspNetCore.Http;

namespace Astrana.Core.Domain.Videos.Commands.UploadVideo
{
    public interface IUploadVideoCommand
    {
        Task<AddResult<List<Video>>> ExecuteAsync(List<IFormFile> files, Guid actioningUserId);
    }
}
