/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.UserProfiles.Enums;

namespace Astrana.Core.Domain.Models.SystemSetup
{
    public interface IInstanceSetupRequest
    {
        string InstanceUsername { get; set; }

        string InstanceUserEmailAddress { get; set; }

        string InstanceUserPassword { get; set; }

        string InstanceUserFirstName { get; set; }

        string? InstanceUserMiddleNames { get; set; }

        string? InstanceUserLastName { get; set; }

        DateTimeOffset InstanceUserDateOfBirth { get; set; }

        Gender InstanceUserGender { get; set; }

        string InstancePhoneCountryCodeISO { get; set; }

        string InstancePhoneNumber { get; set; }

        string InstanceLanguageCode { get; set; }

        string InstanceCountryCode { get; set; }

        string InstanceTimeZone { get; set; }
    }
}
