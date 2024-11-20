using BookStoreCore.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreInfrastructure.Authentication
{
    internal sealed class TokenProvider(IConfiguration configuration)
    {

        public string Create(User user)
        {
            string secretKey = configuration["Jwt:Secret1"];
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

            var credential = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity([

                    new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                    new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Email, user.Email)
                ]),
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = credential,
                Issuer = configuration["Jwt:Issuer"],
                Audience = configuration["Jwt:Audience"]

            };

            var handler = new JsonWebTokenHandler();

            string token = handler.CreateToken(tokenDescriptor);

            return token;

        }

    }
}
