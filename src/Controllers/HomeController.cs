using Microsoft.AspNetCore.Mvc;

namespace HogwartsHouses.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}