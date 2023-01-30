/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Posts;
using Astrana.Core.Domain.Models.Posts;
using Astrana.Core.Domain.Models.Posts.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Posts.Commands.UpdatePosts
{
    public class UpdatePostsCommand : IUpdatePostsCommand
    {
        private readonly ILogger<UpdatePostsCommand> _logger;
        private readonly IPostRepository<Guid> _postRepository;

        public UpdatePostsCommand(ILogger<UpdatePostsCommand> logger, IPostRepository<Guid> postRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
        }

        public async Task<UpdateResult<List<Post>>> ExecuteAsync(IList<Post> postsToUpdate, Guid actioningUserId)
        {
            if (!postsToUpdate.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Update, ModelProperties.Post.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<Post>>(new List<Post>(), 0, message);
            }

            var validatedPostsToUpdate = postsToUpdate.Where(o => o.IsValid).ToList();
            if (!validatedPostsToUpdate.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Update, ModelProperties.Post.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<Post>>(new List<Post>(), 0, message);
            }

            var result = await _postRepository.UpdateAsync(validatedPostsToUpdate, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new UpdateSuccessResult<List<Post>>(result.Data, result.Count, MRB.UpdateSuccessResultMessage(ModelProperties.Post.NameSingularForm, ModelProperties.Post.NamePluralForm, result.Count));
            
            return new UpdateFailResult<List<Post>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}