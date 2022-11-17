using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.BookingApp.API.Data.Entities
{
    public class Customer : User
    {
        public bool Gender { get; set; }
        [MaxLength(256)]
        public string Address { get; set; }
    }
}