using System.Collections.Generic;
using System.Linq;
using HogwartsHouses.Models;
using HogwartsHouses.Models.Types;
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

    [HttpGet]
    [Route("available")]
    public ActionResult<HashSet<Room>> GetAvailableRooms()
    {
        HashSet<Room> rooms = _roomService.GetAllRooms();

        return rooms.Where(room => room.IsOccupied == false).Select(room => room).ToHashSet();
    }

    [HttpGet]
    [Route("rat-owners")]
    public ActionResult<HashSet<Room>> GetAvailableRoomsForRatOwners()
    {
        HashSet<Room> rooms = _roomService.GetAllRooms();

        return rooms
            .Where(room => room.IsOccupied == false)
            .Where(room => !room.PetsInRoom.Contains(PetType.Cat))
            .Where(room => !room.PetsInRoom.Contains(PetType.Owl))
            .Select(room => room).ToHashSet();
    }
}