/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.ExternalContentSubscriptions;
using Astrana.Core.Domain.ExternalFeeds.Queries;
using Astrana.Core.Domain.Images.Commands.SaveRemoteImage;
using Astrana.Core.Domain.Models.AstranaApi.Contracts;
using Astrana.Core.Domain.Models.ExternalContent.Subscriptions;
using Astrana.Core.Domain.Models.ExternalContent.Subscriptions.Constants;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Images.DomainTransferObjects;
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

        private readonly IExternalContentSubscriptionRepository<Guid> _externalContentSubscriptionRepository;
        private readonly ISaveRemoteImageCommand _saveRemoteImageCommand;
        private readonly IGetExternalFeedSummaryQuery _getExternalFeedSummaryQuery;
        private readonly IAstranaApiInfo _astranaApiInfo;

        public CreateExternalSubscriptionsCommand(
            ILogger<CreateExternalSubscriptionsCommand> logger, 
            IExternalContentSubscriptionRepository<Guid> externalContentSubscriptionRepository, 
            ISaveRemoteImageCommand saveRemoteImageCommand, 
            IGetExternalFeedSummaryQuery getExternalFeedSummaryQuery,
            IAstranaApiInfo astranaApiInfo)
        {
            _logger = logger;

            _externalContentSubscriptionRepository = externalContentSubscriptionRepository;
            _saveRemoteImageCommand = saveRemoteImageCommand;
            _getExternalFeedSummaryQuery = getExternalFeedSummaryQuery;
            _astranaApiInfo = astranaApiInfo;
        }

        public async Task<AddResult<List<ExternalContentSubscription>>> ExecuteAsync(IList<ExternalContentSubscriptionToAdd> externalContentSubscriptionsToAdd, Guid actioningUserId)
        {
            if (!externalContentSubscriptionsToAdd.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Add, ModelProperties.ExternalContentSubscription.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<ExternalContentSubscription>>(new List<ExternalContentSubscription>(), 0, message);
            }

            var validatedExternalContentSubscriptionsToAdd = externalContentSubscriptionsToAdd.Where(o => o.IsValid).ToList();
            if (!validatedExternalContentSubscriptionsToAdd.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, ModelProperties.ExternalContentSubscription.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<ExternalContentSubscription>>(new List<ExternalContentSubscription>(), 0, message);
            }

            var updatedValidatedExternalContentSubscriptionsToAdd = new List<ExternalContentSubscription>();
            foreach (var validatedExternalContentSubscriptionToAdd in validatedExternalContentSubscriptionsToAdd)
            {
                var externalFeedSummary = await _getExternalFeedSummaryQuery.ExecuteAsync(validatedExternalContentSubscriptionToAdd.Url, actioningUserId);

                var hasIconImage = !string.IsNullOrWhiteSpace(externalFeedSummary.Data.IconImage?.Location);
                var hasLogoImage = !string.IsNullOrWhiteSpace(externalFeedSummary.Data.LogoImage?.Location);
                var hasCoverImage = !string.IsNullOrWhiteSpace(externalFeedSummary.Data.CoverImage?.Location);

                var externalContentSubscription = new ExternalContentSubscription
                {
                    Url = validatedExternalContentSubscriptionToAdd.Url,

                    Title = externalFeedSummary.Data.Title,
                    SubTitle = externalFeedSummary.Data.SubTitle,
                    
                    Description = externalFeedSummary.Data.Summary,
                    
                    Locale = externalFeedSummary.Data.Locale,
                    Language = externalFeedSummary.Data.Language,
                    CharSet = externalFeedSummary.Data.CharSet,

                    WebsiteUrl = externalFeedSummary.Data.WebsiteUrl,

                    Copyright = externalFeedSummary.Data.Copyright,

                    IconImage = hasIconImage ? new Image(new ImageToAddDto
                    {
                        Location = externalFeedSummary.Data.IconImage?.Location,
                        Caption = "Feed Icon"

                    }) : null,

                    LogoImage = hasLogoImage ? new Image(new ImageToAddDto
                    {
                        Location = externalFeedSummary.Data.LogoImage?.Location,
                        Caption = "Feed Logo"

                    }) : null,

                    CoverImage = hasCoverImage ? new Image(new ImageToAddDto
                    {
                        Location = externalFeedSummary.Data.CoverImage?.Location,
                        Caption = "Feed Cover Image"

                    }) : null
                };

                if (externalContentSubscription.IconImage != null)
                {
                    var image = (await CreateImageAsync(externalContentSubscription.IconImage?.Location, actioningUserId)).Data.FirstOrDefault();

                    externalContentSubscription.IconImage = image;
                }

                if (externalContentSubscription.LogoImage != null)
                {
                    var image = (await CreateImageAsync(externalContentSubscription.LogoImage?.Location, actioningUserId)).Data.FirstOrDefault();

                    externalContentSubscription.LogoImage = image;
                }

                if (externalContentSubscription.CoverImage != null)
                {
                    var image = (await CreateImageAsync(externalContentSubscription.CoverImage?.Location, actioningUserId)).Data.FirstOrDefault();

                    externalContentSubscription.CoverImage = image;
                }

                updatedValidatedExternalContentSubscriptionsToAdd.Add(externalContentSubscription);
            }
            
            var saveResult = await _externalContentSubscriptionRepository.CreateAsync(updatedValidatedExternalContentSubscriptionsToAdd, actioningUserId);

            if (saveResult.Outcome == ResultOutcome.Success)
            {
                foreach (var subscription in saveResult.Data)
                {
                    if (subscription.IconImage?.Location != null && subscription.IconImage.Location.StartsWith('/'))
                    {
                        subscription.IconImage.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, subscription.IconImage.Location);
                    }

                    if (subscription.LogoImage?.Location != null && subscription.LogoImage.Location.StartsWith('/'))
                    {
                        subscription.LogoImage.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, subscription.LogoImage.Location);
                    }

                    if (subscription.CoverImage?.Location != null && subscription.CoverImage.Location.StartsWith('/'))
                    {
                        subscription.CoverImage.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, subscription.CoverImage.Location);
                    }
                }

                return new AddSuccessResult<List<ExternalContentSubscription>>(saveResult.Data, saveResult.Count, MRB.CreateSuccessResultMessage(ModelProperties.ExternalContentSubscription.NameSingularForm, ModelProperties.ExternalContentSubscription.NamePluralForm, saveResult.Count));
            }
            if (saveResult.Outcome == ResultOutcome.Aborted)
            {
                var result = new AddAbortResult<List<ExternalContentSubscription>>(saveResult.Data, saveResult.Count, saveResult.Message);

                result.Errors.AddRange(saveResult.Errors);

                return result;
            }

            return new AddFailResult<List<ExternalContentSubscription>>(saveResult.Data, saveResult.Count, saveResult.Message, saveResult.ResultCode);
        }

        private async Task<AddResult<List<Image>>> CreateImageAsync(string imageUrl, Guid actioningUserId)
        {
            if (string.IsNullOrWhiteSpace(imageUrl))
                return new AddFailResult<List<Image>>(null, 0, "No image location was specified.");

            var createImageResult = await _saveRemoteImageCommand.ExecuteAsync(new Uri(imageUrl), actioningUserId);
        
            if (createImageResult.Outcome == ResultOutcome.Success)
                return new AddSuccessResult<List<Image>>(createImageResult.Data, createImageResult.Count, MRB.CreateSuccessResultMessage(Models.Images.Constants.ModelProperties.Image.NameSingularForm, Models.Images.Constants.ModelProperties.Image.NamePluralForm));

            return new AddFailResult<List<Image>>(null);
        }
    }
}
