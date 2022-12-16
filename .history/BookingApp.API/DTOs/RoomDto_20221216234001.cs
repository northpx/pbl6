using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.BookingApp.API.DTOs
{
    public class RoomDto
    {
        public int? Id { get; set; }
        public int RoomTypesId { get; set; }
        public decimal default_price { get; set; }
        public int max_guest { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
    }
}