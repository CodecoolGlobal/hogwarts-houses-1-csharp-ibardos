using Microsoft.AspNetCore.Mvc;

namespace HogwartsHouses.Controllers;

[ApiController, Route("[controller]")]
public class RoomsController : ControllerBase
{
    [HttpGet]
    public string GetRooms()
    {
        return "This is rooms API route.";
    }
}