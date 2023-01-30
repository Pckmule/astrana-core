/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Posts;
using Astrana.Core.Domain.Models.Posts.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Extensions;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Posts.Commands.DeletePosts
{
    public class DeletePostsCommand : IDeletePostsCommand
    {
        private readonly ILogger<DeletePostsCommand> _logger;
        private readonly IPostRepository<Guid> _postRepository;

        public DeletePostsCommand(ILogger<DeletePostsCommand> logger, IPostRepository<Guid> postRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
        }

        public async Task<DeleteResult<List<long>>> ExecuteAsync(IList<long> postsToDeleteIds, Guid actioningUserId)
        {
            if (!postsToDeleteIds.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Remove, ModelProperties.Post.NamePluralForm);

                _logger.LogWarning(message);

                return new DeleteFailResult<List<long>>(new List<long>(), 0, message);
            }

            var validatedPostsToRemoveIds = postsToDeleteIds.Where(o => o.IsValidForUpdateOrDelete()).ToList();
            if (!validatedPostsToRemoveIds.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Remove, ModelProperties.Post.NamePluralForm);

                _logger.LogWarning(message);

                return new DeleteFailResult<List<long>>(new List<long>(), 0, message);
            }

            var result = await _postRepository.DeleteAsync(validatedPostsToRemoveIds, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new DeleteSuccessResult<List<long>>(result.Data, result.Count, MRB.DeleteSuccessResultMessage(ModelProperties.Post.NameSingularForm, ModelProperties.Post.NamePluralForm, result.Count));
            
            return new DeleteFailResult<List<long>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}