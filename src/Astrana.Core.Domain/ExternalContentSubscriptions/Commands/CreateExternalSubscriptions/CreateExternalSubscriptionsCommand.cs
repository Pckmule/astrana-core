/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.ExternalContentSubscriptions;
using Astrana.Core.Domain.Images.Commands.SaveRemoteImage;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions.Constants;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions.Contracts;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.ExternalContentSubscriptions.Commands.CreateExternalSubscriptions
{
    public class CreateExternalSubscriptionsCommand : ICreateExternalSubscriptionsCommand
    {
        private readonly ILogger<CreateExternalSubscriptionsCommand> _logger;

        private readonly IExternalContentSubscriptionRepository<Guid> _linkRepository;
        private readonly ISaveRemoteImageCommand _saveRemoteImageCommand;

        public CreateExternalSubscriptionsCommand(ILogger<CreateExternalSubscriptionsCommand> logger, IExternalContentSubscriptionRepository<Guid> linkRepository, ISaveRemoteImageCommand saveRemoteImageCommand)
        {
            _logger = logger;

            _linkRepository = linkRepository;
            _saveRemoteImageCommand = saveRemoteImageCommand;
        }

        public async Task<AddResult<List<ExternalSubscription>>> ExecuteAsync(IList<ExternalSubscriptionToAdd> linksToAdd, Guid actioningUserId)
        {
            if (!linksToAdd.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Add, ModelProperties.ExternalContentSubscription.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<ExternalSubscription>>(new List<ExternalSubscription>(), 0, message);
            }

            var validatedExternalContentSubscriptionsToAdd = linksToAdd.Where(o => o.IsValid).ToList();
            if (!validatedExternalContentSubscriptionsToAdd.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, ModelProperties.ExternalContentSubscription.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<ExternalSubscription>>(new List<ExternalSubscription>(), 0, message);
            }

            var updatedValidatedExternalContentSubscriptionsToAdd = new List<ExternalSubscriptionToAdd>();
            foreach (var validatedExternalContentSubscriptionToAdd in validatedExternalContentSubscriptionsToAdd.Where(validatedExternalContentSubscriptionToAdd => validatedExternalContentSubscriptionToAdd.PreviewImage != null))
            {
                var linkImage = (await CreateExternalContentSubscriptionPreviewImageAsync(validatedExternalContentSubscriptionToAdd, actioningUserId)).Data.FirstOrDefault();

                validatedExternalContentSubscriptionToAdd.PreviewImageId = linkImage?.ImageId;
                validatedExternalContentSubscriptionToAdd.PreviewImage = null;

                updatedValidatedExternalContentSubscriptionsToAdd.Add(validatedExternalContentSubscriptionToAdd);
            }

            validatedExternalContentSubscriptionsToAdd = updatedValidatedExternalContentSubscriptionsToAdd;

            var result = await _linkRepository.CreateAsync(validatedExternalContentSubscriptionsToAdd, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new AddSuccessResult<List<ExternalSubscription>>(result.Data, result.Count, MRB.CreateSuccessResultMessage(ModelProperties.ExternalContentSubscription.NameSingularForm, ModelProperties.ExternalContentSubscription.NamePluralForm, result.Count));
            
            return new AddFailResult<List<ExternalSubscription>>(result.Data, result.Count, result.Message, result.ResultCode);
        }

        private async Task<AddResult<List<Image>>> CreateExternalContentSubscriptionPreviewImageAsync(IExternalSubscriptionToAdd linkToAdd, Guid actioningUserId)
        {
            if (string.IsNullOrWhiteSpace(linkToAdd.PreviewImage?.Location))
                return new AddFailResult<List<Image>>(null, 0, "No image location was specified.");

            var createImageResult = await _saveRemoteImageCommand.ExecuteAsync(new Uri(linkToAdd.PreviewImage.Location), actioningUserId);
        
            if (createImageResult.Outcome == ResultOutcome.Success)
                return new AddSuccessResult<List<Image>>(createImageResult.Data, createImageResult.Count, MRB.CreateSuccessResultMessage(Models.Images.Constants.ModelProperties.Image.NameSingularForm, Models.Images.Constants.ModelProperties.Image.NamePluralForm));

            return new AddFailResult<List<Image>>(null);
        }
    }
}
