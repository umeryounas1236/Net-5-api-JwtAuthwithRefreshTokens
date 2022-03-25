using Net_5_api_JwtAuthwithRefreshTokens.Entities;

namespace Net_5_api_JwtAuthwithRefreshTokens.Services.JwtService
{
    public interface IJwtUtils
    {
        public string GenerateJwtToken(User user);
        public int? ValidateJwtToken(string token);
        public RefreshToken GenerateRefreshToken(string ipAddress);
    }
}
