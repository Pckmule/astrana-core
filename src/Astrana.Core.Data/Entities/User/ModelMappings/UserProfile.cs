using UserProfileDataEntity = Astrana.Core.Data.Entities.User.UserProfile;
using UserProfileDomainEntity = Astrana.Core.Domain.Models.UserProfiles.UserProfile;

namespace Astrana.Core.Data.Entities.User.ModelMappings
{
    public static class UserProfile
    {
        public static UserProfileDomainEntity? MapToDomainModel(UserProfileDataEntity? userProfileDataEntity)
        {
            if (userProfileDataEntity == null)
                return null;

            var domainModel = new UserProfileDomainEntity
            {
                ProfileId = userProfileDataEntity.Id,

                FirstName = userProfileDataEntity.FirstName,
                MiddleNames = userProfileDataEntity.MiddleNames,
                LastName = userProfileDataEntity.LastName,

                DateOfBirth = userProfileDataEntity.DateOfBirth,
                Sex = userProfileDataEntity.Sex,
                Introduction = userProfileDataEntity.Introduction,

                ProfilePicturesCollection = Content.ModelMappings.ContentCollection.MapToDomainModel(userProfileDataEntity.ProfilePicturesCollection),
                CoverPicturesCollection = Content.ModelMappings.ContentCollection.MapToDomainModel(userProfileDataEntity.CoverPicturesCollection),

                CreatedBy = userProfileDataEntity.CreatedBy,
                CreatedTimestamp = userProfileDataEntity.CreatedTimestamp,

                LastModifiedBy = userProfileDataEntity.LastModifiedBy,
                LastModifiedTimestamp = userProfileDataEntity.LastModifiedTimestamp
            };

            return domainModel;
        }
    }
}
