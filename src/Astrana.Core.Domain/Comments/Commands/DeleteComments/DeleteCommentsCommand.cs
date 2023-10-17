/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Comments;
using Astrana.Core.Domain.Models.Comments.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Extensions;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Comments.Commands.DeleteComments
{
    public class DeleteCommentsCommand : IDeleteCommentsCommand
    {
        private readonly ILogger<DeleteCommentsCommand> _logger;
        private readonly ICommentRepository<Guid> _commentRepository;

        public DeleteCommentsCommand(ILogger<DeleteCommentsCommand> logger, ICommentRepository<Guid> commentRepository)
        {
            _logger = logger;
            _commentRepository = commentRepository;
        }

        public async Task<DeleteResult<List<Guid>>> ExecuteAsync(IList<Guid> commentsToDeleteIds, Guid actioningUserId)
        {
            if (!commentsToDeleteIds.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Remove, ModelProperties.Comment.NamePluralForm);

                _logger.LogWarning(message);

                return new DeleteFailResult<List<Guid>>(new List<Guid>(), 0, message);
            }

            var validatedCommentsToRemoveIds = commentsToDeleteIds.Where(o => o.IsValidForUpdateOrDelete()).ToList();
            if (!validatedCommentsToRemoveIds.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Remove, ModelProperties.Comment.NamePluralForm);

                _logger.LogWarning(message);

                return new DeleteFailResult<List<Guid>>(new List<Guid>(), 0, message);
            }

            var result = await _commentRepository.DeleteAsync(validatedCommentsToRemoveIds, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new DeleteSuccessResult<List<Guid>>(result.Data, result.Count, MRB.DeleteSuccessResultMessage(ModelProperties.Comment.NameSingularForm, ModelProperties.Comment.NamePluralForm, result.Count));
            
            return new DeleteFailResult<List<Guid>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}