/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.UserProfiles;
using Astrana.Core.Domain.Models.UserProfiles;
using Astrana.Core.Domain.Models.UserProfiles.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.UserProfiles.Commands.UpdateUserProfileDetails
{
    public class UpdateUserProfileDetailsCommand : IUpdateUserProfileDetailsCommand
    {
        private readonly ILogger<UpdateUserProfileDetailsCommand> _logger;
        private readonly IUserProfileRepository<Guid> _userProfileRepository;

        public UpdateUserProfileDetailsCommand(ILogger<UpdateUserProfileDetailsCommand> logger, IUserProfileRepository<Guid> userProfileRepository)
        {
            _logger = logger;
            _userProfileRepository = userProfileRepository;
        }

        public async Task<UpdateResult<List<UserProfileDetail>>> ExecuteAsync(IList<UserProfileDetail> userProfileDetailsToUpdate, Guid actioningUserId)
        {
            if (!userProfileDetailsToUpdate.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Update, ModelProperties.UserProfileDetail.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<UserProfileDetail>>(new List<UserProfileDetail>(), 0, message);
            }

            var validatedUserProfileDetailsToUpdate = userProfileDetailsToUpdate.Where(o => o.IsValid).ToList();
            if (!validatedUserProfileDetailsToUpdate.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Update, ModelProperties.UserProfileDetail.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<UserProfileDetail>>(new List<UserProfileDetail>(), 0, message);
            }

            var result = await _userProfileRepository.UpdateProfileDetailsAsync(validatedUserProfileDetailsToUpdate, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new UpdateSuccessResult<List<UserProfileDetail>>(result.Data, result.Count, MRB.UpdateSuccessResultMessage(ModelProperties.UserProfileDetail.NameSingularForm, ModelProperties.UserProfileDetail.NamePluralForm, result.Count));
            
            return new UpdateFailResult<List<UserProfileDetail>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}