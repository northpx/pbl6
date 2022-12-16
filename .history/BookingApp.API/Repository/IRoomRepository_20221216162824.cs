using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.API.Data.Entities;

namespace BookingApp.BookingApp.API.Repository
{
    public interface IRoomRepository : IRepository<Room>
    {
        IQueryable<Room> Rooms{get;}
        void Add(Room room);
        void Update(Room room)
    }
}