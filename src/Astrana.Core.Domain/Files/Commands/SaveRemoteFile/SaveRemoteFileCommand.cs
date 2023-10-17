/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.Images.Commands.UploadImage;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Files.Commands.SaveRemoteFile
{
    public class SaveRemoteFileCommand : ISaveRemoteFileCommand
    {
        private readonly ILogger<SaveRemoteFileCommand> _logger;

        private readonly IUploadImageCommand _uploadImageCommand;
        
        public SaveRemoteFileCommand(ILogger<SaveRemoteFileCommand> logger, IUploadImageCommand uploadImageCommand)
        {
            _logger = logger;

            _uploadImageCommand = uploadImageCommand;
        }

        public async Task<AddResult<List<Image>>> ExecuteAsync(Uri url, Guid actioningUserId)
        {
            try
            {
                var remoteFile = await GetRemoteFileAsync(url);

                if (remoteFile.Length == 0)
                    return new AddFailResult<List<Image>>(new List<Image>(), 1, "Remote file save failed.", "File has no content.");

                //var imageSaveResult = await _uploadImageCommand.ExecuteAsync(new List<IFormFile> { remoteFile }, actioningUserId);
                
                //if (imageSaveResult.Outcome == ResultOutcome.Success)
                //{ 
                //    return new AddSuccessResult<List<Image>>(imageSaveResult.Data, imageSaveResult.Count, "Remote file save successful.");
                //}

                return new AddFailResult<List<Image>>(null, 0, "Remote file save failed.", ErrorCodes.Default);
            }
            catch (Exception)
            {
                return new AddFailResult<List<Image>>(null, 0, "Remote file save failed.", ErrorCodes.Default);
            }
        }

        private static async Task<IFormFile> GetRemoteFileAsync(Uri url)
        {
            var response = await new HttpClient().GetAsync(url);

            if (response == null)
                throw new InvalidDataException("No HTTP response received.");

            var stream = await response.Content.ReadAsStreamAsync() as FileStream;

            if (stream == null || stream.Length < 1)
                throw new InvalidDataException("No file content received.");

            var fileName = GetNameFromUrl(url);
            var name = fileName;

            new FileExtensionContentTypeProvider().TryGetContentType(stream.Name, out var contentType);

            return new FormFile(stream, 0, stream.Length, name, fileName)
            {
                ContentDisposition = response?.Content?.Headers?.ContentDisposition?.ToString() ?? string.Empty
            };
        }

        private static string GetNameFromUrl(Uri url)
        {
            var pathAndQuery = url.PathAndQuery;
            var fileName = Path.GetFileName(pathAndQuery.IndexOf("?", StringComparison.Ordinal) > -1 ? pathAndQuery[..pathAndQuery.IndexOf("?", StringComparison.Ordinal)] : pathAndQuery);
            
            return fileName.Substring(fileName.LastIndexOf("/", StringComparison.Ordinal) + 1, fileName.LastIndexOf(".", StringComparison.Ordinal)) + "." + GetExtension(fileName);
        }

        private static string GetExtension(string fileName)
        {
            return Path.GetExtension(fileName)[1..].ToLower();
        }
    }
}
