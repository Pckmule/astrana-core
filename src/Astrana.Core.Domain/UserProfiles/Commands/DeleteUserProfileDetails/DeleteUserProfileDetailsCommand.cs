/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.UserProfiles;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Models.UserProfiles.Constants;
using Astrana.Core.Extensions;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.UserProfiles.Commands.DeleteUserProfileDetails
{
    public class DeleteUserProfileDetailsCommand : IDeleteUserProfileDetailsCommand
    {
        private readonly ILogger<DeleteUserProfileDetailsCommand> _logger;
        private readonly IUserProfileRepository<Guid> _userProfileRepository;

        public DeleteUserProfileDetailsCommand(ILogger<DeleteUserProfileDetailsCommand> logger, IUserProfileRepository<Guid> userProfileRepository)
        {
            _logger = logger;
            _userProfileRepository = userProfileRepository;
        }

        public async Task<DeleteResult<List<Guid>>> ExecuteAsync(IList<Guid> userProfileDetailsToDeleteIds, Guid actioningUserId)
        {
            if (!userProfileDetailsToDeleteIds.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Remove, ModelProperties.UserProfileDetail.NamePluralForm);

                _logger.LogWarning(message);

                return new DeleteFailResult<List<Guid>>(new List<Guid>(), 0, message);
            }

            var validatedUserProfileDetailsToRemoveIds = userProfileDetailsToDeleteIds.Where(o => o.IsValidForUpdateOrDelete()).ToList();
            if (!validatedUserProfileDetailsToRemoveIds.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Remove, ModelProperties.UserProfileDetail.NamePluralForm);

                _logger.LogWarning(message);

                return new DeleteFailResult<List<Guid>>(new List<Guid>(), 0, message);
            }

            var result = await _userProfileRepository.DeleteAsync(validatedUserProfileDetailsToRemoveIds, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new DeleteSuccessResult<List<Guid>>(result.Data, result.Count, MRB.DeleteSuccessResultMessage(ModelProperties.UserProfileDetail.NameSingularForm, ModelProperties.UserProfileDetail.NamePluralForm, result.Count));
            
            return new DeleteFailResult<List<Guid>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}