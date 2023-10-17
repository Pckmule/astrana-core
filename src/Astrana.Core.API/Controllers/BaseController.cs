using Astrana.Core.API.Constants;
using Astrana.Core.Constants;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Models.AstranaApi;
using Astrana.Core.Domain.Models.AstranaApi.Responses;
using Astrana.Core.Domain.Models.Options.Contracts;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Exceptions;
using Astrana.Core.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;

namespace Astrana.Core.API.Controllers
{
    [Produces("application/json")]
    [Route($"{Api.RoutePrefix}/[controller]")]
    public class BaseController<TControllerType> : ControllerBase where TControllerType : class
    {
        protected readonly ILogger<TControllerType> _logger;
        protected readonly ISignInManager _signInManager;

        public const string RoutePrefix = "api";

        /// <summary>
        /// Base API Controller all other API Controllers should inherit from.
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="signInManager"></param>
        public BaseController(ILogger<TControllerType> logger, ISignInManager signInManager)
        {
            _logger = logger;
            _signInManager = signInManager;
        }

        /// <summary>
        /// Finds a request header by the header key/name and returns it's value.
        /// </summary>
        /// <param name="headerKey"></param>
        /// <returns></returns>
        protected string? GetHeaderValue(string headerKey)
        {
            if (Request == null || Request.Headers == null || !Request.Headers.Any())
                return null;

            if (Request.Headers.TryGetValue(headerKey, out var values))
                return values;

            _logger.LogInformation($"Could not get header with name \"{headerKey}\"");

            return null;
        }

        /// <summary>
        /// Returns the User Account ID for the current session.
        /// </summary>
        /// <param name="actioningUserOptions"></param>
        /// <returns></returns>
        /// <exception cref="InvalidUserException"></exception>
        protected Guid GetActioningUserId(ActioningUserOptions actioningUserOptions = ActioningUserOptions.Authenticated)
        {
            var authorizationHeader = GetHeaderValue("Authorization");

            if (authorizationHeader == null)
            {
                if (actioningUserOptions == ActioningUserOptions.Anonymous)
                    return Guid.Parse(AnonymousUser.Id);
                
                throw new InvalidUserException("Actioning User is invalid.");
            }

            var token = _signInManager.ReadAuthToken(authorizationHeader.Split(" ").Last());

            var subjectClaim = token.Claims.First(o => o.Type == "sub");

            return Guid.Parse(subjectClaim.Value);
        }

        /// <summary>
        /// Builds a standard API response wrapper for query without pagination.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="message"></param>
        /// <typeparam name="TData"></typeparam>
        /// <returns></returns>
        protected OkObjectResult UnpagedGetResponse<TData>(TData data, string message = null)
        {
            return Ok(new ApiResponse<dynamic>(data, message));
        }

        /// <summary>
        /// Builds a standard API response wrapper for query with pagination.
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="result"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        protected OkObjectResult PagedGetResponse<TData>(IGetResult<TData> result, long page, long pageSize, string message = null)
        {
            return Ok(new ApiGetResponse<dynamic>(result.Data, message)
            {
                ResultSetCount = result.ResultSetCount,
                ResultCount = result.Data.Count,
                PageCount = result.PageCount,
                PageSize = result.PageSize,
                CurrentPage = result.CurrentPage,
                NextPage = BuildGetEndpointUrl(page.CalculateNextPage(pageSize, result.ResultSetCount), pageSize),
                PreviousPage = BuildGetEndpointUrl(page.CalculatePreviousPage(), pageSize),
                LastPage = BuildGetEndpointUrl(result.ResultSetCount.CalculateLastPage(pageSize), pageSize)
            });
        }

        protected OkObjectResult PagedGetResponse2<TData, TDto>(IGetResult<TData> result, List<TDto> data, long page, long pageSize, string message = null)
        {
            return Ok(new ApiGetResponse<dynamic>(data, message)
            {
                ResultSetCount = result.ResultSetCount,
                ResultCount = data.Count,
                PageCount = result.PageCount,
                PageSize = result.PageSize,
                CurrentPage = result.CurrentPage,
                NextPage = BuildGetEndpointUrl(page.CalculateNextPage(pageSize, result.ResultSetCount), pageSize),
                PreviousPage = BuildGetEndpointUrl(page.CalculatePreviousPage(), pageSize),
                LastPage = BuildGetEndpointUrl(result.ResultSetCount.CalculateLastPage(pageSize), pageSize)
            });
        }

        /// <summary>
        /// Builds a standard API response wrapper for query metadata with pagination.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        protected OkObjectResult PagedGetMetaResponse(IGetResultMetadata result, long page, long pageSize, string message = null)
        {
            return Ok(new ApiGetResponse<dynamic>(null, message)
            {
                ResultSetCount = result.ResultSetCount,
                ResultCount = null,
                PageCount = result.PageCount,
                PageSize = result.PageSize,
                CurrentPage = result.CurrentPage,
                NextPage = BuildGetEndpointUrl(page.CalculateNextPage(pageSize, result.ResultSetCount), pageSize),
                PreviousPage = BuildGetEndpointUrl(page.CalculatePreviousPage(), pageSize),
                LastPage = BuildGetEndpointUrl(result.ResultSetCount.CalculateLastPage(pageSize), pageSize)
            });
        }

        /// <summary>
        /// Builds a standard API response wrapper for a successful authentication outcome.
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        protected OkObjectResult AuthenticationSuccessResponse(string token)
        {
            return Ok(token);
        }

        /// <summary>
        /// Builds a standard API response wrapper for an action that has a precondition to exist before it can be executed.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        protected ObjectResult PreconditionRequiredResponse(string? message = ApiResponseMessages.DefaultPreconditionResponseMessage)
        {
            return StatusCode((int)HttpStatusCode.PreconditionRequired, new ApiResponse<dynamic>(null, message));
        }

        /// <summary>
        /// Builds a standard API response wrapper for a successful execution of an action, without data to return.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        protected ObjectResult ExecutionSuccessResponse(string? message = null)
        {
            return StatusCode((int)HttpStatusCode.OK, new ApiResponse<dynamic>(null, message));
        }

        /// <summary>
        /// Builds a standard API response wrapper for a successful execution of an action, with data to return.
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="result"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        protected OkObjectResult ExecutionSuccessResponse<TData>(IExecutionResult<TData> result, string? message = null)
        {
            return Ok(new ApiResponse<dynamic>(result.Data, message));
        }

        /// <summary>
        /// HTTP Response for Successful Create Operations
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        protected ObjectResult CreatedSuccessResponse(string? message = null)
        {
            return StatusCode((int)HttpStatusCode.Created, new ApiResponse<dynamic>(null, message));
        }

        /// <summary>
        /// HTTP Response for Successful Create Operations
        /// </summary>
        /// <param name="result"></param>
        /// <param name="message"></param>
        /// <typeparam name="TData"></typeparam>
        /// <returns></returns>
        protected OkObjectResult CreatedSuccessResponse<TData>(IAddResult<TData> result, string? message = null)
        {
            return Ok(new ApiResponse<dynamic>(result.Data, message));
        }

        protected OkObjectResult CreatedSuccessResponse2<TData>(TData data, string? message = null)
        {
            return Ok(new ApiResponse<dynamic>(data, message));
        }

        /// <summary>
        /// HTTP Response for Successful Update Operations
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        protected ObjectResult UpdatedSuccessResponse(string? message = null)
        {
            return StatusCode((int)HttpStatusCode.NoContent, new ApiResponse<dynamic>(null, message));
        }

        /// <summary>
        /// HTTP Response for Successful Update Operations
        /// </summary>
        /// <param name="result"></param>
        /// <param name="message"></param>
        /// <typeparam name="TData"></typeparam>
        /// <returns></returns>
        protected OkObjectResult UpdatedSuccessResponse<TData>(IUpdateResult<TData> result, string? message = null)
        {
            return Ok(new ApiResponse<dynamic>(result.Data, message));
        }

        /// <summary>
        /// HTTP Response for Successful Delete Operations
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        protected ObjectResult DeletedSuccessResponse(string? message = null)
        {
            return StatusCode((int)HttpStatusCode.NoContent, new ApiResponse<dynamic>(null, message));
        }

        /// <summary>
        /// HTTP Response for Successful Delete Operations
        /// </summary>
        /// <param name="result"></param>
        /// <param name="message"></param>
        /// <typeparam name="TData"></typeparam>
        /// <returns></returns>
        protected OkObjectResult DeletedSuccessResponse<TData>(IDeleteResult<TData> result, string? message = null)
        {
            return Ok(new ApiResponse<dynamic>(result.Data, message));
        }
        
        /// <summary>
        /// HTTP Response for Operations that cannot be completed due to validation failures.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="failedItems"></param>
        /// <returns></returns>
        protected ObjectResult ValidationResponse(string? message = ApiResponseMessages.DefaultValidationResponseMessage, IList<ApiResponseFailedItem>? failedItems = null)
        {
            return BadRequest(new ApiResponse<dynamic>(null, message, failedItems));
        }

        /// <summary>
        /// HTTP Response for Operations that cannot be completed.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        protected ObjectResult FailureResponse(string message = ApiResponseMessages.DefaultFailureResponseMessage)
        {
            return StatusCode((int)HttpStatusCode.UnprocessableEntity, new ApiResponse<dynamic>(null, message));
        }

        /// <summary>
        /// HTTP Response for Operations that cannot be completed.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="message"></param>
        /// <typeparam name="TData"></typeparam>
        /// <returns></returns>
        protected ObjectResult FailureResponse<TData>(TData data, string? message = ApiResponseMessages.DefaultFailureResponseMessage)
        {
            return StatusCode((int)HttpStatusCode.UnprocessableEntity, new ApiResponse<dynamic>(data, message));
        }

        /// <summary>
        /// HTTP Response for Operations that have failed with errors.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        protected ObjectResult ErrorResponse(string message = ApiResponseMessages.DefaultErrorResponseMessage)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, new ApiResponse<dynamic>(null, message));
        }

        /// <summary>
        /// HTTP Response for Operations that have failed with errors.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="message"></param>
        /// <typeparam name="TData"></typeparam>
        /// <returns></returns>
        protected ObjectResult ErrorResponse<TData>(TData data, string? message = ApiResponseMessages.DefaultErrorResponseMessage)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, new ApiResponse<dynamic>(data, message));
        }

        /// <summary>
        /// Builds an API endpoint URL for a request to retrieve or query data.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        protected string BuildGetEndpointUrl(long? page, long? pageSize)
        {
            var endpointUrl = "";

            if (Request.Host.HasValue)
                endpointUrl += $"{Request.Scheme}://{Request.Host.Value}";

            if (!string.IsNullOrWhiteSpace(Request.Path))
                endpointUrl += Request.Path;

            if (string.IsNullOrWhiteSpace(endpointUrl))
                return string.Empty;

            var queryParameters = new List<string>();

            if (page.HasValue)
                queryParameters.Add($"{nameof(page).ToLower()}={page}");

            if (pageSize.HasValue)
                queryParameters.Add($"{nameof(pageSize).ToLower()}={pageSize}");

            var queryString = "";

            if (queryParameters.Any())
                queryString = "?" + string.Join("&", queryParameters);

            return endpointUrl + queryString;
        }
        
        protected GetResult<TQueryOptions, TResponseData, TRecordId, TOwnerUserId> ConvertToGetResult<TQueryOptions, TRecordId, TOwnerUserId, TResponseData>(ApiCallerResult<List<TResponseData>> apiResult, TQueryOptions queryOptions)
            where TQueryOptions : class, IQueryOptions<TRecordId, TOwnerUserId>, new()
            where TRecordId : struct
            where TOwnerUserId : struct
        {
            if (apiResult.IsSuccess)
            {
                var response = apiResult.GetContent() as ApiGetResponse<List<TResponseData>>;

                if (response == null)
                    return null;

                return new GetResult<TQueryOptions, TResponseData, TRecordId, TOwnerUserId>(response.Data ?? new List<TResponseData>(), queryOptions, response.ResultSetCount ?? 0, response.Message ?? string.Empty);
            }

            return null;
        }
    }

    public enum ActioningUserOptions
    {
        Authenticated,
        Anonymous
    }
}
