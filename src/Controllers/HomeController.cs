using Microsoft.AspNetCore.Mvc;

namespace HogwartsHouses.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult PostmanJsonInfo()
    {
        return View();
    }

    // GET - returning JSON object of Postman Collection
    public ActionResult<string> PostmanJson()
    {
        string json = System.IO.File.ReadAllText("./Data/HogwartsHouses.postman_collection.json");

        return json;
    }
}