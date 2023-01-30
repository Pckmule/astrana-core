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

namespace Astrana.Core.Domain.Posts.Commands.CreatePosts
{
    public class CreatePostsCommand : ICreatePostsCommand
    {
        private readonly ILogger<CreatePostsCommand> _logger;
        private readonly IPostRepository<Guid> _postRepository;

        public CreatePostsCommand(ILogger<CreatePostsCommand> logger, IPostRepository<Guid> postRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
        }

        public async Task<AddResult<List<Post>>> ExecuteAsync(IList<PostToAdd> postsToAdd, Guid actioningUserId)
        {
            if (!postsToAdd.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Add, ModelProperties.Post.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<Post>>(new List<Post>(), 0, message);
            }

            var validatedPostsToAdd = postsToAdd.Where(o => o.IsValid).ToList();
            if (!validatedPostsToAdd.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, ModelProperties.Post.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<Post>>(new List<Post>(), 0, message);
            }

            var result = await _postRepository.CreateAsync(validatedPostsToAdd, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new AddSuccessResult<List<Post>>(result.Data, result.Count, MRB.CreateSuccessResultMessage(ModelProperties.Post.NameSingularForm, ModelProperties.Post.NamePluralForm, result.Count));
            
            return new AddFailResult<List<Post>>(result.Data, result.Count, result.Message, result.ResultCode);
        }
    }
}
