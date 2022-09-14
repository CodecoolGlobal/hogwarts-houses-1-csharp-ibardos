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
    public HashSet<Room> GetAllRooms()
    {
        return _roomService.GetAllRooms();
    }

    [HttpPost]
    public IActionResult AddRoom()
    {
        Room roomToAdd = new();
        _roomService.AddRoom(roomToAdd);

        return CreatedAtAction(nameof(AddRoom), roomToAdd);
    }
}