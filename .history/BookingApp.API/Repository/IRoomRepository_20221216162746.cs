using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.API.Data.Entities;

namespace BookingApp.BookingApp.API.Repository
{
    public interface IRoomRepository : IRe
    {
        IQueryable<Room> Rooms{get;}
        void Add(Room room);

    }
}