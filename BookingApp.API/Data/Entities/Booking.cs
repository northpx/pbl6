using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.BookingApp.API.Data.Entities
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime Create { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int RoomAmount { get; set; }
        public bool Canceled { get; set; }
        public int CouponId { get; set; }
        
    }
}