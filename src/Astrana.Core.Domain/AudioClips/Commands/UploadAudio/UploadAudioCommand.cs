/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* Audio, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Data.Repositories.Audios;
using Astrana.Core.Domain.Files.Builders;
using Astrana.Core.Domain.Files.Commands.UploadFile;
using Astrana.Core.Domain.Files.Queries.GetFileInfo;
using Astrana.Core.Domain.Models.AstranaApi.Contracts;
using Astrana.Core.Domain.Models.AudioClips;
using Astrana.Core.Domain.Models.AudioClips.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Enums;
using ImageMagick;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.AudioClips.Commands.UploadAudio
{
    public class UploadAudioCommand : IUploadAudioCommand
    {
        private readonly ILogger<UploadAudioCommand> _logger;
        private readonly IAstranaApiInfo _astranaApiInfo;

        private readonly IUploadFileCommand _uploadFileCommand;
        private readonly IAudioRepository<Guid> _audioRepository;
        private readonly IGetFileInfoQuery _getFileInfoQuery;

        public UploadAudioCommand(ILogger<UploadAudioCommand> logger, IAstranaApiInfo astranaApiInfo, IUploadFileCommand uploadFileCommand, IAudioRepository<Guid> audioRepository, IGetFileInfoQuery getFileInfoQuery)
        {
            _logger = logger;
            _astranaApiInfo = astranaApiInfo;

            _uploadFileCommand = uploadFileCommand;
            _audioRepository = audioRepository;
            _getFileInfoQuery = getFileInfoQuery;
        }

        public async Task<AddResult<List<AudioClip>>> ExecuteAsync(List<IFormFile> files, Guid actioningUserId)
        {
            var audios = new List<AudioClip>();

            if (files.Count < 1)
                return new AddFailResult<List<AudioClip>>(audios, audios.Count, "No audios provided to upload.");

            var validAudio = GetValidAudio(files);

            if (validAudio.Count < 1)
                return new AddFailResult<List<AudioClip>>(audios, audios.Count, "Audio(s) upload failed.", "No valid audios.");

            try
            {
                var fileUploadResult = await _uploadFileCommand.ExecuteAsync(files, actioningUserId, GetFileMetadata, CompressAudioFile);

                if (fileUploadResult.Outcome != ResultOutcome.Success)
                    return new AddFailResult<List<AudioClip>>(null, audios.Count, "Audio(s) upload failed. " + fileUploadResult.Message, fileUploadResult.ResultCode);

                var audiosToAdd = fileUploadResult.Data.Select(uploadedFile => new AudioToAdd
                {
                    Location = FileProxyUrlBuilder.GetUrl(uploadedFile), 
                    Caption = GetMetadataValue(uploadedFile.Metadata, ExifTagNames.AudioDescription), 
                    Copyright = GetMetadataValue(uploadedFile.Metadata, ExifTagNames.Copyright)

                }).ToList();

                var saveResults = await _audioRepository.CreateAsync(audiosToAdd, actioningUserId);

                if (saveResults.HasData)
                {
                    foreach (var audio in saveResults.Data.Where(audio => audio.Location.StartsWith("/")))
                    {
                        audio.Size = _getFileInfoQuery.Execute(audio.Location.StartsWith("/") ? Path.Join(_uploadFileCommand.FilesRootPath, audio.Location) : audio.Location).Size;
                        audio.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Audio, audio.Location);
                    }
                }

                if (saveResults.Outcome == ResultOutcome.Success)
                    return new AddSuccessResult<List<AudioClip>>(saveResults.Data, saveResults.Count, "Audio(s) upload successful.");
                
                return new AddFailResult<List<AudioClip>>(null, 0, "Audio(s) upload failed.", ErrorCodes.Default);
            }
            catch (Exception)
            {
                return new AddFailResult<List<AudioClip>>(null, 0, "Audio(s) upload failed.", ErrorCodes.Default);
            }
        }

        private static string? GetMetadataValue(IReadOnlyDictionary<string, object> metadata, string key)
        {
            return metadata.ContainsKey(key) ? metadata[key] as string : null;
        }

        private static Stream CompressAudioFile(Stream stream)
        {
            try
            {
                using var audio = new MagickImage(stream);

                audio.Quality = 85;
                audio.GaussianBlur(0.05);
                audio.Strip();

                audio.Interlace = audio.Format switch
                {
                    MagickFormat.Png => Interlace.Png,
                    MagickFormat.Jpeg => Interlace.Jpeg,
                    MagickFormat.Gif => Interlace.Gif,

                    _ => Interlace.Plane
                };

                var compressedStream = new MemoryStream();
                audio.Write(compressedStream, audio.Format);
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
                using (var audio = new MagickImage(stream))
                {
                    var exifProfile = audio.GetExifProfile();

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

        private static ValidationResult ValidateFormAudio(IFormFile file)
        {
            return new ValidationResult(outcome: ValidationOutcome.Passed);
        }

        private static List<IFormFile> GetValidAudio(IEnumerable<IFormFile> files)
        {
            return files.Where(audio => ValidateFormAudio(audio).IsSuccess).ToList();
        }
    }
}
