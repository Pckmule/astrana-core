/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.Countries.Commands.CreateCountries;
using Astrana.Core.Domain.Countries.Commands.DeleteCountries;
using Astrana.Core.Domain.Countries.Commands.UpdateCountries;
using Astrana.Core.Domain.Countries.Queries;
using Astrana.Core.Domain.Database.Commands.TestConnection;
using Astrana.Core.Domain.Database.Queries;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Models.Countries;
using Astrana.Core.Domain.Models.Countries.Options;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System;
using Astrana.Core.Domain.Models.SystemSetup;
using Astrana.Core.Domain.Models.SystemSetup.Enums;
using Astrana.Core.Domain.SystemSetup.Commands.SetupInstance;
using Astrana.Core.Domain.SystemSetup.Queries;
using Astrana.Core.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SystemController : BaseController<SystemController>
    {
        private readonly ILogger<SystemController> _logger;
        private readonly IConfiguration _configuration;

        private readonly IGetCountriesQuery _getCountriesQuery;
        private readonly ICreateCountriesCommand _createCountriesCommand;
        private readonly IUpdateCountriesCommand _updateCountriesCommand;
        private readonly IDeleteCountriesCommand _deleteCountriesCommand;

        private readonly IGetSystemSetupStatusQuery _getSystemSetupStatusQuery;
        private readonly ISetupInstanceCommand _setupInstanceCommand;

        private readonly ITestDatabaseConnectionCommand _testDatabaseConnectionCommand;
        private readonly IGetDatabaseSettingsQuery _getDatabaseSettingsQuery;

        public SystemController(IConfiguration configuration, ILogger<SystemController> logger, ISignInManager signInManager, 
            IGetCountriesQuery getCountriesQuery, 
            ICreateCountriesCommand createCountriesCommand, 
            IUpdateCountriesCommand updateCountriesCommand, 
            IDeleteCountriesCommand deleteCountriesCommand, 
            IGetSystemSetupStatusQuery getSystemSetupStatusQuery,
            ISetupInstanceCommand setupInstanceCommand,
            ITestDatabaseConnectionCommand testDatabaseConnectionCommand,
            IGetDatabaseSettingsQuery getDatabaseSettingsQuery) : base(logger, signInManager)
        {
            _configuration = configuration;
            _logger = logger;

            _getCountriesQuery = getCountriesQuery;
            _createCountriesCommand = createCountriesCommand;
            _updateCountriesCommand = updateCountriesCommand;
            _deleteCountriesCommand = deleteCountriesCommand;
            
            _getSystemSetupStatusQuery = getSystemSetupStatusQuery;
            _setupInstanceCommand = setupInstanceCommand;
            
            _testDatabaseConnectionCommand = testDatabaseConnectionCommand;
            _getDatabaseSettingsQuery = getDatabaseSettingsQuery;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <response code="200">System Status successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("Status")]
        public SystemStatus GetStatus()
        {
            return new SystemStatus("OK");
        }

        /// <summary>
        /// Returns the Astrana application version.
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Application Version successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("Version/Application")]
        [AllowAnonymous]
        public IActionResult GetApplicationVersion()
        {
            return Ok(VersionUtility.GetVersion(typeof(VersionUtility)).ToString());
        }

        /// <summary>
        /// Returns the Astrana Web API version.
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Web API Version successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("Version/WebApi")]
        [AllowAnonymous]
        public IActionResult GetApiVersion()
        {
            return Ok(VersionUtility.GetVersion<SystemController>().ToString());
        }

        /// <summary>
        /// Returns a paged set of supported countries.
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Countries successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("Countries")]
        [AllowAnonymous]
        public async Task<IActionResult> GetSupportCountriesAsync(int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize)
        {
            var queryOptions = new CountryQueryOptions<long, Guid>
            {
                PageSize = pageSize,
                CurrentPage = page
            };

            var result = await _getCountriesQuery.ExecuteAsync(GetActioningUserId(true), queryOptions);

            return PagedGetResponse(result, page, pageSize, result.Message);
        }

        /// <summary>
        /// Creates new countries.
        /// </summary>
        /// <param name="countries"></param>
        /// <returns></returns>
        /// <response code="201">Countries successfully created.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="422">Countries could not be successfully created.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPut("Countries")]
        public async Task<IActionResult> CreateCountries(IList<CountryToAdd> countries)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _createCountriesCommand.ExecuteAsync(countries, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return CreatedSuccessResponse(result, result.Message);

                return FailureResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(countries);
            }
        }

        /// <summary>
        /// Updates existing countries.
        /// </summary>
        /// <param name="countries"></param>
        /// <returns></returns>
        /// <response code="200">Countries successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="422">Updates could not be successfully executed.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPost("Countries")]
        public async Task<IActionResult> UpdateCountries(IList<Country> countries)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _updateCountriesCommand.ExecuteAsync(countries, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return UpdatedSuccessResponse(result, result.Message);

                return FailureResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(countries);
            }
        }

        /// <summary>
        /// Deletes existing countries by their IDs.
        /// </summary>
        /// <param name="countryIds"></param>
        /// <returns></returns>
        /// <response code="200">Countries successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="422">Deletions could not be successfully executed.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpDelete("Countries")]
        public async Task<IActionResult> DeleteCountries(IList<long> countryIds)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _deleteCountriesCommand.ExecuteAsync(countryIds, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return DeletedSuccessResponse(result, result.Message);

                return FailureResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(countryIds);
            }
        }

        /// <summary>
        /// Returns the setup status of the Astrana instance.
        /// </summary>
        /// <returns></returns>
        /// <response code="200">System Setup Status successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("Setup/Status")]
        [AllowAnonymous]
        public async Task<IActionResult> SetupStatus()
        {
            var status = await _getSystemSetupStatusQuery.ExecuteAsync(GetActioningUserId(true));

            return Ok(status);
        }

        /// <summary>
        /// Readies the Astrana instance for usage.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <response code="200">System setup is completed.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="422">System setup could not be successfully executed.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPost("Setup")]
        [AllowAnonymous]
        public async Task<IActionResult> Setup(InstanceSetupRequest? options)
        {
            try
            {
                var result = await _setupInstanceCommand.ExecuteAsync(options, GetActioningUserId(true));

                if (result.Outcome == ResultOutcome.Success)
                    return CreatedSuccessResponse(result, result.Message);
                
                return FailureResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(options);
            }
        }

        /// <summary>
        /// Tests a database connection can be established.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <response code="200">Database connection can be established.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="422">Testing could not be successfully executed.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPost("Setup/Database/Test")]
        [AllowAnonymous]
        public async Task<IActionResult> SetupTestDatabaseConnection(TestDatabaseConnectionRequest request)
        {
            try
            {
                var result = await _testDatabaseConnectionCommand.ExecuteAsync(request, GetActioningUserId(true));

                if (result.Outcome == ResultOutcome.Success)
                    return ExecutionSuccessResponse(result.Message);

                return FailureResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(request);
            }
        }

        /// <summary>
        /// Returns the database settings configured for the Astrana instance.
        /// </summary>
        /// <returns></returns>
        /// <response code="200">System Database Settings successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("Setup/Database/Settings")]
        [AllowAnonymous]
        public async Task<IActionResult> GetDatabaseSettingsAsync()
        {
            var setupStatus = await _getSystemSetupStatusQuery.ExecuteAsync(GetActioningUserId(true));

            if(setupStatus == SystemSetupStatus.New || setupStatus == SystemSetupStatus.InProgress)
            {
                return UnpagedGetResponse(_getDatabaseSettingsQuery.Execute(GetActioningUserId(true)));
            }

            return BadRequest("This endpoint is not available after setup is completed.");
        }
    }
}