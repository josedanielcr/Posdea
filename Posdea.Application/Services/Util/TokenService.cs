using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Posdea.Application.Common.Interfaces.Services.Util;
using Posdea.Application.Options;
using Posdea.Domain.Entities.UserSegment;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Services.Util
{
    public class TokenService : ITokenService
    {
        private readonly TokenConfiguration tokenConfiguration;

        public TokenService(IOptions<TokenConfiguration> tokenConfiguration)
        {
            this.tokenConfiguration = tokenConfiguration.Value;
        }

        public string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role.Name.ToString())
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenConfiguration.TokenKey));
            var credendials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(8),
                signingCredentials: credendials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}