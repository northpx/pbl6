using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.BookingApp.API.Data.Entities
{
    public class BookingDetail
    {
        [Key]
        public int Id { get; set; }
        public int BookingId { get; set; }
        public int RoomTypeId { get; set; }
        public int RoomQuantity { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
    }
}