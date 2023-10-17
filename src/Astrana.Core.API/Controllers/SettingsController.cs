/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Lookups.Queries;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.SystemSettings;
using Astrana.Core.Domain.Models.SystemSettings.Options;
using Astrana.Core.Domain.SystemSettings.Commands.UpdateSystemSettingsCommand;
using Astrana.Core.Domain.SystemSettings.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    public class SettingsController : BaseController<SettingsController>
    {
        private readonly ILogger<SettingsController> _logger;

        private readonly IGetSystemSettingsQuery _getSettingsQuery;
        private readonly IGetSettingCategoriesQuery _getSettingCategoriesQuery;

        private readonly IUpdateSystemSettingsCommand _updateSettingsCommand;
        private readonly IGetLookupQuery _getLookupQuery;

        public SettingsController(ILogger<SettingsController> logger, 
            ISignInManager signInManager, 
            IGetSystemSettingsQuery getSettingsQuery,
            IGetSettingCategoriesQuery getSettingCategoriesQuery,
            IUpdateSystemSettingsCommand updateSettingsCommand, 
            IGetLookupQuery getLookupQuery) : base(logger, signInManager)
        {
            _logger = logger;

            _getSettingsQuery = getSettingsQuery;
            _getSettingCategoriesQuery = getSettingCategoriesQuery;

            _updateSettingsCommand = updateSettingsCommand;
            _getLookupQuery = getLookupQuery;
        }

        /// <summary>
        /// Returns a paged set of settings according to the options provided.
        /// </summary>
        /// <param name="categories"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        /// <response code="200">Setting(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAsync([FromQuery]List<string> categories, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize)
        {
            var actioningUserId = GetActioningUserId(ActioningUserOptions.Anonymous);

            var queryOptions = new SystemSettingQueryOptions<Guid, Guid>
            {
                Categories = categories,

                PageSize = pageSize,
                CurrentPage = page
            };

            var result = await _getSettingsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(result, page, pageSize, result.Message);
        }

        /// <summary>
        /// Gets a setting by it's ID if it exists.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="200">Setting successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSettingByIdAsync(Guid id)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new SystemSettingQueryOptions<Guid, Guid>
            {
                Ids = new List<Guid> { id }
            };

            var result = await _getSettingsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return UnpagedGetResponse(result.Data.FirstOrDefault(), result.Message);
        }

        /// <summary>
        /// Returns a list setting categories.
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Setting Categories successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("Categories")]
        public IActionResult GetSystemSettingCategories()
        {
            var actioningUserId = GetActioningUserId();

            var result = _getSettingCategoriesQuery.Execute(actioningUserId);

            return UnpagedGetResponse(result);
        }

        /// <summary>
        /// Updates existing settings.
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        /// <response code="200">Setting(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPost]
        public async Task<IActionResult> UpdateSettings(IList<SystemSetting> settings)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _updateSettingsCommand.ExecuteAsync(settings, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return UpdatedSuccessResponse(result, result.Message);

                return FailureResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(settings);
            }
        }

        /// <summary>
        /// Returns the list of possible options for a given lookup/list.
        /// </summary>
        /// <param name="name"></param>
        /// <response code="200">Lookup successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        /// <returns></returns>
        [HttpGet("Lookup/{name}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetLookupAsync([Required]string name)
        {
            var actioningUserId = GetActioningUserId(ActioningUserOptions.Anonymous);

            var lookup = await _getLookupQuery.ExecuteAsync(actioningUserId, name);

            if (lookup == null)
                return ValidationResponse("Lookup not found.");

            return UnpagedGetResponse(lookup);
        }

        /// <summary>
        /// Returns the list of User and Peer slugs.
        /// </summary>
        /// <response code="200">Slugs successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        /// <returns></returns>
        [HttpGet("Slugs")]
        public async Task<IActionResult> GetSlugsAsync()
        {
            var actioningUserId = GetActioningUserId();

            var slugs = new Dictionary<string, string>
            {
                { "40e30344-1172-4dad-dc96-08db124d6ccb", "me" }
            };

            return UnpagedGetResponse(slugs);
        }
    }
}