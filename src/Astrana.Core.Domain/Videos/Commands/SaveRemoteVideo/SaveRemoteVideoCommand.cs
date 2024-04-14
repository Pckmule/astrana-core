/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.Videos.Commands.UploadVideo;
using Astrana.Core.Domain.Models.Videos;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.MimeTypes.MimeTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Logging;
using System.Text.RegularExpressions;

namespace Astrana.Core.Domain.Videos.Commands.SaveRemoteVideo
{
    public class SaveRemoteVideoCommand : ISaveRemoteVideoCommand
    {
        private readonly ILogger<SaveRemoteVideoCommand> _logger;

        private readonly IUploadVideoCommand _uploadVideoCommand;

        public SaveRemoteVideoCommand(ILogger<SaveRemoteVideoCommand> logger, IUploadVideoCommand uploadVideoCommand)
        {
            _logger = logger;

            _uploadVideoCommand = uploadVideoCommand;
        }

        public async Task<AddResult<List<Video>>> ExecuteAsync(Uri url, Guid actioningUserId)
        {
            try
            {
                var remoteVideo = await GetRemoteVideoAsync(url);

                if (remoteVideo.Length == 0)
                    return new AddFailResult<List<Video>>(new List<Video>(), 1, "Remote file save failed.", "Video has no content.");

                var videoSaveResult = await _uploadVideoCommand.ExecuteAsync(new List<IFormFile> { remoteVideo }, actioningUserId);

                if (videoSaveResult.Outcome == ResultOutcome.Success)
                {
                    return new AddSuccessResult<List<Video>>(videoSaveResult.Data, videoSaveResult.Count, "Remote file save successful.");
                }

                return new AddFailResult<List<Video>>(null, 0, "Remote file save failed.", ErrorCodes.Default);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return new AddFailResult<List<Video>>(null, 0, "Remote file save failed. " + ex.Message, ErrorCodes.Default);
            }
        }

        private static async Task<IFormFile> GetRemoteVideoAsync(Uri url)
        {
            var response = await new HttpClient().GetAsync(url);

            if (response == null)
                throw new InvalidDataException("No HTTP response received.");

            var stream = await response.Content.ReadAsStreamAsync();

            if (stream == null || stream.Length < 1)
                throw new InvalidDataException("No file content received.");

            var fileName = response.Content.Headers.ContentDisposition?.FileName ?? GetNameFromUrl(url, GetContentType(response));

            fileName = NormalizeFileName(fileName);

            var name = response.Content.Headers.ContentDisposition?.Name ?? RemoveFileNameExtension(fileName);

            var formFile = new FormFile(stream, 0, stream.Length, name, fileName)
            {
                Headers = new HeaderDictionary(),
                ContentDisposition = GetContentDisposition(response, name, fileName),
                ContentType = GetContentType(response, fileName)
            };

            return formFile;
        }

        private static string NormalizeFileName(string fileName)
        {
            return Regex.Replace(fileName, "[^a-zA-Z0-9.\\-_'\\s]+", "");
        }

        private static string RemoveFileNameExtension(string fileName)
        {
            var separatorIndex = fileName.IndexOf(".", StringComparison.Ordinal);

            return separatorIndex > -1 ? fileName[..separatorIndex] : fileName;
        }

        private static string GetNameFromUrl(Uri url, string? contentType = null)
        {
            var pathAndQuery = url.PathAndQuery;
            var fileName = Path.GetFileName(pathAndQuery.IndexOf("?", StringComparison.Ordinal) > -1 ? pathAndQuery[..pathAndQuery.IndexOf("?", StringComparison.Ordinal)] : pathAndQuery);
            
            var indexOfLastDot = fileName.LastIndexOf(".", StringComparison.Ordinal);

            return (indexOfLastDot > -1 ? fileName[..indexOfLastDot] : fileName) + "." + GetExtension(fileName, contentType);
        }

        private static string GetExtension(string fileName, string? contentType = null)
        {
            var extension = GetExtensionFromFileName(fileName);

            return string.IsNullOrWhiteSpace(extension) ? GetExtensionByContentType(contentType) : extension;
        }

        private static string GetExtensionFromFileName(string fileName)
        {
            if(string.IsNullOrWhiteSpace(fileName))
                return string.Empty;

            var indexOfDot = fileName.IndexOf(".", StringComparison.Ordinal);

            return indexOfDot > -1 ? fileName[(indexOfDot + 1)..].ToLower() : string.Empty;
        }

        private static string GetExtensionByContentType(string? contentType)
        {
            return MimeTypeMapper.GetExtension(contentType ?? "");
        }

        private static string GetContentDisposition(HttpResponseMessage? httpResponseMessage, string name = "file", string fileName = "file.unknown")
        {
            var contentDisposition = "";

            if (httpResponseMessage?.Content.Headers.ContentDisposition != null)
                contentDisposition = httpResponseMessage.Content.Headers.ContentDisposition.ToString();

            if (string.IsNullOrWhiteSpace(contentDisposition))
                contentDisposition = $"form-data; name=\"{name}\"; filename=\"{fileName}\"";

            return contentDisposition;
        }

        private static string GetContentType(HttpResponseMessage? httpResponseMessage, string fileName = null)
        {
            const string defaultContentType = "application/octet-stream";

            var contentType = "";

            if (httpResponseMessage?.Content.Headers.ContentType != null)
                contentType = httpResponseMessage.Content.Headers.ContentType.ToString();
            
            if(string.IsNullOrWhiteSpace(contentType) && !string.IsNullOrWhiteSpace(fileName))
                new FileExtensionContentTypeProvider().TryGetContentType(fileName, out contentType);

            return contentType ?? defaultContentType;
        }
    }
}
