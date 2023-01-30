using Astrana.Core.Domain.Models.IdentityAccessManagement.Constants;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.IdentityAccessManagement.Models
{
    public class LoginRequest
    {
        [Required]
        [MinLength(ModelProperties.LoginRequest.MinimumUsernameLength)]
        [MaxLength(ModelProperties.LoginRequest.MaximumUsernameLength)]
        public string? Username { get; set; }

        [Required]
        [MinLength(ModelProperties.LoginRequest.MinimumPasswordLength)]
        [MaxLength(ModelProperties.LoginRequest.MaximumPasswordLength)]
        public string? Password { get; set; }
        
        public bool? RememberMe { get; set; }
    }
}