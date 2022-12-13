using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.BookingApp.API.Data.Entities;
using BookingApp.BookingApp.API.DTOs;
using BookingApp.BookingApp.API.Repository;
using BookingApp.BookingApp.API.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookingApp.BookingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeRepository _roomTypeRepository;
        public RoomTypeController(IRoomTypeRepository roomTypeRepository){
            _roomTypeRepository = roomTypeRepository;
        }
        [HttpPost("add-roomtype")]
        public async Task<IActionResult> AddRoomType([FromBody] RoomTypeDto request,CancellationToken cancellationToken){
            RoomType roomType = new RoomType();
            roomType.Name = request.Name;
            _roomTypeRepository.Add(roomType);
            var result = await _roomTypeRepository.UnitOfWork.SaveAsync(cancellationToken);
            if(result>0){
                return Ok(new Response<ResponseDefault>(){
                    State = true,
                    Message = ErrorCode.Success,
                    Result = new ResponseDefault(){
                        Data = roomType.Id.ToString()
                    }
                });
            }
            return BadRequest(new Response<ResponseDefault>(){
                State = false,
                Message = ErrorCode.ExcuteDB,
                Result = new ResponseDefault(){
                    Data = "Excute Db error"
                }
            });
        }
        [HttpPut("update-roomtype")]
        public async Task<IActionResult> UpdateRoomType([FromBody] RoomTypeDto request, CancellationToken cancellationToken){
            RoomType roomType = _roomTypeRepository.RoomTypes.FirstOrDefault(r =>r.Id == request.Id);
            if (roomType == null){
                return BadRequest(new Response<ResponseDefault>(){
                State = false,
                Message = ErrorCode.NotFound,
                Result = new ResponseDefault(){
                    Data = "Update roomtype fail"
                    }
                });
            }
            roomType.Name = request.Name;
            _roomTypeRepository.Update(roomType);
            var result = await _roomTypeRepository.UnitOfWork.SaveAsync(cancellationToken);
            if (result>0){
                return Ok(new Response<ResponseDefault>(){
                    State = true,
                    Message = ErrorCode.Success,
                    Result = new ResponseDefault(){
                        Data = roomType.Id.ToString()
                    }
                });
            }
            return BadRequest(new Response<ResponseDefault>(){
                State = false,
                Message = ErrorCode.ExcuteDB,
                Result = new ResponseDefault(){
                    Data = "Update roomtype fail"
                }
            });
        }
        [HttpDelete("delete-roomtype/{id}")]
        public async Task<IActionResult> DeleteRoomType(int id){
            RoomType roomType = _roomTypeRepository.RoomTypes.FirstOrDefault(r => r.Id == id);
            if(roomType == null){
                return BadRequest(new Response<ResponseDefault>(){
                    State = false,
                    Message = ErrorCode.NotFound,
                    Result = new ResponseDefault(){
                        Data = "Delete roomtpye fail"
                    }
                });
            }
            _roomTypeRepository.Delete(roomType);
            var result = await _roomTypeRepository.UnitOfWork.SaveAsync();
            if(result>0){
                return Ok(new Response<ResponseDefault>(){
                    State = true,
                    Message = ErrorCode.Success,
                    Result = new ResponseDefault(){
                        Data = roomType.Id.ToString()
                    }
                });
            }
            return BadRequest(new Response<ResponseDefault>(){
                State = false,
                Message = ErrorCode.ExcuteDB,
                Result = new ResponseDefault(){
                    Data = "Delete roomtype fail"
                }
            });
        }
        [HttpGet("list-roomtype"), Authorize]
        public async Task<IActionResult> GetAllRoomType(){
            var categories = await _roomTypeRepository.RoomTypes.Select(x => new Room {Id = x.Id, Name = x.Name}).ToListAsync();

            return Ok( new Response<ResponseDefault>()
            {
                State = true,
                Message = ErrorCode.Success,
                Result = new ResponseDefault()
                {
                    Data = categories
                }
            })
        }
    }
}