using System.Collections.Generic;
using HogwartsHouses.Models;
using HogwartsHouses.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HogwartsHouses.Controllers;

[ApiController, Route("api/rooms")]
public class ApiRoomsController : ControllerBase
{
    private IRoomService _roomService;

    public ApiRoomsController(IRoomService roomService)
    {
        _roomService = roomService;
    }

    [HttpGet]
    public ActionResult<HashSet<Room>> GetAllRooms()
    {
        return _roomService.GetAllRooms();
    }

    [HttpPost]
    public ActionResult AddRoom()
    {
        Room roomToAdd = new();
        _roomService.AddRoom(roomToAdd);

        return CreatedAtAction(nameof(AddRoom), roomToAdd);
    }

    [HttpGet("{id}")]
    public ActionResult<Room> GetRoomById(int id)
    {
        Room room = _roomService.GetRoomById(id);

        if (room is null)
        {
            return NotFound("Room with the defined ID does not exist.");
        }

        return room;
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteRoomById(int id)
    {
        Room room = _roomService.GetRoomById(id);
        
        if (room is null)
        {
            return NotFound("Room with the defined ID does not exist.");
        }

        _roomService.DeleteRoomById(id);

        return NoContent();
    }

    [HttpPut("{id}")]
    public ActionResult UpdateRoomById(int id, [FromBody] Room room)
    {
        if (id != room.Id)
        {
            return BadRequest();
        }

        Room roomToUpdate = _roomService.GetRoomById(id);
        if (roomToUpdate is null)
        {
            return NotFound("Room with the defined ID does not exist.");
        }

        _roomService.UpdateRoom(id, room);

        return NoContent();
    }
}