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

namespace Astrana.Core.Domain.UserProfiles.Commands.CreateUserProfileDetails
{
    public class CreateUserProfileDetailsCommand : ICreateUserProfileDetailsCommand
    {
        private readonly ILogger<CreateUserProfileDetailsCommand> _logger;

        private readonly IUserProfileRepository<Guid> _userProfileRepository;

        public CreateUserProfileDetailsCommand(ILogger<CreateUserProfileDetailsCommand> logger, IUserProfileRepository<Guid> userProfileRepository)
        {
            _logger = logger;

            _userProfileRepository = userProfileRepository;
        }

        public async Task<AddResult<List<UserProfileDetail>>> ExecuteAsync(IList<UserProfileDetailToAdd> userProfileDetailsToAdd, Guid actioningUserId)
        {
            if (!userProfileDetailsToAdd.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Add, ModelProperties.UserProfileDetail.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<UserProfileDetail>>(new List<UserProfileDetail>(), 0, message);
            }

            var validatedUserProfileDetailsToAdd = userProfileDetailsToAdd.Where(o => o.IsValid).ToList();
            if (!validatedUserProfileDetailsToAdd.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, ModelProperties.UserProfileDetail.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<UserProfileDetail>>(new List<UserProfileDetail>(), 0, message);
            }
            
            var result = await _userProfileRepository.CreateProfileDetailsAsync(validatedUserProfileDetailsToAdd, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new AddSuccessResult<List<UserProfileDetail>>(result.Data, result.Count, MRB.CreateSuccessResultMessage(ModelProperties.UserProfileDetail.NameSingularForm, ModelProperties.UserProfileDetail.NamePluralForm, result.Count));
            
            return new AddFailResult<List<UserProfileDetail>>(result.Data, result.Count, result.Message, result.ResultCode);
        }
    }
}
