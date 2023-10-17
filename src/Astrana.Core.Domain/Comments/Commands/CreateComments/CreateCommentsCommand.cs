/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Comments;
using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.Comments;
using Astrana.Core.Domain.Models.Comments.Constants;
using Astrana.Core.Domain.Models.Comments.DomainTransferObjects;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Comments.Commands.CreateComments
{
    public class CreateCommentsCommand : ICreateCommentsCommand
    {
        private readonly ILogger<CreateCommentsCommand> _logger;

        private readonly ICommentRepository<Guid> _commentRepository;

        public CreateCommentsCommand(ILogger<CreateCommentsCommand> logger, ICommentRepository<Guid> commentRepository)
        {
            _logger = logger;

            _commentRepository = commentRepository;
        }

        public async Task<AddResult<List<Comment>>> ExecuteAsync(IList<CommentDto> commentsToAddDtos, Guid actioningUserId)
        {
            if (!commentsToAddDtos.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Add, ModelProperties.Comment.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<Comment>>(new List<Comment>(), 0, message);
            }

            try
            {
                var commentsToAdd = commentsToAddDtos.Select(o => new Comment(o)).ToList();
                
                var result = await _commentRepository.CreateAsync(commentsToAdd, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return new AddSuccessResult<List<Comment>>(result.Data, result.Count, MRB.CreateSuccessResultMessage(ModelProperties.Comment.NameSingularForm, ModelProperties.Comment.NamePluralForm, result.Count));

                return new AddFailResult<List<Comment>>(result.Data, result.Count, result.Message, result.ResultCode);
            }
            catch (InvalidDomainEntityStateException ex)
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, ModelProperties.Comment.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<Comment>>(new List<Comment>(), 0, message);
            }
            catch (Exception)
            {
                return new AddFailResult<List<Comment>>(null);
            }
        }
    }
}
