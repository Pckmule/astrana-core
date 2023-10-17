/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Links;
using Astrana.Core.Domain.Images.Commands.SaveRemoteImage;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Links;
using Astrana.Core.Domain.Models.Links.Constants;
using Astrana.Core.Domain.Models.Links.Contracts;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Links.Commands.CreateLinks
{
    public class CreateLinksCommand : ICreateLinksCommand
    {
        private readonly ILogger<CreateLinksCommand> _logger;

        private readonly ILinkRepository<Guid> _linkRepository;
        private readonly ISaveRemoteImageCommand _saveRemoteImageCommand;

        public CreateLinksCommand(ILogger<CreateLinksCommand> logger, ILinkRepository<Guid> linkRepository, ISaveRemoteImageCommand saveRemoteImageCommand)
        {
            _logger = logger;

            _linkRepository = linkRepository;
            _saveRemoteImageCommand = saveRemoteImageCommand;
        }

        public async Task<AddResult<List<Link>>> ExecuteAsync(IList<Link> linksToAdd, Guid actioningUserId)
        {
            if (!linksToAdd.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Add, ModelProperties.Link.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<Link>>(new List<Link>(), 0, message);
            }

            var validatedLinksToAdd = linksToAdd.Where(o => o.IsValid).ToList();
            if (!validatedLinksToAdd.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, ModelProperties.Link.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<Link>>(new List<Link>(), 0, message);
            }

            var updatedValidatedLinksToAdd = new List<Link>();
            foreach (var validatedLinkToAdd in validatedLinksToAdd)
            {
                if(validatedLinkToAdd.PreviewImage != null)
                {
                    var linkImage = (await CreateLinkPreviewImageAsync(validatedLinkToAdd, actioningUserId)).Data.FirstOrDefault();

                    // validatedLinkToAdd.PreviewImageId = linkImage?.Id;
                    validatedLinkToAdd.PreviewImage = linkImage;
                }

                updatedValidatedLinksToAdd.Add(validatedLinkToAdd);
            }
            
            validatedLinksToAdd = updatedValidatedLinksToAdd;

            var result = await _linkRepository.CreateAsync(validatedLinksToAdd, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new AddSuccessResult<List<Link>>(result.Data, result.Count, MRB.CreateSuccessResultMessage(ModelProperties.Link.NameSingularForm, ModelProperties.Link.NamePluralForm, result.Count));
            
            return new AddFailResult<List<Link>>(result.Data, result.Count, result.Message, result.ResultCode);
        }

        private async Task<AddResult<List<Image>>> CreateLinkPreviewImageAsync(Link linkToAdd, Guid actioningUserId)
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
