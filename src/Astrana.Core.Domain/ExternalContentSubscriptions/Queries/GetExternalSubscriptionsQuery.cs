/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.ExternalContentSubscriptions;
using Astrana.Core.Domain.Models.AstranaApi.Contracts;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.ExternalContentSubscriptions.Queries
{
    public class GetExternalSubscriptionsQuery : IGetExternalSubscriptionsQuery
    {
        private readonly ILogger<GetExternalSubscriptionsQuery> _logger;
        private readonly IAstranaApiInfo _astranaApiInfo;
        private readonly IExternalContentSubscriptionRepository<Guid> _externalContentSubscriptionRepository;

        public GetExternalSubscriptionsQuery(ILogger<GetExternalSubscriptionsQuery> logger, IAstranaApiInfo astranaApiInfo, IExternalContentSubscriptionRepository<Guid> externalContentSubscriptionRepository)
        {
            _logger = logger;
            _astranaApiInfo = astranaApiInfo;
            _externalContentSubscriptionRepository = externalContentSubscriptionRepository;
        }

        public async Task<GetResult<ExternalContentSubscriptionQueryOptions<Guid, Guid>, ExternalSubscription, Guid, Guid>> ExecuteAsync(Guid actioningUserId, ExternalContentSubscriptionQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new ExternalContentSubscriptionQueryOptions<Guid, Guid>();

            var result = await _externalContentSubscriptionRepository.GetExternalContentSubscriptionsAsync(options);

            if (result.HasData)
            {
                foreach (var externalContentSubscription in result.Data.Where(externalContentSubscription => externalContentSubscription.PreviewImage.Location.StartsWith("/")))
                {
                    externalContentSubscription.PreviewImage.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, externalContentSubscription.PreviewImage.Location);
                }
            }

            _logger.LogTrace($"Executed {nameof(GetExternalSubscriptionsQuery).SplitOnUpperCase()}");

            return new GetResult<ExternalContentSubscriptionQueryOptions<Guid, Guid>, ExternalSubscription, Guid, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}