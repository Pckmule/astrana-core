/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Files.DomainTransferObjects;
using ImageMagick;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Logging;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace Astrana.Core.Domain.Files.Queries.GetFileInfo
{
    public class GetFileInfoQuery : IGetFileInfoQuery
    {
        private readonly ILogger<GetFileInfoQuery> _logger;

        public GetFileInfoQuery(ILogger<GetFileInfoQuery> logger)
        {
            _logger = logger;
        }

        public FileInfoDto Execute(string location)
        {
            if (string.IsNullOrWhiteSpace(location))
                return new FileInfoDto();

            if (!File.Exists(location))
                return new FileInfoDto();

            var fileName = Path.GetFileName(location);

            using var fileStream = new FileStream(location, FileMode.Open);
            return new FileInfoDto(GetName(fileName), GetExtension(fileName), GetSize(fileName, fileStream));
        }

        public FileInfoDto Execute(IFormFile formFile)
        {
            return new FileInfoDto(GetName(formFile), GetExtension(formFile), GetSize(formFile));
        }

        private static string GetName(string fileName)
        {
            return fileName[..fileName.LastIndexOf(".", StringComparison.Ordinal)] + "." + GetExtension(fileName);
        }

        private static string GetName(IFormFile file)
        {
            return GetName(Path.GetFileName(file.FileName));
        }

        private static string GetExtension(string fileName)
        {
            var extension = Path.GetExtension(fileName).Replace(".", "");

            if (!Regex.IsMatch(extension, @"[a-zA-Z]"))
                throw new Exception($"Invalid file extension: {extension}.");

            return extension.ToLowerInvariant();
        }

        private static string GetExtension(IFormFile file)
        {
            return GetExtension(file.FileName);
        }

        private static FileSizeInfoDto GetSize(string fileName, Stream fileStream)
        {
            new FileExtensionContentTypeProvider().TryGetContentType(fileName, out var contentType);

            if (Constants.Files.SupportedFileTypesWithDimensions.Contains(contentType))
                return new FileSizeInfoDto(fileStream.Length);

            try
            {
                int width, height;
                using (var image = new MagickImage(fileStream))
                {
                    width = image.Width;
                    height = image.Height;
                }

                return new FileSizeInfoDto(fileStream.Length, width, height);
            }
            catch (Exception)
            {
                return new FileSizeInfoDto(fileStream.Length);
            }
        }

        private static FileSizeInfoDto GetSize(IFormFile file)
        {
            new FileExtensionContentTypeProvider().TryGetContentType(file.FileName, out var contentType);

            if (Constants.Files.SupportedFileTypesWithDimensions.Contains(contentType))
                return new FileSizeInfoDto(file.Length);

            return GetSize(file.FileName, file.OpenReadStream());
        }
    }
}
