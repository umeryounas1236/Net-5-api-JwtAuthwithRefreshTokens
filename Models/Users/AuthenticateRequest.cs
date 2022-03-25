using System.ComponentModel.DataAnnotations;

namespace Net_5_api_JwtAuthwithRefreshTokens.Models.Users
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}