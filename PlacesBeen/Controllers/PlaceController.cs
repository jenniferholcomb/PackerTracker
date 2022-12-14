using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
    public ActionResult Create(string location, string companion, string dates, string journal, string image)
    {
      Place newPlace = new Place(location, companion, dates, journal, image);
      return RedirectToAction("Index");
    }

    [HttpGet("/place")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("place/{id}")]
    public ActionResult Show(int id)
    {
      Place foundPlace = Place.Find(id);
      return View(foundPlace);
    }

  }
}