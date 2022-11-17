using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.API.Data.Entities
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(256)]
        public string Address { get; set; }
        [MaxLength(256)]
        public string PhoneNumber { get; set; }
        
    }
}