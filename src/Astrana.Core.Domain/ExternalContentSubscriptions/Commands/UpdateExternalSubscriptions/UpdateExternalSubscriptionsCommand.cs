/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.ExternalContentSubscriptions;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.ExternalContentSubscriptions.Commands.UpdateExternalSubscriptions
{
    public class UpdateExternalSubscriptionsCommand : IUpdateExternalSubscriptionsCommand
    {
        private readonly ILogger<UpdateExternalSubscriptionsCommand> _logger;
        private readonly IExternalContentSubscriptionRepository<Guid> _externalContentSubscriptionRepository;

        public UpdateExternalSubscriptionsCommand(ILogger<UpdateExternalSubscriptionsCommand> logger, IExternalContentSubscriptionRepository<Guid> externalContentSubscriptionRepository)
        {
            _logger = logger;
            _externalContentSubscriptionRepository = externalContentSubscriptionRepository;
        }

        public async Task<UpdateResult<List<ExternalSubscription>>> ExecuteAsync(IList<ExternalSubscription> externalContentSubscriptionsToUpdate, Guid actioningUserId)
        {
            if (!externalContentSubscriptionsToUpdate.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Update, ModelProperties.ExternalContentSubscription.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<ExternalSubscription>>(new List<ExternalSubscription>(), 0, message);
            }

            var validatedExternalContentSubscriptionsToUpdate = externalContentSubscriptionsToUpdate.Where(o => o.IsValid).ToList();
            if (!validatedExternalContentSubscriptionsToUpdate.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Update, ModelProperties.ExternalContentSubscription.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<ExternalSubscription>>(new List<ExternalSubscription>(), 0, message);
            }

            var result = await _externalContentSubscriptionRepository.UpdateAsync(validatedExternalContentSubscriptionsToUpdate, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new UpdateSuccessResult<List<ExternalSubscription>>(result.Data, result.Count, MRB.UpdateSuccessResultMessage(ModelProperties.ExternalContentSubscription.NameSingularForm, ModelProperties.ExternalContentSubscription.NamePluralForm, result.Count));
            
            return new UpdateFailResult<List<ExternalSubscription>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}