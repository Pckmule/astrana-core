/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Files;
using Astrana.Core.Domain.Models.Results;
using Microsoft.AspNetCore.Http;

namespace Astrana.Core.Domain.Files.Commands.UploadFile
{
    public interface IUploadFileCommand
    {
        string FilesRootPath { get; }
        
        Task<ExecutionResult<List<UploadedFile>>> ExecuteAsync(List<IFormFile> files, Guid actioningUserId, Func<Stream, Dictionary<string, object>>? getMetadataFunction = null, Func<Stream, Stream>? compressionFunction = null);
    }
}
