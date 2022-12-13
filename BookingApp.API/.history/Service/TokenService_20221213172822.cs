using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BookingApp.BookingApp.API.Data.Entities;
using Microsoft.IdentityModel.Tokens;

namespace BookingApp.BookingApp.API.Service
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;
        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string CreateToken(User username)
        {
            var claims = new List<Claim>()
            {
                new Claim(Cla, username)
            };
 
            var symmetricKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["TokenKey"]));
 
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(
                    symmetricKey, SecurityAlgorithms.HmacSha512Signature)
            };
 
            var tokenHandler = new JwtSecurityTokenHandler();
 
            var token = tokenHandler.CreateToken(tokenDescriptor);
 
            return tokenHandler.WriteToken(token);
        }
    }
}