/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using ApiAccessTokenDataEntity = Astrana.Core.Data.Entities.AccessManagement.ApiAccessToken;
using ApiAccessTokenDomainEntity = Astrana.Core.Domain.Models.ApiAccessTokens.ApiAccessToken;

namespace Astrana.Core.Data.Entities.AccessManagement.ModelMappings
{
    public static class ApiAccessToken
    {
        public static ApiAccessTokenDomainEntity MapToDomainModel(ApiAccessTokenDataEntity apiAccessTokenDataEntity)
        {
            var domainModel = new ApiAccessTokenDomainEntity
            {
                ApiAccessTokenId = apiAccessTokenDataEntity.ApiAccessTokenId,

                Token = apiAccessTokenDataEntity.Token,

                DeactivatedReason = apiAccessTokenDataEntity.DeactivatedReason,
                DeactivatedBy = apiAccessTokenDataEntity.DeactivatedBy,
                DeactivatedTimestamp = apiAccessTokenDataEntity.DeactivatedTimestamp,

                CreatedBy = apiAccessTokenDataEntity.CreatedBy,
                CreatedTimestamp = apiAccessTokenDataEntity.CreatedTimestamp,

                LastModifiedBy = apiAccessTokenDataEntity.LastModifiedBy,
                LastModifiedTimestamp = apiAccessTokenDataEntity.LastModifiedTimestamp
            };

            return domainModel;
        }
    }
}
