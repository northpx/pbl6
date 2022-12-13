using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.BookingApp.API.Repository
{
    public interface IRepository<T> where T:class
    {
        IUnitOfWork UnitOfWork {get;}
    }
}