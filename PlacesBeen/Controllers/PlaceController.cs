using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;

namespace PlacesBeen.Controllers
{
  public class PlacesController : Controller
  {
    // Routes
    // [HttpGet(")]
    // [HttpPost("")]
    [HttpGet("/place/new")]
    public ActionResult New()
    {
      return View();
    }
    
    [HttpPost("/place")]
    public ActionResult Create(string location)
    {
      Place newPlace = new Place(location);
      return RedirectToAction("Index");
    }

    [HttpGet("/place")]
    public ActionResult Index()
    {
      return View();
    }

  }
}