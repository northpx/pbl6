
using System.ComponentModel.DataAnnotations;


namespace BookingApp.BookingApp.API.Data.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Fullname { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(256)]
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        // public int RoleId { get; set; }
        // public Role Role { get; set; }
    }
}