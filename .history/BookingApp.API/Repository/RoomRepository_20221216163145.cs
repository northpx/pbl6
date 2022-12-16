using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.API.Data.Entities;
using BookingApp.BookingApp.API.Data;

namespace BookingApp.BookingApp.API.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly DataContext _dataContext;

        public RoomRepository(DataContext dataContext){
            _dataContext = dataContext;
        }

        public IQueryable<Room> Rooms => _dataContext.Rooms;

        public IUnitOfWork UnitOfWork => (IUnitOfWork)_dataContext;

        public void Add(Room room)
        {
            throw new NotImplementedException();
        }

        public void Delete(Room room)
        {
            throw new NotImplementedException();
        }

        public void Update(Room room)
        {
            throw new NotImplementedException();
        }
    }
}