using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.BookingApp.API.Data;
using BookingApp.BookingApp.API.Data.Entities;

namespace BookingApp.BookingApp.API.Repository
{
    public class RoomTypeRepository : IRoomTypeRepository
    {
        private readonly DataContext _dataContext;
        public RoomTypeRepository(DataContext dataContext){
            _dataContext = dataContext;
        }
        public IQueryable<RoomType> RoomTypes => _dataContext.RoomTypes;

        public IUnitOfWork UnitOfWork => (IUnitOfWork)_dataContext;

        public void Add(RoomType roomType)
        {
            _dataContext.RoomTypes.Add(roomType);
        }

        public void Delete(RoomType roomType)
        {
            _dataContext.Entry(roomType).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        public void Update(RoomType roomType)
        {
            _dataContext.Entry(roomType).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}