/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* Video, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Data.Repositories.Videos;
using Astrana.Core.Domain.Files.Builders;
using Astrana.Core.Domain.Files.Commands.UploadFile;
using Astrana.Core.Domain.Files.Queries.GetFileInfo;
using Astrana.Core.Domain.Models.AstranaApi.Contracts;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Models.Videos;
using Astrana.Core.Domain.Models.Videos.Constants;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Enums;
using ImageMagick;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Videos.Commands.UploadVideo
{
    public class UploadVideoCommand : IUploadVideoCommand
    {
        private readonly ILogger<UploadVideoCommand> _logger;
        private readonly IAstranaApiInfo _astranaApiInfo;

        private readonly IUploadFileCommand _uploadFileCommand;
        private readonly IVideoRepository<Guid> _videoRepository;
        private readonly IGetFileInfoQuery _getFileInfoQuery;

        public UploadVideoCommand(ILogger<UploadVideoCommand> logger, IAstranaApiInfo astranaApiInfo, IUploadFileCommand uploadFileCommand, IVideoRepository<Guid> videoRepository, IGetFileInfoQuery getFileInfoQuery)
        {
            _logger = logger;
            _astranaApiInfo = astranaApiInfo;

            _uploadFileCommand = uploadFileCommand;
            _videoRepository = videoRepository;
            _getFileInfoQuery = getFileInfoQuery;
        }

        public async Task<AddResult<List<Video>>> ExecuteAsync(List<IFormFile> files, Guid actioningUserId)
        {
            var videos = new List<Video>();

            if (files.Count < 1)
                return new AddFailResult<List<Video>>(videos, videos.Count, "No videos provided to upload.");

            var validVideos = GetValidVideos(files);

            if (validVideos.Count < 1)
                return new AddFailResult<List<Video>>(videos, videos.Count, "Video(s) upload failed.", "No valid videos.");

            try
            {
                var fileUploadResult = await _uploadFileCommand.ExecuteAsync(files, actioningUserId, GetFileMetadata, CompressVideoFile);

                if (fileUploadResult.Outcome != ResultOutcome.Success)
                    return new AddFailResult<List<Video>>(null, videos.Count, "Video(s) upload failed. " + fileUploadResult.Message, fileUploadResult.ResultCode);

                var videosToAdd = fileUploadResult.Data.Select(uploadedFile => new VideoToAdd
                {
                    Location = FileProxyUrlBuilder.GetUrl(uploadedFile), 
                    Caption = GetMetadataValue(uploadedFile.Metadata, ExifTagNames.AudioDescription), 
                    Copyright = GetMetadataValue(uploadedFile.Metadata, ExifTagNames.Copyright)

                }).ToList();

                var saveResults = await _videoRepository.CreateAsync(videosToAdd, actioningUserId);

                if (saveResults.HasData)
                {
                    foreach (var video in saveResults.Data.Where(video => video.Location.StartsWith('/')))
                    {
                        video.Size = _getFileInfoQuery.Execute(video.Location.StartsWith('/') ? Path.Join(_uploadFileCommand.FilesRootPath, video.Location) : video.Location).Size;
                        video.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Video, video.Location);
                    }
                }

                if (saveResults.Outcome == ResultOutcome.Success)
                    return new AddSuccessResult<List<Video>>(saveResults.Data, saveResults.Count, "Video(s) upload successful.");
                
                return new AddFailResult<List<Video>>(null, 0, "Video(s) upload failed.", ErrorCodes.Default);
            }
            catch (Exception)
            {
                return new AddFailResult<List<Video>>(null, 0, "Video(s) upload failed.", ErrorCodes.Default);
            }
        }

        private static string? GetMetadataValue(IReadOnlyDictionary<string, object> metadata, string key)
        {
            return metadata.ContainsKey(key) ? metadata[key] as string : null;
        }

        private static Stream CompressVideoFile(Stream stream)
        {
            try
            {
                using var video = new MagickImage(stream);

                video.Quality = 85;
                video.GaussianBlur(0.05);
                video.Strip();

                video.Interlace = video.Format switch
                {
                    MagickFormat.Png => Interlace.Png,
                    MagickFormat.Jpeg => Interlace.Jpeg,
                    MagickFormat.Gif => Interlace.Gif,

                    _ => Interlace.Plane
                };

                var compressedStream = new MemoryStream();
                video.Write(compressedStream, video.Format);
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
                using (var video = new MagickImage(stream))
                {
                    var exifProfile = video.GetExifProfile();

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

        private static ValidationResult ValidateFormVideo(IFormFile file)
        {
            return new ValidationResult(outcome: ValidationOutcome.Passed);
        }

        private static List<IFormFile> GetValidVideos(IEnumerable<IFormFile> files)
        {
            return files.Where(video => ValidateFormVideo(video).IsSuccess).ToList();
        }
    }
}
