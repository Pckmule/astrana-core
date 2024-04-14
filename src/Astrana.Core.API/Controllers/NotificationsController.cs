/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Domain.AstranaApi.Services;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Models.Attachments.Enums;
using Astrana.Core.Domain.Models.ContentCollections.Options;
using Astrana.Core.Domain.Models.Notifications;
using Astrana.Core.Domain.Models.Notifications.DomainTransferObjects;
using Astrana.Core.Domain.Models.Notifications.Enums;
using Astrana.Core.Domain.Models.Notifications.Options;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Notifications.Commands.Handlers.CreateNotifications;
using Astrana.Core.Domain.Notifications.Commands.Handlers.UpdateNotifications;
using Astrana.Core.Domain.Notifications.Queries;
using Astrana.Core.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ApiConstants = Astrana.Core.Constants.Api;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    public class NotificationsController : BaseController<NotificationsController>
    {
        private readonly ILogger<NotificationsController> _logger;

        private readonly IGetNotificationsQuery _getNotificationsQuery;
        private readonly IUpdateNotificationsCommandHandler _updateNotificationsCommandHandler;

        public NotificationsController(ILogger<NotificationsController> logger, ISignInManager signInManager, IGetNotificationsQuery getNotificationsQuery, IUpdateNotificationsCommandHandler updateNotificationsCommandHandler) : base(logger, signInManager)
        {
            _logger = logger;

            _getNotificationsQuery = getNotificationsQuery;
            _updateNotificationsCommandHandler = updateNotificationsCommandHandler;
        }

        /// <summary>
        /// Returns a paged set of notifications according to the options provided.
        /// </summary>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdById"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="attachmentTypes"></param>
        /// <param name="orderBy"></param>
        /// <param name="orderByDirection"></param>
        /// <returns></returns>
        /// <response code="200">Notification(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] NotificationType[]? attachmentTypes = null, DateTime ? createdAfter = null, DateTime? createdBefore = null, Guid? createdById = null, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize, string? orderBy = null, OrderByDirection orderByDirection = OrderByDirection.Default)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new NotificationQueryOptions<Guid, Guid>
            {
                NotificationTypes = attachmentTypes?.Distinct().ToList(),

                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,

                PageSize = pageSize,
                CurrentPage = page,

                OrderByDirection = orderByDirection,
                OrderBy = orderBy
            };

            queryOptions.SetOwnerUserIds(createdById.AsList());

            var result = await _getNotificationsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse2(result, result.Data.Select(o => o.ToDomainTransferObject(includeAuditData: true)).ToList(), queryOptions.CurrentPage.Value, queryOptions.PageSize.Value, result.Message);
        }

        /// <summary>
        /// Gets a notification by it's ID if it exists.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="200">Notification successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNotificationByIdAsync(Guid id)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new NotificationQueryOptions<Guid, Guid>(id.AsList());

            var result = await _getNotificationsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return UnpagedGetResponse(result.Data.FirstOrDefault(), result.Message);
        }

        /// <summary>
        /// Updates existing notifications read status by ID.
        /// </summary>
        /// <param name="notificationStatuses"></param>
        /// <returns></returns>
        /// <response code="200">Notification(s) status successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPost]
        public async Task<IActionResult> UpdateNotificationsReadStatus(IList<NotificationStatusDto> notificationStatuses)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _updateNotificationsCommandHandler.ExecuteAsync(notificationStatuses, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return UpdatedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(notificationStatuses);
            }
        }
    }
}