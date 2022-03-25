using Net_5_api_JwtAuthwithRefreshTokens.Entities;
using Net_5_api_JwtAuthwithRefreshTokens.Models.Users;
using System.Collections.Generic;

namespace Net_5_api_JwtAuthwithRefreshTokens.Services.UserService
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress);
        AuthenticateResponse RefreshToken(string token, string ipAddress);
        void RevokeToken(string token, string ipAddress);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
