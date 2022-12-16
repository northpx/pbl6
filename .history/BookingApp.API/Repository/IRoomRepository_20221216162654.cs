using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.BookingApp.API.Repository
{
    public class IRoomRepository
    {
        IQueryable<Room> Rooms{get;}
    }
}