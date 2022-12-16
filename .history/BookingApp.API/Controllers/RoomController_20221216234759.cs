using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.BookingApp.API.Repository;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BookingApp.BookingApp.API.DTOs;
using BookingApp.BookingApp.API.Data.Entities;
using BookingApp.API.Data.Entities;
using BookingApp.BookingApp.API.Response;

namespace BookingApp.BookingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;
        private readonly IRoomTypeRepository _roomTypeRepository;

        public RoomController(IRoomRepository roomRepository, IRoomTypeRepository roomTypeRepository, IMapper mapper){
            _roomRepository = roomRepository;
            _roomTypeRepository = roomTypeRepository;
            _mapper = mapper;
        }

        [HttpPost("add-room")]
        public async Task<IActionResult> AddRoom([FromBody] RoomDto request, CancellationToken cancellationToken)
        {

            Room room = new Room();
            room.RoomTypeId = request.RoomTypesId;
            room.Default_Price = request.default_price;
            room.MaxGuest = request.max_guest;
            room.status = request.Status;
            room.Description = request.Description;
            _roomRepository.Add(room);
            var result = await _roomRepository.UnitOfWork.SaveAsync(cancellationToken);
            if(result == 0)
            {
                return BadRequest( new Response<ResponseDefault>()
                {
                    State = false,
                    Message = ErrorCode.ExcuteDB,
                    Result = new ResponseDefault()
                    {
                        Data = "Add product fail"
                    }
                });
            }

            return Ok( new Response<ResponseDefault>()
            {
                State = true,
                Message = ErrorCode.Success,
                Result = new ResponseDefault()
                {
                    Data = "Add Product success"
                }
            });

        }

        [HttpPut("update-room")]
        public async Task<IActionResult> UpdateRoom([FromBody] RoomDto roomDto )

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}