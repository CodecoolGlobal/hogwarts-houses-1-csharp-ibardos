using HogwartsHouses.Services;
using HogwartsHouses.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HogwartsHouses.Controllers;

public class RoomsController : Controller
{
    private IRoomService _roomService;

    public RoomsController(IRoomService roomService)
    {
        _roomService = roomService;
    }

    // GET
    public IActionResult Rooms()
    {
        return View(_roomService.GetAllRooms());
    }
}