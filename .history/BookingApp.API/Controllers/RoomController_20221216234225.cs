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
            room.MaxGuest = request.

        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

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