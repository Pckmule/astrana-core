using Astrana.Core.API.Constants;
using Astrana.Core.Constants;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Models.AstranaApi.Responses;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Exceptions;
using Astrana.Core.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;

namespace Astrana.Core.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BaseController<TControllerType> : ControllerBase where TControllerType : class
    {
        protected readonly ILogger<TControllerType> _logger;
        protected readonly ISignInManager _signInManager;

        public BaseController(ILogger<TControllerType> logger, ISignInManager signInManager)
        {
            _logger = logger;
            _signInManager = signInManager;
        }

        protected string GetHeaderValue(string headerKey)
        {
            if (Request == null || Request.Headers == null || !Request.Headers.Any())
                return null;

            if (Request.Headers.TryGetValue(headerKey, out var values))
                return values;

            _logger.LogInformation($"Could not get header with name \"{headerKey}\"");

            return null;
        }

        protected Guid GetActioningUserId(bool allowAnonymousUser = false)
        {
            var authorizationHeader = GetHeaderValue("Authorization");

            if (authorizationHeader == null)
            {
                if (allowAnonymousUser)
                    return Guid.Parse(AnonymousUser.Id);
                
                throw new InvalidUserException("Actioning User is invalid.");
            }

            var token = _signInManager.ReadAuthToken(authorizationHeader.Split(" ").Last());

            var subjectClaim = token.Claims.FirstOrDefault(o => o.Type == "sub");

            return Guid.Parse(subjectClaim.Value);
        }

        protected OkObjectResult UnpagedGetResponse<TData>(TData data, string message = null)
        {
            return Ok(new ApiResponse<dynamic>(data, message));
        }

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

        protected OkObjectResult AuthenticationSuccessResponse(string token)
        {
            return Ok(token);
        }

        protected ObjectResult ExecutionSuccessResponse(string message = null)
        {
            return StatusCode((int)HttpStatusCode.OK, new ApiResponse<dynamic>(null, message));
        }

        protected OkObjectResult ExecutionSuccessResponse<TData>(IExecutionResult<TData> result, string message = null)
        {
            return Ok(new ApiResponse<dynamic>(result.Data, message));
        }

        /// <summary>
        /// HTTP Response for Successful Create Operations
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        protected ObjectResult CreatedSuccessResponse(string message = null)
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
        protected OkObjectResult CreatedSuccessResponse<TData>(IAddResult<TData> result, string message = null)
        {
            return Ok(new ApiResponse<dynamic>(result.Data, message));
        }

        /// <summary>
        /// HTTP Response for Successful Update Operations
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        protected ObjectResult UpdatedSuccessResponse(string message = null)
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
        protected OkObjectResult UpdatedSuccessResponse<TData>(IUpdateResult<TData> result, string message = null)
        {
            return Ok(new ApiResponse<dynamic>(result.Data, message));
        }

        /// <summary>
        /// HTTP Response for Successful Delete Operations
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        protected ObjectResult DeletedSuccessResponse(string message = null)
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
        protected OkObjectResult DeletedSuccessResponse<TData>(IDeleteResult<TData> result, string message = null)
        {
            return Ok(new ApiResponse<dynamic>(result.Data, message));
        }


        /// <summary>
        /// HTTP Response for Operations that cannot be completed due to validation failures.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="failedItems"></param>
        /// <returns></returns>
        protected ObjectResult ValidationResponse(string message = ApiResponseMessages.DefaultValidationResponseMessage, IList<ApiResponseFailedItem>? failedItems = null)
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
        protected ObjectResult FailureResponse<TData>(TData data, string message = ApiResponseMessages.DefaultFailureResponseMessage)
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
        protected ObjectResult ErrorResponse<TData>(TData data, string message = ApiResponseMessages.DefaultErrorResponseMessage)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, new ApiResponse<dynamic>(data, message));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        protected string BuildGetEndpointUrl(long? page, long? pageSize)
        {
            var endpointUrl = "";

            if (Request != null)
            {
                if (Request.Host.HasValue)
                    endpointUrl += $"{Request.Scheme}://{Request.Host.Value}";

                if (!string.IsNullOrWhiteSpace(Request.Path))
                    endpointUrl += Request.Path;
            }

            if (string.IsNullOrWhiteSpace(endpointUrl))
                return null;

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
    }
}
