/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Links.Commands.CreateLinks;
using Astrana.Core.Domain.Models.Attachments.Enums;
using Astrana.Core.Domain.Models.Links;
using Astrana.Core.Domain.Models.Posts;
using Astrana.Core.Domain.Models.Posts.Constants;
using Astrana.Core.Domain.Models.Posts.DomainTransferObjects;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Posts.Repositories;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Posts.Commands.Handlers.CreatePosts
{
    public class CreatePostsCommandHandler : ICreatePostsCommandHandler
    {
        private readonly ILogger<CreatePostsCommandHandler> _logger;

        private readonly IPostRepository<Guid> _postRepository;

        private readonly ICreateLinksCommand _createLinksCommand;

        public CreatePostsCommandHandler(ILogger<CreatePostsCommandHandler> logger, IPostRepository<Guid> postRepository, ICreateLinksCommand createLinksCommand)
        {
            _logger = logger;

            _postRepository = postRepository;
            _createLinksCommand = createLinksCommand;
        }

        public async Task<AddResult<List<Post>>> ExecuteAsync(IList<PostDto> postsToAddDtos, Guid actioningUserId)
        {
            if (!postsToAddDtos.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Add, ModelProperties.Post.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<Post>>(new List<Post>(), 0, message);
            }

            try
            {
                var postsToAdd = postsToAddDtos.Select(o => new Post(o)).ToList();

                foreach (var post in postsToAdd)
                {
                    if(post.Attachments == null || post.Attachments.Count < 1)
                        continue;
                    
                    var createAttachmentsResult = await CreatePostAttachmentsAsync(post.Attachments, actioningUserId);

                    if (createAttachmentsResult.Outcome == ResultOutcome.Success)
                        post.Attachments = createAttachmentsResult.Data;
                }

                var result = await _postRepository.CreateAsync(postsToAdd, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return new AddSuccessResult<List<Post>>(result.Data, result.Count, MRB.CreateSuccessResultMessage(ModelProperties.Post.NameSingularForm, ModelProperties.Post.NamePluralForm, result.Count));

                return new AddFailResult<List<Post>>(result.Data, result.Count, result.Message, result.ResultCode);
            }
            catch (InvalidDomainEntityStateException ex)
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, ModelProperties.Post.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<Post>>(new List<Post>(), 0, message);
            }
            catch(Exception ex)
            {
                return new AddFailResult<List<Post>>(null);
            }
        }

        private async Task<AddResult<List<PostAttachment>>> CreatePostAttachmentsAsync(List<PostAttachment> attachments, Guid actioningUserId)
        {
            var createLinkAttachmentResult = new AddResult(ResultOutcome.Success);

            foreach (var postAttachmentToAdd in attachments)
            {
                // if (!string.IsNullOrWhiteSpace(postAttachmentToAdd.ContentId))
                //    continue;

                if (postAttachmentToAdd is { Link: { }, Type: AttachmentType.Link })
                {
                    var linkAttachment = new Link
                    {
                        LinkId = Guid.Empty,
                        Url = postAttachmentToAdd.Link.Url,
                        Title = string.IsNullOrWhiteSpace(postAttachmentToAdd.Link.Title) ? postAttachmentToAdd.Title : postAttachmentToAdd.Link.Title,
                        Description = postAttachmentToAdd.Link.Description,
                        CharSet = postAttachmentToAdd.Link.CharSet,
                        Robots = postAttachmentToAdd.Link.Robots,
                        Locale = postAttachmentToAdd.Link.Locale,
                        PreviewImage = postAttachmentToAdd.Link.PreviewImage
                    };

                    var createAttachmentResult = await _createLinksCommand.ExecuteAsync(new List<Link> { linkAttachment }, actioningUserId);

                    if (createAttachmentResult.Outcome == ResultOutcome.Success)
                    {
                        var linkData = createAttachmentResult.Data.First();
                        // postAttachmentToAdd.ContentId = linkData.Id.ToString();
                        postAttachmentToAdd.Link = linkData;
                        postAttachmentToAdd.LinkId = linkData.LinkId;
                        // postAttachmentToAdd.Link.PreviewImageId = linkData.PreviewImage.Id;
                    }
                }
            }

            if (createLinkAttachmentResult.Outcome == ResultOutcome.Success)
                return new AddSuccessResult<List<PostAttachment>>(attachments, attachments.Count, MRB.CreateSuccessResultMessage(ModelProperties.Post.NameSingularForm, ModelProperties.Post.NamePluralForm, attachments.Count));

            return new AddFailResult<List<PostAttachment>>(attachments, attachments.Count, "", "");
        }
    }
}
