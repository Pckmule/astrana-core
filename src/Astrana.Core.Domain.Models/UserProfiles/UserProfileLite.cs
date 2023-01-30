/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Attributes;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.UserProfiles.Enums;

namespace Astrana.Core.Domain.Models.UserProfiles
{
    public sealed class UserProfileLite
    {
        public UserProfileLite(UserProfile fullModel)
        {
            UserAccountId = fullModel.UserAccountId;
            FirstName = fullModel.FirstName;
            MiddleNames = fullModel.MiddleNames;
            LastName = fullModel.LastName;
            DateOfBirth = fullModel.DateOfBirth;
            Gender = fullModel.Gender;
            Introduction = fullModel.Introduction;
            ProfilePicture = new ImageLite(fullModel.ProfilePicture);
            CoverPicture = new ImageLite(fullModel.CoverPicture);
        }

        public Guid UserAccountId { get; set; }

        public string FirstName { get; set; }

        public string MiddleNames { get; set; }

        public string LastName { get; set; }

        public string FullName => (FirstName + " " + LastName).Trim();

        [JsonDateTimeFormat("dd-MM-yyyy")]
        public DateTimeOffset DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string Introduction { get; set; }

        public ImageLite? ProfilePicture { get; set; }

        public ImageLite? CoverPicture { get; set; }
    }
}