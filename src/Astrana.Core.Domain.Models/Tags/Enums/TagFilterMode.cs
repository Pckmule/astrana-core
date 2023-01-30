using Astrana.Core.Localization.Attributes;

namespace Astrana.Core.Domain.Models.Tags.Enums
{
    [TranslationCode("tag_filter_mode")]
    public enum TagFilterMode
    {
        [TranslationCode("default")] 
        Default,
        
        [TranslationCode("match")]
        Match,

        [TranslationCode("no_match")]
        NoMatch
    }
}
