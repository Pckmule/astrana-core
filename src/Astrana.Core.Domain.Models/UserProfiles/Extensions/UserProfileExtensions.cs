using Astrana.Core.Domain.Models.UserProfiles.Enums;

namespace Astrana.Core.Domain.Models.UserProfiles.Extensions
{
    public static class UserProfileExtensions
    {
        public static string GetNameCombination(this UserProfile model, NameCombination nameCombination = NameCombination.Default)
        {
            var name = new List<string> { model.FirstName };

            switch (nameCombination)
            {
                case NameCombination.FirstMiddle or NameCombination.FirstMiddleLast:
                    name.Add(model.MiddleNames);
                    break;

                case NameCombination.FirstLast:
                    name.Add(model.LastName);
                    break;
            }

            return string.Join(' ', name);
        }
    }
}
