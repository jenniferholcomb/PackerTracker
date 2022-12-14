using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;

namespace PlacesBeen.Controllers
{
  public class HomeController : Controller
  {
    // Routes
    // [HttpGet(")]
    // [HttpPost("")]
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}