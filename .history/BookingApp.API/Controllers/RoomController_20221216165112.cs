using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.BookingApp.API.Repository;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BookingApp.BookingApp.API.DTOs;
using BookingApp.API.Data.Entities;

namespace BookingApp.BookingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;
        private readonly Iroo
        [HttpPost("add-room")]
        public async Task<IActionResult> AddRoom([FromBody] RoomDto request, CancellationToken cancellationToken)
        {
            var roomType = _
            Room room = new Room();
            room.RoomTypeId = roo
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