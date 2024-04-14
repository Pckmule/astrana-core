/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.UserProfiles;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.User;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Models.UserProfiles;
using Astrana.Core.Domain.Models.UserProfiles.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.UserProfiles.Commands.UpdateUserProfileIntroduction
{
    public class UpdateUserProfileIntroductionCommand : IUpdateUserProfileIntroductionCommand
    {
        private readonly ILogger<UpdateUserProfileIntroductionCommand> _logger;

        private readonly IUserManager _userManager;
        private readonly IUserProfileRepository<Guid> _userProfileRepository;

        public UpdateUserProfileIntroductionCommand(ILogger<UpdateUserProfileIntroductionCommand> logger, IUserManager userManager, IUserProfileRepository<Guid> userProfileRepository)
        {
            _logger = logger;

            _userManager = userManager;
            _userProfileRepository = userProfileRepository;
        }

        public async Task<UpdateResult<UserProfile>> ExecuteAsync(Guid actioningUserId, string updatedIntroduction)
        {
            if (string.IsNullOrWhiteSpace(updatedIntroduction))
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Update, ModelProperties.UserProfileDetail.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<UserProfile>(null, 0, message);
            }

            var instanceUser = await _userManager.GetInstanceUserAsync();

            if (instanceUser == null)
                throw new Exception("Instance User Not Found");

            var result = await _userProfileRepository.UpdateProfileIntroductionAsync(instanceUser.ProfileId, updatedIntroduction, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new UpdateSuccessResult<UserProfile>(result.Data, result.Count, MRB.UpdateSuccessResultMessage(ModelProperties.UserProfileDetail.NameSingularForm, ModelProperties.UserProfileDetail.NamePluralForm, result.Count));
            
            return new UpdateFailResult<UserProfile>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}