/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.UserAccounts;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Models.UserAccounts;
using Astrana.Core.Domain.Models.UserAccounts.Constants;
using Astrana.Core.Domain.Models.UserAccounts.Contracts;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.UserAccounts.Commands.CreateUserAccounts
{
    public class CreateUserAccountCommand : ICreateUserAccountCommand
    {
        private readonly ILogger<CreateUserAccountCommand> _logger;
        private readonly IUserAccountRepository<Guid> _userAccountRepository;

        public CreateUserAccountCommand(ILogger<CreateUserAccountCommand> logger, IUserAccountRepository<Guid> userAccountRepository)
        {
            _logger = logger;
            _userAccountRepository = userAccountRepository;
        }

        public async Task<AddResult<UserAccount>> ExecuteAsync(UserAccountToAdd userAccountToAdd, Guid actioningUserId)
        {
            if (!userAccountToAdd.IsValid)
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, ModelProperties.UserAccount.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<UserAccount>(null, 0, message);
            }

            var result = await _userAccountRepository.CreateAsync(new List<IUserAccountToAdd> { userAccountToAdd }, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new AddSuccessResult<UserAccount>(result.Data.FirstOrDefault(), result.Count, MRB.CreateSuccessResultMessage(ModelProperties.UserAccount.NameSingularForm, ModelProperties.UserAccount.NamePluralForm, result.Count));
            
            return new AddFailResult<UserAccount>(result.Data.FirstOrDefault(), result.Count, result.Message, result.ResultCode)
            {
                Errors = result.Errors
            };
        }
    }
}
