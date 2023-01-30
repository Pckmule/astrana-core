/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.UserProfiles;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Models.UserProfiles;
using Astrana.Core.Domain.Models.UserProfiles.Constants;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.UserProfiles.Commands.CreateUserProfiles
{
    public class CreateUserProfileCommand : ICreateUserProfileCommand
    {
        private readonly ILogger<CreateUserProfileCommand> _logger;
        private readonly IUserProfileRepository<Guid> _userProfileRepository;

        public CreateUserProfileCommand(ILogger<CreateUserProfileCommand> logger, IUserProfileRepository<Guid> userProfileRepository)
        {
            _logger = logger;
            _userProfileRepository = userProfileRepository;
        }

        public async Task<AddResult<UserProfile>> ExecuteAsync(UserProfileToAdd userProfileToAdd, Guid actioningUserId)
        {
            if (!userProfileToAdd.IsValid)
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, ModelProperties.UserProfile.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<UserProfile>(null, 0, message);
            }

            var result = await _userProfileRepository.CreateAsync(userProfileToAdd, actioningUserId);

            if (result.Outcome != ResultOutcome.Success)
                return new AddFailResult<UserProfile>(null, 0, result.Message, result.ResultCode);

            return new AddSuccessResult<UserProfile>(result.Data, 0, MRB.CreateSuccessResultMessage(ModelProperties.UserProfile.NameSingularForm, ModelProperties.UserProfile.NamePluralForm, result.Count));
        }
    }
}
