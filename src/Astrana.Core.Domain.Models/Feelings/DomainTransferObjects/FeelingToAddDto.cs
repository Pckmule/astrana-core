/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.Feelings.DomainTransferObjects
{
    public sealed class FeelingToAddDto : IDomainTransferObject
    {
        public string? Name { get; set; }

        public string? NameTrxCode { get; set; }

        public string? IconName { get; set; }

        public string? UnicodeIcon { get; set; }

        public string? ShortCode { get; set; }
    }
}