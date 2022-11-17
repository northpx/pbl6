using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.BookingApp.API.Data.Entities;

namespace BookingApp.API.Data.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public int RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
        public int MaxGuest { get; set; }
        // public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        // public virtual ICollection<RoomImage> RoomImages { get; set; }
    }
}