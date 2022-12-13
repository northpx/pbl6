
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
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
        public string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, "Admin")
            };
 
            // var symmetricKey = new SymmetricSecurityKey(
            //     Encoding.UTF8.GetBytes(_configuration.GetSection("TokenKey").Value));
 
            // var tokenDescriptor = new SecurityTokenDescriptor
            // {
            //     Subject = new ClaimsIdentity(claims),
            //     Expires = DateTime.Now.AddDays(1),
            //     SigningCredentials = new SigningCredentials(
            //         symmetricKey, SecurityAlgorithms.HmacSha512Signature)
            // };
 
            // var tokenHandler = new JwtSecurityTokenHandler();
 
            // var token = tokenHandler.CreateToken(tokenDescriptor);
 
            // return tokenHandler.WriteToken(token);
        }
    }
}