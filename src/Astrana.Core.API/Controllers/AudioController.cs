/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.AudioClips.Commands.SaveRemoteAudio;
using Astrana.Core.Domain.AudioClips.Commands.UploadAudio;
using Astrana.Core.Domain.Files.Commands.GetFileStream;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Models.Results.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Logging;
using System.Net.Mime;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    public class AudioController : BaseController<AudioController>
    {
        private readonly ILogger<AudioController> _logger;

        private readonly IUploadAudioCommand _uploadAudioCommand;
        private readonly ISaveRemoteAudioCommand _saveRemoteAudioCommand;
        private readonly IGetFileStreamCommand _getFileStreamCommand;

        public AudioController(ILogger<AudioController> logger, ISignInManager signInManager, IUploadAudioCommand uploadAudioCommand, ISaveRemoteAudioCommand saveRemoteAudioCommand, IGetFileStreamCommand getFileStreamCommand) : base(logger, signInManager)
        {
            _logger = logger;

            _uploadAudioCommand = uploadAudioCommand;
            _saveRemoteAudioCommand = saveRemoteAudioCommand;
            _getFileStreamCommand = getFileStreamCommand;
        }

        /// <summary>
        /// Uploads Audio files.
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        [HttpPost("Upload")]
        public async Task<IActionResult> Upload([FromForm] List<IFormFile> files)
        {
            var actioningUserId = GetActioningUserId();

            var result = await _uploadAudioCommand.ExecuteAsync(files, actioningUserId);

            if (result.Outcome != ResultOutcome.Success)
                return ErrorResponse(result.Data, result.Message);
            
            return CreatedSuccessResponse(result, result.Message);
        }

        /// <summary>
        /// Save remote Audio.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        [HttpPost("SaveRemote")]
        public async Task<IActionResult> SaveRemoteAudio(Uri url)
        {
            var actioningUserId = GetActioningUserId();

            var result = await _saveRemoteAudioCommand.ExecuteAsync(url, actioningUserId);

            if (result.Outcome != ResultOutcome.Success)
                return ErrorResponse(result.Data, result.Message);
            
            return CreatedSuccessResponse(result, result.Message);
        }

        /// <summary>
        /// Proxies Audio from various internal and external sources.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Proxy/{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Proxy(string id)
        {
            var actioningUserId = GetActioningUserId(ActioningUserOptions.Anonymous);

            var result = await _getFileStreamCommand.ExecuteAsync(id, actioningUserId);

            if (result.Outcome != ResultOutcome.Success)
                return ErrorResponse(result.Data, result.Message);

            if (result.Data == null || result.Data.Length < 1)
                return NotFound();

            result.Data.Position = 0;
            
            new FileExtensionContentTypeProvider().TryGetContentType(id, out var contentType);

            Response.Headers.Add(Headers.Names.ContentDisposition, new ContentDisposition { FileName = id, Inline = true }.ToString());

            return File(result.Data, contentType ?? "application/octet-stream");
        }
    }
}