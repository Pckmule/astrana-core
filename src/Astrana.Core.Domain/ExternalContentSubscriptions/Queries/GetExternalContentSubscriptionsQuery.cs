/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.ExternalContentSubscriptions;
using Astrana.Core.Domain.Models.AstranaApi.Contracts;
using Astrana.Core.Domain.Models.ExternalContent.Subscriptions;
using Astrana.Core.Domain.Models.ExternalContent.Subscriptions.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.ExternalContentSubscriptions.Queries
{
    public class GetExternalContentSubscriptionsQuery : IGetExternalSubscriptionsQuery
    {
        private readonly ILogger<GetExternalContentSubscriptionsQuery> _logger;
        private readonly IAstranaApiInfo _astranaApiInfo;
        private readonly IExternalContentSubscriptionRepository<Guid> _externalContentSubscriptionRepository;

        public GetExternalContentSubscriptionsQuery(ILogger<GetExternalContentSubscriptionsQuery> logger, IAstranaApiInfo astranaApiInfo, IExternalContentSubscriptionRepository<Guid> externalContentSubscriptionRepository)
        {
            _logger = logger;
            _astranaApiInfo = astranaApiInfo;
            _externalContentSubscriptionRepository = externalContentSubscriptionRepository;
        }

        public async Task<GetResult<ExternalContentSubscriptionQueryOptions<Guid, Guid>, ExternalContentSubscription, Guid, Guid>> ExecuteAsync(Guid actioningUserId, ExternalContentSubscriptionQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new ExternalContentSubscriptionQueryOptions<Guid, Guid>();

            var result = await _externalContentSubscriptionRepository.GetExternalContentSubscriptionsAsync(options);

            if (result.HasData)
            {
                foreach (var externalContentSubscription in result.Data.Where(externalContentSubscription => externalContentSubscription.IconImage != null && externalContentSubscription.IconImage.Location.StartsWith("/")))
                {
                    externalContentSubscription.IconImage.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, externalContentSubscription.IconImage.Location);
                }

                foreach (var externalContentSubscription in result.Data.Where(externalContentSubscription => externalContentSubscription.LogoImage != null && externalContentSubscription.LogoImage.Location.StartsWith("/")))
                {
                    externalContentSubscription.LogoImage.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, externalContentSubscription.LogoImage.Location);
                }

                foreach (var externalContentSubscription in result.Data.Where(externalContentSubscription => externalContentSubscription.CoverImage != null && externalContentSubscription.CoverImage.Location.StartsWith("/")))
                {
                    externalContentSubscription.CoverImage.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, externalContentSubscription.CoverImage.Location);
                }
            }

            _logger.LogTrace($"Executed {nameof(GetExternalContentSubscriptionsQuery).SplitOnUpperCase()}");

            return new GetResult<ExternalContentSubscriptionQueryOptions<Guid, Guid>, ExternalContentSubscription, Guid, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}