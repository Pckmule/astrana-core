using AgeCalculator;
using Astrana.Core.Data.Repositories.SystemSettings;
using Astrana.Core.Data.Repositories.UserProfiles;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.User;
using Astrana.Core.Domain.Models.AstranaApi.Contracts;
using Astrana.Core.Domain.Models.Peers.DomainTransferObjects;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Models.SystemSettings.Options;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;
using SystemSettingDefinitions = Astrana.Core.Domain.Models.System.Constants.SettingDefinitions;

namespace Astrana.Core.Domain.Peers.Queries
{
    public class GetInstancePeerSummaryQuery : IGetInstancePeerSummaryQuery
    {
        private readonly ILogger<GetInstancePeerSummaryQuery> _logger;

        private readonly IAstranaApiInfo _astranaApiInfo;

        private readonly IUserManager _userManager;
        private readonly ISystemSettingRepository<Guid> _systemSettingRepository;
        private readonly IUserProfileRepository<Guid> _userProfileRepository;

        public GetInstancePeerSummaryQuery(ILogger<GetInstancePeerSummaryQuery> logger, IAstranaApiInfo astranaApiInfo, IUserManager userManager, ISystemSettingRepository<Guid> systemSettingRepository, IUserProfileRepository<Guid> userProfileRepository)
        {
            _logger = logger;

            _astranaApiInfo = astranaApiInfo;

            _userManager = userManager;
            _systemSettingRepository = systemSettingRepository;
            _userProfileRepository = userProfileRepository;
        }

        public async Task<PeerSummaryDto?> ExecuteAsync(Guid actioningUserId)
        {
            var instanceUser = await _userManager.GetInstanceUserAsync();

            if (instanceUser == null)
                throw new Exception("Instance User Not Found");

            var instanceUserProfile = await _userProfileRepository.GetUserProfileByIdAsync(instanceUser.ProfileId);

            if (instanceUserProfile == null)
                throw new Exception("Instance User Profile Not Found");

            var result = await _systemSettingRepository.GetSystemSettingsAsync(new SystemSettingQueryOptions<Guid, Guid>
            {
                Names = new List<string> { SystemSettingDefinitions.Names.HostName, SystemSettingDefinitions.Names.HostPortNumber }
            });

            var hostName = result.Data.First(o => o.Name == SystemSettingDefinitions.Names.HostName).ValueOrDefault;
            var hostPortNumber = result.Data.First(o => o.Name == SystemSettingDefinitions.Names.HostPortNumber).ValueOrDefault;

            var peerAddress = new Uri("https://" + hostName + ":" + hostPortNumber);

            var peerAge = new Age(instanceUser.DateOfBirth.DateTime, DateTime.UtcNow);

            var peerSummary = new PeerSummaryDto
            {
                Id = instanceUser.Id,
                ProfileId = instanceUser.ProfileId,

                Address = peerAddress.ToString(),

                FirstName = instanceUser.FirstName,
                LastName = instanceUser.LastName,

                Age = (short)peerAge.Years,
                Gender = instanceUser.Sex,

                ProfilePicture = instanceUserProfile.ProfilePicturesCollection?.ContentItems?.FirstOrDefault()?.Image?.ToDomainTransferObject(),
                ProfileCoverPicture = instanceUserProfile.CoverPicturesCollection?.ContentItems?.FirstOrDefault()?.Image?.ToDomainTransferObject()
            };

            if (peerSummary.ProfilePicture != null && !string.IsNullOrEmpty(peerSummary.ProfilePicture.Location) && peerSummary.ProfilePicture.Location.StartsWith('/'))
            {
                peerSummary.ProfilePicture.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, peerSummary.ProfilePicture.Location);
            }

            if (peerSummary.ProfileCoverPicture != null && !string.IsNullOrEmpty(peerSummary.ProfileCoverPicture.Location) && peerSummary.ProfileCoverPicture.Location.StartsWith('/'))
            {
                peerSummary.ProfileCoverPicture.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, peerSummary.ProfileCoverPicture.Location);
            }

            _logger.LogTrace($"Executed {nameof(GetInstancePeerSummaryQuery).SplitOnUpperCase()}");

            return peerSummary;
        }
    }
}