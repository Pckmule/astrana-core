/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Net;
using Astrana.Core.Constants;
using Astrana.Core.Domain.Models.Results;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Files.Commands.GetFileStream
{
    public class GetFileStreamCommand : IGetFileStreamCommand
    {
        private readonly ILogger<GetFileStreamCommand> _logger;

        public readonly string FileDirectory;

        private static readonly List<string> SupportedFileTypes = new()
        {
            "gif", "jpg", "jpeg", "png"
        };

        public GetFileStreamCommand(ILogger<GetFileStreamCommand> logger, IHostEnvironment webHostEnvironment)
        {
            _logger = logger;

            FileDirectory = Path.Combine(webHostEnvironment.ContentRootPath, Constants.Files.FilesDirectoryName);

            if (!Directory.Exists(FileDirectory))
                Directory.CreateDirectory(FileDirectory);
        }

        public async Task<ExecutionResult<Stream?>> ExecuteAsync(string address, Guid actioningUserId)
        {
            var fileStream = new MemoryStream();

            address = WebUtility.UrlDecode(address);

            if (string.IsNullOrWhiteSpace(address))
                return new ExecutionFailResult<Stream?>(null, "Invalid file address provided.");

            try
            {
                var isLocalFile = IsLocalFile(address);

                fileStream = isLocalFile
                    ? await GetStreamFromLocalAddress(Path.Combine(FileDirectory, address))
                    : await GetStreamFromRemoteAddress(address);

                if (fileStream.Length < 1)
                    return new ExecutionFailResult<Stream?>(null, "No file content.");

                return new ExecutionSuccessResult<Stream?>(fileStream, "Successfully retrieved file stream.");
            }
            catch (Exception)
            {
                return new ExecutionFailResult<Stream?>(fileStream, "Failed to get file stream.", ErrorCodes.Default);
            }
        }

        private static bool IsLocalFile(string address)
        {
            return !address.Contains("://");
        }

        private static async Task<MemoryStream> GetStreamFromLocalAddress(string address)
        {
            var stream = new MemoryStream();

            try
            {
                if (File.Exists(address))
                {
                    await using var fileStream = File.Open(address, FileMode.Open);
                    await fileStream.CopyToAsync(stream);
                }
            }
            catch (Exception)
            {
                // ignored
            }

            return stream;
        }

        private static async Task<MemoryStream> GetStreamFromRemoteAddress(string address)
        {
            var stream = new MemoryStream();

            try
            {
                var client = new HttpClient();

                using var response = await client.GetAsync(new Uri(address));
                response.EnsureSuccessStatusCode();

                await (await response.Content.ReadAsStreamAsync()).CopyToAsync(stream);
            }
            catch (Exception)
            {
                // ignored
            }

            return stream;
        }
    }
}
