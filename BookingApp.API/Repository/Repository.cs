using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.BookingApp.API.Data;

namespace BookingApp.BookingApp.API.Repository
{
    public class Repository<T>
    {
        private readonly DataContext _dataContext;
        public Repository(DataContext dataContext){
            _dataContext = dataContext;
        }
        public IUnitOfWork UnitOfWork => (IUnitOfWork)_dataContext;
    }
}