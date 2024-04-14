/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.IdentityAccessManagement.Models;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.UserAccounts;
using Astrana.Core.Domain.Models.UserAccounts.Options;

namespace Astrana.Core.Domain.IdentityAccessManagement.Managers.User
{
    public interface IUserManager
    {
        Task<ApplicationUser?> GetInstanceUserAsync();

        Task<ApplicationUser?> FindUserAsync(UserAccountQueryOptions<Guid, Guid> queryOptions, Guid actioningUserId);

        Task<ApplicationUser?> FindUserByUsernameAsync(string username, Guid actioningUserId);

        Task<ApplicationUser?> FindUserByCredentialsAsync(string username, string plainTextPassword, Guid actioningUserId);

        Task<ApplicationUser?> FindUserByIdAsync(Guid userId, Guid actioningUserId);

        Task<AddResult<ApplicationUser>> CreateUserAsync(ApplicationUserToAdd userToAdd, Guid actioningUserId);

        Task<AddResult<ApplicationUser>> UpdateUserAsync(UserAccount userAccount, Guid actioningUserId);

        Task<ExecutionResult<string>> SetPasswordResetTokenAsync(string username, Guid actioningUserId);

        Task<ExecutionResult<string>> SetPasswordResetTokenAsync(Guid userId, Guid actioningUserId);

        Task<ExecutionResult> InitiatePasswordResetAsync(InitiateResetPasswordRequestDto resetPasswordRequestDto, Guid actioningUserId);

        Task<UpdateResult<ApplicationUser>> SetPasswordAsync(Guid userId, string password, Guid actioningUserId);

        Task<UpdateResult<ApplicationUser>> SetPasswordAsync(string username, string password, Guid actioningUserId);

        Task<UpdateResult<ApplicationUser>> ResetPasswordAsync(string validationToken, string password, Guid actioningUserId);
    }
}