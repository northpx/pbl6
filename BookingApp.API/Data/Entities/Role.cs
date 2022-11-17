
using System.ComponentModel.DataAnnotations;


namespace BookingApp.BookingApp.API.Data.Entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string RoleType { get; set; }
        // public ICollection<User> Users { get; set; }
    }
}