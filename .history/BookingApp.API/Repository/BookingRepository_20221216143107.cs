using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.BookingApp.API.Data;
using BookingApp.BookingApp.API.Data.Entities;
namespace nam
{
    class BookingRepository : IBookingRepository
    {
        private readonly DataContext _context;
        public BookingRepository(DataContext context)
        {
            _context = context;
        }

        public Booking AddBooking(Booking b)
        {
            var booking = new Booking{
               Id  = b.Id,
               CustomerId = b.CustomerId,
               Create = b.Create,
               CheckIn = b.CheckIn,
               CheckOut = b.CheckOut,
               Canceled = b.Canceled,
               CouponId = b.CouponId
            };
            _context.Add(booking);
            _context.SaveChanges();
            return booking;
        }

        public void DeleteBooking(int id)
        {
            var bookingDelete = _context.bookings.SingleOrDefault(b => b.Id == id);
            if(bookingDelete != null){
                _context.Remove(bookingDelete);
                _context.SaveChanges();
            }
        }

        public List<Booking> GetAllBooking()
        {
           var listBooking = _context.bookings.ToList();
           return listBooking;
        }

        public Booking getBookingById(int id)
        {
            var bookingById = (from b in _context.bookings where id == b.Id select b).SingleOrDefault();
            return bookingById;
        }

        public void UpdateBooking(Booking b,int id)
        {
             var bookingUpdate = _context.bookings.SingleOrDefault(b => b.Id == id);
             bookingUpdate.Create = b.Create;
             bookingUpdate.Canceled = b.Canceled;
             bookingUpdate.CheckIn = b.CheckIn;
            bookingUpdate.CheckOut = b.CheckOut;
            _context.SaveChanges();
        }
    }


}