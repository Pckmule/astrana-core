/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Languages.Queries;
using Astrana.Core.Domain.Models.Languages.Options;
using Astrana.Core.Localization;
using Astrana.Core.Localization.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InternationalizationController : BaseController<InternationalizationController>
    {
        private readonly ILogger<InternationalizationController> _logger;
        private readonly IConfiguration _configuration;

        private readonly IGetLanguagesQuery _getLanguagesQuery;

        public InternationalizationController(IConfiguration configuration, ILogger<InternationalizationController> logger, ISignInManager signInManager, IGetLanguagesQuery getLanguagesQuery) : base(logger, signInManager)
        {
            _configuration = configuration;
            _logger = logger;
            
            _getLanguagesQuery = getLanguagesQuery;
        }

        /// <summary>
        /// Returns translations for the given translation keys.
        /// </summary>
        /// <param name="languageCode"></param>
        /// <param name="translationKeys"></param>
        /// <returns></returns>
        /// <response code="200">Translation(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [AllowAnonymous]
        [HttpGet("translations")]
        public IActionResult GetTranslations(string languageCode, [FromQuery][Required]List<string> translationKeys)
        {
            try
            {
                return UnpagedGetResponse(new Translator(languageCode).GetTranslations(translationKeys));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(new { languageCode, translationKeys });
            }
        }

        /// <summary>
        /// Returns all translations for the given language code.
        /// </summary>
        /// <param name="languageCode"></param>
        /// <returns></returns>
        /// <response code="200">Translation(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [AllowAnonymous]
        [HttpGet("translations/all")]
        public IActionResult GetAllTranslations(string languageCode)
        {
            try
            {
                return UnpagedGetResponse(new Translator(languageCode).GetAllTranslations());
            }
            catch (TranslationsFileNotFoundException ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(new { languageCode }, $"{languageCode} is not supported.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(new { languageCode });
            }
        }

        /// <summary>
        /// Returns languages supported by the system.
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Language(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [AllowAnonymous]
        [HttpGet("languages")]
        public async Task<IActionResult> GetLanguagesAsync(LanguageQueryOptions<Guid, Guid>? queryOptions = null)
        {
            var actioningUserId = GetActioningUserId(true);

            queryOptions ??= new LanguageQueryOptions<Guid, Guid>();

            try
            {
                return UnpagedGetResponse(await _getLanguagesQuery.ExecuteAsync(actioningUserId, queryOptions));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse();
            }
        }
    }
}