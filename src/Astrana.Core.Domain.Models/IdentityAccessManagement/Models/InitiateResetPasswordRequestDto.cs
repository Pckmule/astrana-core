using Astrana.Core.Domain.Models.IdentityAccessManagement.Constants;
using Astrana.Core.Framework.Model;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.IdentityAccessManagement.Models
{
    public class InitiateResetPasswordRequestDto: InputModelBase
    {
        [Required]
        [MinLength(ModelProperties.ApplicationUser.MinimumUsernameLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumUsernameLength)]
        public string Username { get; set; }
    }
}