/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.ExternalContent.ContentLinks.DomainTransferObjects
{
    public sealed class AddContentLinkDto : IDomainTransferObject
    {
        public Uri? Url { get; set; }

        public string? Name { get; set; }

        public string? IconUrl { get; set; }
    }
}