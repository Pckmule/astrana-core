/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.SystemUpdates.DomainTransferObjects;
using Astrana.Core.Domain.Models.SystemUpdates.Enums;
using Astrana.Core.Domain.Models.SystemUpdates.Options;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.SystemUpdates.Queries
{
    public class GetSystemUpdatesQuery : IGetSystemUpdatesQuery
    {
        private readonly ILogger<GetSystemUpdatesQuery> _logger;

        public GetSystemUpdatesQuery(ILogger<GetSystemUpdatesQuery> logger)
        {
            _logger = logger;
        }

        public async Task<GetResult<SystemUpdateQueryOptions<Guid, Guid>, SystemUpdateDto, Guid, Guid>> ExecuteAsync(Guid actioningUserId, SystemUpdateQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new SystemUpdateQueryOptions<Guid, Guid>();

            var data = new List<SystemUpdateDto>
            {
                new()
                {
                    Type = SystemUpdateType.Major,
                    Version = "2.0.0",
                    Name = "Code Name X",
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Some description with details about this update.",
                    ReleaseAnnouncementAddress = "https://blog.astrana.org/announcements/astrana-2.0.0-generally-available",
                    ReleaseNotesAddress = "https://releases.astrana.org/2.0.0/notes",
                    ReleasedTimestamp = DateTimeOffset.UtcNow,
                    RequiredByTimestamp = DateTimeOffset.UtcNow.AddDays(180)
                },
                new()
                {
                    Type = SystemUpdateType.Minor,
                    Version = "1.1.0",
                    Name = "Lightning Rod",
                    Summary = "Some description with details about this update. Lorem Ipsum is simply dummy text of the printing and typesetting industry. ",
                    ReleaseAnnouncementAddress = "https://blog.astrana.org/announcements/astrana-1.1.0-generally-available",
                    ReleaseNotesAddress = "https://releases.astrana.org/1.1.0/notes",
                    ReleasedTimestamp = DateTimeOffset.UtcNow,
                    RequiredByTimestamp = DateTimeOffset.UtcNow.AddDays(15)
                },
                new()
                {
                    Type = SystemUpdateType.Patch,
                    Version = "1.0.2",
                    Name = "Patch Update",
                    Summary = "Some description with details about this update.",
                    ReleaseAnnouncementAddress = "https://blog.astrana.org/announcements/astrana-1.0.2-generally-available",
                    ReleaseNotesAddress = "https://releases.astrana.org/1.0.2/notes",
                    ReleasedTimestamp = DateTimeOffset.UtcNow,
                    RequiredByTimestamp = DateTimeOffset.UtcNow.AddDays(30)
                },
                new()
                {
                    Type = SystemUpdateType.Hotfix,
                    Version = "1.0.3",
                    Name = "Security Update",
                    Summary = " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Some description with details about this update.",
                    ReleaseAnnouncementAddress = "https://blog.astrana.org/announcements/astrana-1.0.3-generally-available",
                    ReleaseNotesAddress = "https://releases.astrana.org/1.0.3/notes",
                    ReleasedTimestamp = DateTimeOffset.UtcNow,
                    RequiredByTimestamp = DateTimeOffset.UtcNow.AddDays(30)
                }
            };

            _logger.LogTrace($"Executed {nameof(GetSystemUpdatesQuery).SplitOnUpperCase()}");

            return new GetResult<SystemUpdateQueryOptions<Guid, Guid>, SystemUpdateDto, Guid, Guid>(data, options, data.Count);
        }
    }
}