using Astrana.Core.Localization.Attributes;

namespace Astrana.Core.Domain.Models.UserProfiles.Enums
{
    [TranslationCode("name_combination")]
    public enum NameCombination
    {
        [TranslationCode("default")]
        Default,

        [TranslationCode("first_last")]
        FirstLast,

        [TranslationCode("first_middle")]
        FirstMiddle,

        [TranslationCode("first_middle_last")]
        FirstMiddleLast
    }
}
