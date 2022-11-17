using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.BookingApp.API.DTOs
{
    public class LoginUserDto{
        [Required]
        [MaxLength(256)]
        public string Username { get; set; }
        [Required]
        [MaxLength(256)]
        public string Password { get; set; }
    }
    public class AuthUserDto : LoginUserDto
    {
        [Required]
        public string Fullname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        // public int Role { get; set; }

    }
}