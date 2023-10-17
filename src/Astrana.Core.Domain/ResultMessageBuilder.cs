/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using System.Text;

namespace Astrana.Core.Domain
{
    public static class ResultMessageBuilder
    {
        public static string NoneProvidedMessage(CrudAction crudAction, string namePluralForm)
        {
            var action = "operate on";

            action = crudAction switch
            {
                CrudAction.Add => "add",
                CrudAction.Modify => "modify",
                CrudAction.Delete => "delete",
                _ => action
            };

            return $"No {namePluralForm} to {action} were provided.";
        }

        public static string NoneValidMessage(CrudAction crudAction, string namePluralForm)
        {
            var action = "operate on";

            action = crudAction switch
            {
                CrudAction.Add => "add",
                CrudAction.Modify => "modify",
                CrudAction.Delete => "delete",
                _ => action
            };

            return $"No {namePluralForm.ToLowerInvariant()} to {action} were valid.";
        }

        public static string NoActionTakenMessage(string reason)
        {
            return "No action taken - " + reason;
        }

        public static string ResultMessage(ResultOutcome resultOutcome, CrudAction crudAction, string nameSingularForm, string namePluralForm, long itemCount = 1)
        {
            var outcome = "Completed";
            var action = "operation - ";

            if (resultOutcome == ResultOutcome.Success)
            {
                outcome = "Successfully";

                action = crudAction switch
                {
                    CrudAction.Create => "created",
                    CrudAction.Update => "updated",
                    CrudAction.Delete => "deleted",
                    _ => action
                };
            }
            else if (resultOutcome == ResultOutcome.Failure)
            {
                outcome = "Could not";

                action = crudAction switch
                {
                    CrudAction.Create => "create",
                    CrudAction.Update => "update",
                    CrudAction.Delete => "delete",
                    _ => action
                };
            }

            var sb = new StringBuilder(outcome + " ");

            sb.Append(action + " ");

            sb.Append(itemCount > 1
                ? $"{itemCount} {namePluralForm.ToLowerInvariant()}"
                : nameSingularForm.ToLowerInvariant());

            return sb.ToString().Trim();
        }

        public static string? CreateSuccessResultMessage(string nameSingularForm, string namePluralForm, long itemCount = 1)
        {
            return ResultMessage(ResultOutcome.Success, CrudAction.Create, nameSingularForm, namePluralForm, itemCount);
        }

        public static string? CreateFailureResultMessage(string nameSingularForm, string namePluralForm, long itemCount = 1)
        {
            return ResultMessage(ResultOutcome.Failure, CrudAction.Create, nameSingularForm, namePluralForm, itemCount);
        }

        public static string? UpdateSuccessResultMessage(string nameSingularForm, string namePluralForm, long itemCount = 1)
        {
            return ResultMessage(ResultOutcome.Success, CrudAction.Update, nameSingularForm, namePluralForm, itemCount);
        }

        public static string? UpdateFailureResultMessage(string nameSingularForm, string namePluralForm, long itemCount = 1)
        {
            return ResultMessage(ResultOutcome.Failure, CrudAction.Update, nameSingularForm, namePluralForm, itemCount);
        }

        public static string? DeleteSuccessResultMessage(string nameSingularForm, string namePluralForm, long itemCount = 1)
        {
            return ResultMessage(ResultOutcome.Success, CrudAction.Delete, nameSingularForm, namePluralForm, itemCount);
        }

        public static string? DeleteFailureResultMessage(string nameSingularForm, string namePluralForm, long itemCount = 1)
        {
            return ResultMessage(ResultOutcome.Failure, CrudAction.Delete, nameSingularForm, namePluralForm, itemCount);
        }
    }
}