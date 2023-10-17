/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* Image, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Data.Repositories.Images;
using Astrana.Core.Domain.Files.Builders;
using Astrana.Core.Domain.Files.Commands.UploadFile;
using Astrana.Core.Domain.Files.Queries.GetFileInfo;
using Astrana.Core.Domain.Models.AstranaApi.Contracts;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Images.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Enums;
using ImageMagick;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Images.Commands.UploadImage
{
    public class UploadImageCommand : IUploadImageCommand
    {
        private readonly ILogger<UploadImageCommand> _logger;
        private readonly IAstranaApiInfo _astranaApiInfo;

        private readonly IUploadFileCommand _uploadFileCommand;
        private readonly IImageRepository<Guid> _imageRepository;
        private readonly IGetFileInfoQuery _getFileInfoQuery;

        public UploadImageCommand(ILogger<UploadImageCommand> logger, IAstranaApiInfo astranaApiInfo, IUploadFileCommand uploadFileCommand, IImageRepository<Guid> imageRepository, IGetFileInfoQuery getFileInfoQuery)
        {
            _logger = logger;
            _astranaApiInfo = astranaApiInfo;

            _uploadFileCommand = uploadFileCommand;
            _imageRepository = imageRepository;
            _getFileInfoQuery = getFileInfoQuery;
        }

        public async Task<AddResult<List<Image>>> ExecuteAsync(List<IFormFile> files, Guid actioningUserId)
        {
            var images = new List<Image>();

            if (files.Count < 1)
                return new AddFailResult<List<Image>>(images, images.Count, "No images provided to upload.");

            var validImages = GetValidImages(files);

            if (validImages.Count < 1)
                return new AddFailResult<List<Image>>(images, images.Count, "Image(s) upload failed.", "No valid images.");

            try
            {
                var fileUploadResult = await _uploadFileCommand.ExecuteAsync(files, actioningUserId, GetFileMetadata, CompressImageFile);

                if (fileUploadResult.Outcome != ResultOutcome.Success)
                    return new AddFailResult<List<Image>>(null, images.Count, "Image(s) upload failed. " + fileUploadResult.Message, fileUploadResult.ResultCode);

                var imagesToAdd = fileUploadResult.Data.Select(uploadedFile => new ImageToAdd
                {
                    Location = FileProxyUrlBuilder.GetUrl(uploadedFile), 
                    Caption = GetMetadataValue(uploadedFile.Metadata, ExifTagNames.ImageDescription), 
                    Copyright = GetMetadataValue(uploadedFile.Metadata, ExifTagNames.Copyright)

                }).ToList();

                var saveResults = await _imageRepository.CreateAsync(imagesToAdd, actioningUserId);

                if (saveResults.HasData)
                {
                    foreach (var image in saveResults.Data.Where(image => image.Location.StartsWith('/')))
                    {
                        image.Size = _getFileInfoQuery.Execute(image.Location.StartsWith('/') ? Path.Join(_uploadFileCommand.FilesRootPath, image.Location) : image.Location).Size;
                        image.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, image.Location);
                    }
                }

                if (saveResults.Outcome == ResultOutcome.Success)
                    return new AddSuccessResult<List<Image>>(saveResults.Data, saveResults.Count, "Image(s) upload successful.");
                
                return new AddFailResult<List<Image>>(null, 0, "Image(s) upload failed.", ErrorCodes.Default);
            }
            catch (Exception)
            {
                return new AddFailResult<List<Image>>(null, 0, "Image(s) upload failed.", ErrorCodes.Default);
            }
        }

        private static string? GetMetadataValue(IReadOnlyDictionary<string, object> metadata, string key)
        {
            return metadata.ContainsKey(key) ? metadata[key] as string : null;
        }

        private static Stream CompressImageFile(Stream stream)
        {
            try
            {
                using var image = new MagickImage(stream);

                image.Quality = 85;
                image.GaussianBlur(0.05);
                image.Strip();

                image.Interlace = image.Format switch
                {
                    MagickFormat.Png => Interlace.Png,
                    MagickFormat.Jpeg => Interlace.Jpeg,
                    MagickFormat.Gif => Interlace.Gif,

                    _ => Interlace.Plane
                };

                var compressedStream = new MemoryStream();
                image.Write(compressedStream, image.Format);
                compressedStream.Position = 0;

                return compressedStream;
            }
            catch (Exception)
            {
                return stream;
            }
        }

        private static Dictionary<string, object> GetFileMetadata(Stream stream)
        {
            var metadata = new Dictionary<string, object>();

            try
            {
                using (var image = new MagickImage(stream))
                {
                    var exifProfile = image.GetExifProfile();

                    if (exifProfile == null)
                        return metadata;

                    foreach (var item in exifProfile.Values)
                    {
                        metadata.Add(item.Tag.ToString(), item.GetValue());
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }

            return metadata;
        }

        private static ValidationResult ValidateFormImage(IFormFile file)
        {
            return new ValidationResult(outcome: ValidationOutcome.Passed);
        }

        private static List<IFormFile> GetValidImages(IEnumerable<IFormFile> files)
        {
            return files.Where(image => ValidateFormImage(image).IsSuccess).ToList();
        }
    }
}
