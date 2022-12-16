using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.BookingApp.API.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using BookingApp.API.Controllers;

namespace BookingApp.BookingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingRepository _bookingRepository;
        public BookingController(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        [HttpGet]
        public IActionResult GetAllBooking()
        {   
           try
           {
            return Ok(_bookingRepository.GetAllBooking());
           }
           catch
           {
             return StatusCode(StatusCodes.Status500InternalServerError);
           }
        }

        [HttpGet("{id}")]
        public IActionResult GetBookingById(int id)
        {
           try
           {
            var data = _bookingRepository.getBookingById(id);
            if(data == null){
                    return NotFound();
            }
                return Ok(data);
           }
           catch (System.Exception)
           {
            return StatusCode(StatusCodes.Status500InternalServerError);
           }
        }

        [HttpPost]
        public IActionResult CreateBooking(Booking b){
                try{
                    
                    return Ok( _bookingRepository.AddBooking(b));
                }
                catch{
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

        }
        

        

        [HttpPut("{id}")]
        public IActionResult UpdateBooking(int id,Booking b)
        {
            if(id != b.Id){
                return BadRequest();
            }
            try
            {
                _bookingRepository.UpdateBooking(b,id);
                return NoContent();
            }
            catch 
            {
                  return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBookingById(int id)
        {  
            try {
                    _bookingRepository.DeleteBooking(id);
                    return NoContent();
            }
            catch{
                 return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }
}