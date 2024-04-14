/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.SystemUpdates.Enums;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.SystemUpdates.DomainTransferObjects
{
    public sealed class SystemUpdateDto : IDomainTransferObject
    {
        public SystemUpdateType? Type { get; set; }

        public string? Version { get; set; }

        public string? Name { get; set; }

        public string? Summary { get; set; }

        public string? ReleaseAnnouncementAddress { get; set; }

        public string? ReleaseNotesAddress { get; set; }

        public DateTimeOffset? ReleasedTimestamp { get; set; }

        public DateTimeOffset? RequiredByTimestamp { get; set; }
    }
}