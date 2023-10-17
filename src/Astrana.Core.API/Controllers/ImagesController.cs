/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.Files.Commands.GetFileStream;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Images.Commands.SaveRemoteImage;
using Astrana.Core.Domain.Images.Commands.UploadImage;
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
    public class ImagesController : BaseController<ImagesController>
    {
        private readonly ILogger<ImagesController> _logger;

        private readonly IUploadImageCommand _uploadImageCommand;
        private readonly ISaveRemoteImageCommand _saveRemoteImageCommand;
        private readonly IGetFileStreamCommand _getFileStreamCommand;

        public ImagesController(ILogger<ImagesController> logger, 
            ISignInManager signInManager, 
            IUploadImageCommand uploadImageCommand, 
            ISaveRemoteImageCommand saveRemoteImageCommand,
            IGetFileStreamCommand getFileStreamCommand) : base(logger, signInManager)
        {
            _logger = logger;

            _uploadImageCommand = uploadImageCommand;
            _saveRemoteImageCommand = saveRemoteImageCommand;
            _getFileStreamCommand = getFileStreamCommand;
        }

        /// <summary>
        /// Uploads image files.
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        [HttpPost("Upload")]
        public async Task<IActionResult> Upload([FromForm] List<IFormFile> files)
        {
            var actioningUserId = GetActioningUserId();

            var result = await _uploadImageCommand.ExecuteAsync(files, actioningUserId);

            if (result.Outcome != ResultOutcome.Success)
                return ErrorResponse(result.Data, result.Message);
            
            return CreatedSuccessResponse(result, result.Message);
        }

        /// <summary>
        /// Save remote image.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        [HttpPost("SaveRemote")]
        public async Task<IActionResult> SaveRemoteImage(Uri url)
        {
            var actioningUserId = GetActioningUserId();

            var result = await _saveRemoteImageCommand.ExecuteAsync(url, actioningUserId);

            if (result.Outcome != ResultOutcome.Success)
                return ErrorResponse(result.Data, result.Message);
            
            return CreatedSuccessResponse(result, result.Message);
        }

        /// <summary>
        /// Proxies images from various internal and external sources.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Proxy/{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Proxy(string id)
        {
            // TODO: Add Authorization Logic

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