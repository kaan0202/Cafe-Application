using Application.Abstraction.Handlers;
using Application.DTOs.Token;
using Domain.Entities.Identity;
using Infrastracture.Helper;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Handler.Token
{
    public class TokenHandler : ITokenHandler
    {
        private readonly ConfigurationHelper _configurationHelper;

        public TokenHandler(ConfigurationHelper configurationHelper)
        {
            _configurationHelper = configurationHelper;
        }

        public string CreateRefreshToken()
        {
           string tokenPiece= Guid.NewGuid().ToString();
           byte[] randomBytes = new byte[32];


            using var rnd = RandomNumberGenerator.Create();
            rnd.GetBytes(randomBytes);
            
            string secondTokenPiece = Convert.ToBase64String(randomBytes);

            return $"{tokenPiece}{secondTokenPiece}";
        }

        public TokenDto CreateToken(int minutes, AppUser appUser)
        {
            var accessTokenExpiration= DateTime.UtcNow.AddMinutes(minutes);
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configurationHelper.SecurityKey()));
            var refreshTokenExpiration = DateTime.UtcNow.AddMinutes(Int16.Parse(_configurationHelper.RefreshTokenExpiration()));
            SigningCredentials signingCredentials = new(securityKey, SecurityAlgorithms.HmacSha512);

            JwtSecurityToken jwtSecurityToken = new(
                issuer: _configurationHelper.TokenIssuer(),
                signingCredentials: signingCredentials,
                audience: _configurationHelper.TokenAudience(),
                expires:accessTokenExpiration,
                claims:GetClaims(appUser)


                );
            var handler = new JwtSecurityTokenHandler();
            var token =handler.WriteToken(jwtSecurityToken);
            var tokenDto = new TokenDto 
            { 

             AccessToken = token ,
             Expiration = accessTokenExpiration,
             RefreshTokenExpiration = refreshTokenExpiration,
             RefreshToken = CreateRefreshToken()

             };
            return tokenDto;

        }

        public IEnumerable<Claim> GetClaims(AppUser user)
        {
            string audience = _configurationHelper.TokenAudience();
            var userList = new List<Claim>
            { 
              new Claim(ClaimTypes.Email,user.Email),
              new Claim(JwtRegisteredClaimNames.Aud,audience),
              new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };
            return userList;
        }
    }
}
