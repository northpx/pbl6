using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.BookingApp.API.Data.Entities;

namespace BookingApp.BookingApp.API.Service
{
    public interface ITokenService
    {
        string CreateToken(string user);
        
    }
}