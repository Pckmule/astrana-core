/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Managers.User;
using Astrana.Core.Domain.Models.IdentityAccessManagement.Models;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Models.SystemSetup;
using Astrana.Core.Domain.Models.UserAccounts.Enums;
using Astrana.Core.Extensions;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Enums;
using Microsoft.Extensions.Logging;
using ApplicationUser = Astrana.Core.Domain.Models.IdentityAccessManagement.Models.ApplicationUser;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.SystemSetup.Commands.SetupInstanceUser
{
    public class SetupInstanceUserCommand : ISetupInstanceUserCommand
    {
        private readonly ILogger<SetupInstanceUserCommand> _logger;
        private readonly IUserManager _userManager;

        public SetupInstanceUserCommand(ILogger<SetupInstanceUserCommand> logger, IUserManager userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<AddResult<ApplicationUser>> ExecuteAsync(InstanceSetupRequest? instanceSetupRequest, Guid actioningUserId)
        {
            if (instanceSetupRequest == null)
            {
                const string? message = "No data provided.";

                _logger.LogWarning(message);

                return new AddFailResult<ApplicationUser>(null, 0, message);
            }

            var prerequisiteValidationResult = await ValidatePrerequisitesAsync(instanceSetupRequest);

            if(!prerequisiteValidationResult.IsSuccess)
                return new AddFailResult<ApplicationUser>(null, 0, prerequisiteValidationResult.Message, Constants.ErrorCodes.PrerequisitesNotSatisfied);

            var instanceUser = new ApplicationUserToAdd
            {
                Type = UserAccountType.Instance,
                
                UserName = instanceSetupRequest.InstanceUsername,
                Password = instanceSetupRequest.InstanceUserPassword,

                EmailAddress = instanceSetupRequest.InstanceUserEmailAddress,
                PhoneCountryCodeISO = instanceSetupRequest.InstancePhoneCountryCodeISO,
                PhoneNumber = instanceSetupRequest.InstancePhoneNumber,
                
                LanguageCode = instanceSetupRequest.InstanceLanguageCode,
                CountryCode = instanceSetupRequest.InstanceCountryCode,
                TimeZone = instanceSetupRequest.InstanceTimeZone,
          
                FirstName = instanceSetupRequest.InstanceUserFirstName,
                MiddleNames = instanceSetupRequest.InstanceUserMiddleNames,
                LastName = instanceSetupRequest.InstanceUserLastName ?? "",
                DateOfBirth = instanceSetupRequest.InstanceUserDateOfBirth,
                Sex = instanceSetupRequest.InstanceUserSex
            };

            var userAccountValidationResult = instanceUser.Validate();
            if (userAccountValidationResult.IsFailed)
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, Models.UserAccounts.Constants.ModelProperties.UserAccount.NameSingularForm);

                _logger.LogWarning(message);

                return new AddFailResult<ApplicationUser>(null, 0, message)
                {
                    Errors = userAccountValidationResult.FailedValidations.Select(o => new ResultError(o.ValidatedEntityName, o.Message)).ToList()
                };
            }

            var createUserResult = await _userManager.CreateUserAsync(instanceUser, actioningUserId.UseSystemUserIdIfUserIsAnonymous());

            if (createUserResult.Outcome == ResultOutcome.Failure)
                return new AddFailResult<ApplicationUser>(null, 0, createUserResult.Message, createUserResult.ResultCode);
            
            return new AddSuccessResult<ApplicationUser>(createUserResult.Data, createUserResult.Count, createUserResult.Message, createUserResult.ResultCode);
        }

        private async Task<ValidationResult> ValidatePrerequisitesAsync(InstanceSetupRequest? instanceSetupRequest)
        {
            var result = new ValidationResult();
            
            if(await _userManager.GetInstanceUserAsync() != null)
                result.FailedValidations.Add(new ValidationResult(null, "Only one instance user may exist.", ValidationOutcome.Failed));
            
            return result;
        }
    }
}
