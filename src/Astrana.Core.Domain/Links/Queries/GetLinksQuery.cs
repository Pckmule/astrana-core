/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Links;
using Astrana.Core.Domain.Models.AstranaApi.Contracts;
using Astrana.Core.Domain.Models.Links;
using Astrana.Core.Domain.Models.Links.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Links.Queries
{
    public class GetLinksQuery : IGetLinksQuery
    {
        private readonly ILogger<GetLinksQuery> _logger;
        private readonly IAstranaApiInfo _astranaApiInfo;
        private readonly ILinkRepository<Guid> _linkRepository;

        public GetLinksQuery(ILogger<GetLinksQuery> logger, IAstranaApiInfo astranaApiInfo, ILinkRepository<Guid> linkRepository)
        {
            _logger = logger;
            _astranaApiInfo = astranaApiInfo;
            _linkRepository = linkRepository;
        }

        public async Task<GetResult<LinkQueryOptions<Guid, Guid>, Link, Guid, Guid>> ExecuteAsync(Guid actioningUserId, LinkQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new LinkQueryOptions<Guid, Guid>();

            var result = await _linkRepository.GetLinksAsync(options);

            if (result.HasData)
            {
                foreach (var link in result.Data.Where(link => link.PreviewImage.Location.StartsWith('/')))
                {
                    link.PreviewImage.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, link.PreviewImage.Location);
                }
            }

            _logger.LogTrace($"Executed {nameof(GetLinksQuery).SplitOnUpperCase()}");

            return new GetResult<LinkQueryOptions<Guid, Guid>, Link, Guid, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}