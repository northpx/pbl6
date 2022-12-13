using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.BookingApp.API.Data.Entities;

namespace BookingApp.BookingApp.API.Repository
{
    public interface IRoomTypeRepository: IRepository<RoomType>
    {
        IQueryable<RoomType> RoomTypes{get;}
        void Add(RoomType roomType);
        void Update(RoomType roomType);
        void Delete(RoomType roomType);
    }
}