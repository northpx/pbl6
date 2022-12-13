using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BookingApp.BookingApp.API.Data;
using BookingApp.BookingApp.API.Data.Entities;
using BookingApp.BookingApp.API.DTOs;
using BookingApp.BookingApp.API.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookingApp.BookingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly ITokenService _tokenService;
        // public static User user = new User();
        
        public AuthController(DataContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register ([FromBody] AuthUserDto authUserDto){
            var dbUser = await _context
                .Users
                .Where(u=>u.Username == authUserDto.Username || u.Email == authUserDto.Email)
                .FirstOrDefaultAsync();
            if (dbUser != null){
                return BadRequest("User or email already existed!");
            }
            CreatePasswordHash(authUserDto.Password, out byte[] passwordHash, out byte[] passwordSalt);
            var user = new User{
                Fullname = authUserDto.Fullname,
                Email = authUserDto.Email,
                Username = authUserDto.Username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };
            await _context.Users.AddAsync(user);
            _context.SaveChanges();
            var token = _tokenService.CreateToken(user);
            return Ok(token);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDto loginUserDto ){
            loginUserDto.Username = loginUserDto.Username.ToLower();
            var dbUser = await _context.Users.FirstOrDefaultAsync(u=>u.Username == loginUserDto.Username);
            if (dbUser == null){
                return BadRequest("Username is not valid!");
            }
            if (!VerifyPasswordHash(loginUserDto.Password, dbUser.PasswordHash, dbUser.PasswordSalt)){
                return BadRequest("Password is not valid!");
            }
            var token = _tokenService.CreateToken(dbUser);
            return Ok(token);
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt){
            using(var hmac = new HMACSHA512()){
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt){
            using(var hmac = new HMACSHA512(passwordSalt)){
                var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                return computeHash.SequenceEqual(passwordHash);
            }
            
        }
    }
}