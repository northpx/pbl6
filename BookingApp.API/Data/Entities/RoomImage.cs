using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.BookingApp.API.Data.Entities
{
    public class RoomImage
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(256)]
        public string DataUrl { get; set; }
    }
}