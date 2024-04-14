using Astrana.Core.Domain.Models.IdentityAccessManagement.Constants;
using System.ComponentModel.DataAnnotations;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.IdentityAccessManagement.Models
{
    public class ResetPasswordRequestDto: InputModelBase
    {
        [Required]
        [MinLength(ModelProperties.ResetPasswordRequest.MinimumValidationTokenLength)]
        [MaxLength(ModelProperties.ResetPasswordRequest.MaximumValidationTokenLength)]
        public string ValidationToken { get; set; }

        [Required]
        [MinLength(ModelProperties.ResetPasswordRequest.MinimumNewPasswordLength)]
        [MaxLength(ModelProperties.ResetPasswordRequest.MaximumNewPasswordLength)]
        public string NewPassword { get; set; }
    }
}