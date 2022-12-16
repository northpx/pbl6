using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.BookingApp.API.Data.Entities;

namespace BookingApp.API.Data.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("RoomType")]
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        [Required]
        public decimal Default_Price { get; set; }
        [Required]
        public int MaxGuest { get; set; }
        [Required]
        public int status { get; set; }
        [MaxLength(256)]
        public string Description { get; set; }
        
        public ICollection<BookingDetail> BookingDetails { get; set; }
        // public ICollection<RoomImage> RoomImages { get; set; }
    }
}