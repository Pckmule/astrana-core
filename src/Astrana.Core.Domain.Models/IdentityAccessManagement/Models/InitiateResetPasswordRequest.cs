using Astrana.Core.Domain.Models.IdentityAccessManagement.Constants;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.IdentityAccessManagement.Models
{
    public class InitiateResetPasswordRequest
    {
        [Required]
        [MinLength(ModelProperties.ApplicationUser.MinimumUsernameLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumUsernameLength)]
        public string Username { get; set; }
    }
}