using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.BookingApp.API.Data.Entities
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }
        public int Code { get; set; }
        public bool Remain { get; set; }
        public int Reduction { get; set; }
        public DateTime EndDate { get; set; }
        public bool Deleted { get; set; }
    }
}