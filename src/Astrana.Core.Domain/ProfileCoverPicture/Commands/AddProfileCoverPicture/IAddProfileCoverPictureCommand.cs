using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Results;
using Microsoft.AspNetCore.Http;

namespace Astrana.Core.Domain.ProfileCoverPicture.Commands.AddProfileCoverPicture
{
    public interface IAddProfileCoverPictureCommand
    {
        Task<AddResult<Image>> ExecuteAsync(Guid profileId, IFormFile imageFile, Guid actioningUserId);
    }
}
