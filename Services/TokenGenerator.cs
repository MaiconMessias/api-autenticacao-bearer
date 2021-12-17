using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace api_autenticacao_bearer.Services
{
    // gerador de tokens
    public class TokenGenerator
    {
        private readonly IConfigurationRoot _configBuilder;

        public TokenGenerator()
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile($"appsettings.json");
            _configBuilder = builder.Build();
        }    

        public string GenerateToken()
        {
            string secret = _configBuilder.GetSection("Secret").Value;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new  SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}