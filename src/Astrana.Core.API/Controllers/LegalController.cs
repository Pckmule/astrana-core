/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Enums;
using Astrana.Core.Legal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    public class LegalController : BaseController<LegalController>
    {
        private readonly ILogger<LegalController> _logger;

        private readonly ILegalService _legalService;

        public LegalController(ILogger<LegalController> logger, ISignInManager signInManager, ILegalService legalService) : base(logger, signInManager)
        {
            _logger = logger;
            _legalService = legalService;
        }

        /// <summary>
        /// Returns the Astrana license.
        /// </summary>
        /// <returns></returns>
        /// <response code="200">License successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("License")]
        [AllowAnonymous]
        public IActionResult GetLicense(string languageCode, ContentFormat format = ContentFormat.Default)
        {
            return Ok(_legalService.GetLicense(languageCode, format));
        }
    }
}