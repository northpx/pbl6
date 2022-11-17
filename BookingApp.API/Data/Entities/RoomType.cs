using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.API.Data.Entities;

namespace BookingApp.BookingApp.API.Data.Entities
{
    public class RoomType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}