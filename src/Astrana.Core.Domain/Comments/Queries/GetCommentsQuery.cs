/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Comments;
using Astrana.Core.Domain.Models.AstranaApi.Contracts;
using Astrana.Core.Domain.Models.Comments;
using Astrana.Core.Domain.Models.Comments.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Comments.Queries
{
    public class GetCommentsQuery : IGetCommentsQuery
    {
        private readonly ILogger<GetCommentsQuery> _logger;
        private readonly IAstranaApiInfo _astranaApiInfo;
        private readonly ICommentRepository<Guid> _commentRepository;

        public GetCommentsQuery(ILogger<GetCommentsQuery> logger, IAstranaApiInfo astranaApiInfo, ICommentRepository<Guid> commentRepository)
        {
            _logger = logger;
            _astranaApiInfo = astranaApiInfo;
            _commentRepository = commentRepository;
        }

        public async Task<GetResult<CommentQueryOptions<Guid, Guid>, Comment, Guid, Guid>> ExecuteAsync(Guid actioningUserId, CommentQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new CommentQueryOptions<Guid, Guid>();

            var result = await _commentRepository.GetCommentsAsync(options);
            
            _logger.LogTrace($"Executed {nameof(GetCommentsQuery).SplitOnUpperCase()}");

            return new GetResult<CommentQueryOptions<Guid, Guid>, Comment, Guid, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}