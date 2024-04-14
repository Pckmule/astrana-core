/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.UserAccounts;
using Astrana.Core.Data.Repositories.UserProfiles;
using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Models.IdentityAccessManagement.Constants;
using Astrana.Core.Domain.Models.IdentityAccessManagement.Models;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.UserAccounts;
using Astrana.Core.Domain.Models.UserAccounts.Enums;
using Astrana.Core.Domain.Models.UserAccounts.Options;
using Astrana.Core.Domain.Models.UserProfiles;
using Astrana.Core.Domain.UserAccounts.Commands.CreateUserAccounts;
using Astrana.Core.Domain.UserProfiles.Commands.CreateUserProfiles;
using Astrana.Core.Extensions;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.IdentityAccessManagement.Managers.User
{
    public class UserManager : IUserManager
    {
        private readonly ILogger<ISignInManager> _logger;

        private readonly IUserAccountRepository<Guid> _userAccountRepository;
        private readonly IUserProfileRepository<Guid> _userProfileRepository;

        private readonly ICreateUserAccountCommand _createUserAccountCommand;
        private readonly ICreateUserProfileCommand _createUserProfileCommand;

        public UserManager(ILogger<ISignInManager> logger, 
            IUserAccountRepository<Guid> userAccountRepository, 
            IUserProfileRepository<Guid> userProfileRepository, 
            ICreateUserAccountCommand createUserAccountCommand, 
            ICreateUserProfileCommand createUserProfileCommand)
        {
            _logger = logger;

            _userAccountRepository = userAccountRepository;
            _userProfileRepository = userProfileRepository;

            _createUserAccountCommand = createUserAccountCommand;
            _createUserProfileCommand = createUserProfileCommand;
        }

        public async Task<ApplicationUser?> GetInstanceUserAsync()
        {
            var userAccount = await _userAccountRepository.GetInstanceUserAccountAsync();

            if (userAccount == null)
                return null;

            var userProfile = await _userProfileRepository.GetUserProfileByUserAccountIdAsync(userAccount.UserAccountId);

            if (userProfile == null)
                return null;

            return new ApplicationUser(userAccount, userProfile);
        }

        public async Task<ApplicationUser?> FindUserByCredentialsAsync(string username, string plainTextPassword, Guid actioningUserId)
        {
            var userAccount = await _userAccountRepository.GetUserAccountByCredentialsAsync(username, plainTextPassword);

            if (userAccount == null)
                return null;

            var userProfile = await _userProfileRepository.GetUserProfileByUserAccountIdAsync(userAccount.UserAccountId);

            if (userProfile == null)
                return null;

            return new ApplicationUser(userAccount, userProfile);
        }

        public async Task<ApplicationUser?> FindUserAsync(UserAccountQueryOptions<Guid, Guid> queryOptions, Guid actioningUserId)
        {
            var userAccount = (await _userAccountRepository.GetUserAccountsAsync(queryOptions)).Data.FirstOrDefault();

            if (userAccount == null)
                return null;

            var userProfile = await _userProfileRepository.GetUserProfileByUserAccountIdAsync(userAccount.UserAccountId);

            if (userProfile == null)
                return null;

            return new ApplicationUser(userAccount, userProfile);
        }

        public async Task<ApplicationUser?> FindUserByIdAsync(Guid userId, Guid actioningUserId)
        {
            return await FindUserAsync(new UserAccountQueryOptions<Guid, Guid>(userId.AsList()), actioningUserId);
        }

        public async Task<ApplicationUser?> FindUserByUsernameAsync(string username, Guid actioningUserId)
        {
            return await FindUserAsync(new UserAccountQueryOptions<Guid, Guid> { Usernames = new List<string> { username } }, actioningUserId);
        }

        public async Task<AddResult<ApplicationUser>> CreateUserAsync(ApplicationUserToAdd userToAdd, Guid actioningUserId)
        {
            if (userToAdd == null)
                throw new ArgumentNullException(nameof(userToAdd));

            var userAccountToAdd = new UserAccountToAdd
            {
                Type = UserAccountType.Instance,

                UserName = userToAdd.UserName,
                Password = userToAdd.Password,

                EmailAddress = userToAdd.EmailAddress,
                PhoneCountryCodeISO = userToAdd.PhoneCountryCodeISO,
                PhoneNumber = userToAdd.PhoneNumber,

                LanguageCode = userToAdd.LanguageCode,
                CountryCode = userToAdd.CountryCode,
                TimeZone = userToAdd.TimeZone
            };

            var userAccountResult = await _createUserAccountCommand.ExecuteAsync(userAccountToAdd, actioningUserId);

            if (userAccountResult.Outcome != ResultOutcome.Success)
                return new AddFailResult<ApplicationUser>(null, 0, userAccountResult.Message, "")
                {
                    Errors = userAccountResult.Errors
                };

            var userProfileToAdd = new UserProfileToAdd
            {
                UserAccountId = userAccountResult.Data.UserAccountId,

                FirstName = userToAdd.FirstName,
                MiddleNames = userToAdd.MiddleNames,
                LastName = userToAdd.LastName,

                DateOfBirth = userToAdd.DateOfBirth,
                Sex = userToAdd.Sex
            };

            var userProfileResult = await _createUserProfileCommand.ExecuteAsync(userProfileToAdd, actioningUserId);

            if (userAccountResult.Outcome != ResultOutcome.Success)
                return new AddFailResult<ApplicationUser>(null, 0, userProfileResult.Message, "");

            var userAccount = userAccountResult.Data;
            var userProfile = userProfileResult.Data;

            return new AddSuccessResult<ApplicationUser>(new ApplicationUser(userAccount, userProfile), 1, MRB.CreateSuccessResultMessage(ModelProperties.ApplicationUser.NameSingularForm, ModelProperties.ApplicationUser.NamePluralForm));
        }

        public async Task<ExecutionResult<string>> SetPasswordResetTokenAsync(Guid userId, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public async Task<ExecutionResult<string>> SetPasswordResetTokenAsync(string username, Guid actioningUserId)
        {
            var userId = (await FindUserByUsernameAsync(username, actioningUserId)).Id;

            if (userId.IsNotEmpty())
                throw new ApplicationUserNotFoundException();

            return await SetPasswordResetTokenAsync(userId, actioningUserId);
        }

        public async Task<ExecutionResult> InitiatePasswordResetAsync(InitiateResetPasswordRequestDto resetPasswordRequestDto, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public async Task<UpdateResult<ApplicationUser>> SetPasswordAsync(Guid userId, string password, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public async Task<UpdateResult<ApplicationUser>> SetPasswordAsync(string username, string password, Guid actioningUserId)
        {
            var userId = (await FindUserByUsernameAsync(username, actioningUserId)).Id;

            if (userId.IsNotEmpty())
                throw new ApplicationUserNotFoundException();

            return await SetPasswordAsync(userId, password, actioningUserId);
        }

        public Task<UpdateResult<ApplicationUser>> ResetPasswordAsync(string validationToken, string password, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<AddResult<ApplicationUser>> UpdateUserAsync(UserAccount userAccount, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}