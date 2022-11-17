using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.BookingApp.API.Data.Entities
{
    public class History
    {
        [Key]
        public int Id { get; set; }
        public int PaymentDetailId { get; set; }
        public int BookingDetailId { get; set; }
    }
}