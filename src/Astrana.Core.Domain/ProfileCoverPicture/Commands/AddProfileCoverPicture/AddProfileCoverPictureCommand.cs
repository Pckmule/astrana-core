/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.UserProfiles;
using Astrana.Core.Domain.Images.Commands.UploadImage;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Images.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.ProfileCoverPicture.Commands.AddProfileCoverPicture
{
    public class AddProfileCoverPictureCommand : IAddProfileCoverPictureCommand
    {
        private readonly ILogger<AddProfileCoverPictureCommand> _logger;

        private readonly IUploadImageCommand _uploadImageCommand;
        private readonly IUserProfileRepository<Guid> _userProfileRepository;

        public AddProfileCoverPictureCommand(ILogger<AddProfileCoverPictureCommand> logger, IUploadImageCommand uploadImageCommand, IUserProfileRepository<Guid> userProfileRepository)
        {
            _logger = logger;

            _uploadImageCommand = uploadImageCommand;
            _userProfileRepository = userProfileRepository;
        }

        public async Task<AddResult<Image>> ExecuteAsync(Guid profileId, IFormFile imageFile, Guid actioningUserId)
        {
            var uploadResult = await _uploadImageCommand.ExecuteAsync(new List<IFormFile> { imageFile }, actioningUserId);

            if (uploadResult.Outcome != ResultOutcome.Success)
                return new AddFailResult<Image>(null, 0, uploadResult.Message);
            
            var result = await _userProfileRepository.UpdateCoverPictureAsync(profileId, uploadResult.Data.First().ImageId, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new AddSuccessResult<Image>(uploadResult.Data.First(), result.Count, MRB.CreateSuccessResultMessage(ModelProperties.Image.NameSingularForm, ModelProperties.Image.NamePluralForm, result.Count));
            
            return new AddFailResult<Image>(null, result.Count, result.Message, result.ResultCode);
        }
    }
}
