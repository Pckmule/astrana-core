/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.Files.Commands.GetFileStream;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Videos.Commands.SaveRemoteVideo;
using Astrana.Core.Domain.Videos.Commands.UploadVideo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Logging;
using System.Net.Mime;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    public class VideosController : BaseController<VideosController>
    {
        private readonly ILogger<VideosController> _logger;

        private readonly IUploadVideoCommand _uploadVideoCommand;
        private readonly ISaveRemoteVideoCommand _saveRemoteVideoCommand;
        private readonly IGetFileStreamCommand _getFileStreamCommand;

        public VideosController(ILogger<VideosController> logger, ISignInManager signInManager, IUploadVideoCommand uploadVideoCommand, ISaveRemoteVideoCommand saveRemoteVideoCommand, IGetFileStreamCommand getFileStreamCommand) : base(logger, signInManager)
        {
            _logger = logger;

            _uploadVideoCommand = uploadVideoCommand;
            _saveRemoteVideoCommand = saveRemoteVideoCommand;
            _getFileStreamCommand = getFileStreamCommand;
        }

        /// <summary>
        /// Uploads Video files.
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        [HttpPost("Upload")]
        public async Task<IActionResult> Upload([FromForm] List<IFormFile> files)
        {
            var actioningUserId = GetActioningUserId();

            var result = await _uploadVideoCommand.ExecuteAsync(files, actioningUserId);

            if (result.Outcome != ResultOutcome.Success)
                return ErrorResponse(result.Data, result.Message);
            
            return CreatedSuccessResponse(result, result.Message);
        }

        /// <summary>
        /// Save remote Video.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        [HttpPost("SaveRemote")]
        public async Task<IActionResult> SaveRemoteVideo(Uri url)
        {
            var actioningUserId = GetActioningUserId();

            var result = await _saveRemoteVideoCommand.ExecuteAsync(url, actioningUserId);

            if (result.Outcome != ResultOutcome.Success)
                return ErrorResponse(result.Data, result.Message);
            
            return CreatedSuccessResponse(result, result.Message);
        }

        /// <summary>
        /// Proxies Videos from various internal and external sources.
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