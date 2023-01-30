using Astrana.Core.Localization.Attributes;

namespace Astrana.Core.Domain.Models.SystemSetup.Enums
{
    [TranslationCode("system_setup_status")]
    public enum SystemSetupStatus
    {
        [TranslationCode("complete")]
        Complete,

        [TranslationCode("in_progress")]
        InProgress,
        
        [TranslationCode("new")]
        New
    }
}
