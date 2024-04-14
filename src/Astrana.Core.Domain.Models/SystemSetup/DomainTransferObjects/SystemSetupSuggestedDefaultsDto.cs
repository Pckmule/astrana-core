/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.SystemSetup.DomainTransferObjects
{
    public sealed class SystemSetupSuggestedDefaultsDto : IDomainTransferObject
    {
        public string? LanguageCode { get; set; }

        public string? CountryCode { get; set; }
        
        public string? TimeZoneId { get; set; }
    }
}