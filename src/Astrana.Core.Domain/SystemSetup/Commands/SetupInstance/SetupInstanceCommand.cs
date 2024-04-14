/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Configuration;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.SystemSetup;
using Astrana.Core.Domain.SystemSetup.Commands.SetupInstanceUser;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.SystemSetup.Commands.SetupInstance
{
    public class SetupInstanceCommand : ISetupInstanceCommand
    {
        private readonly ILogger<SetupInstanceCommand> _logger;
        private readonly IHostEnvironment _environment;
        private readonly IDataProtectionEncryptionUtility _dataProtectionEncryptionUtility;
        private readonly ISetupInstanceUserCommand _setupInstanceUserCommand;

        public SetupInstanceCommand(ILogger<SetupInstanceCommand> logger, IHostEnvironment environment, IDataProtectionEncryptionUtility dataProtectionEncryptionUtility, ISetupInstanceUserCommand setupInstanceUserCommand)
        {
            _logger = logger;
            _environment = environment;
            _dataProtectionEncryptionUtility = dataProtectionEncryptionUtility;
            _setupInstanceUserCommand = setupInstanceUserCommand;
        }

        public async Task<ExecutionResult> ExecuteAsync(InstanceSetupRequest? instanceSetupRequest, Guid actioningUserId)
        {
            if (instanceSetupRequest == null)
            {
                const string? message = "No data provided.";

                _logger.LogWarning(message);

                return new ExecutionFailResult(message);
            }
            
            var createUserResult = await _setupInstanceUserCommand.ExecuteAsync(instanceSetupRequest, actioningUserId);

            if (createUserResult.Outcome == ResultOutcome.Failure)
                return new ExecutionFailResult(createUserResult.Message);

            // EncryptionUtility.StoreEncryptionKey();
            // EncryptionUtility.StoreInitializationVector();

            var isConfigurationSecured = await new ConfigurationManager(Path.Combine(new[] { _environment.ContentRootPath, Constants.Application.SettingsFileName }), _dataProtectionEncryptionUtility).SecureAfterSetupAsync();

            if (!isConfigurationSecured)
            {
                return new ExecutionFailResult("Instance setup. Could not secure the Application Settings file.");
            }

            return new ExecutionSuccessResult("Instance successfully setup.");
        }
    }
}
