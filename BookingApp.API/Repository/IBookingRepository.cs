using BookingApp.BookingApp.API.Data.Entities;
namespace BookingApp.API.Repository
{
    public interface IBookingRepository {
    List<Booking> GetAllBooking();
       Booking  getBookingById(int id);
        Booking AddBooking(Booking b);
        void UpdateBooking(Booking b,int id);
        void DeleteBooking(int id);
    }
}