using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class ItemController : Controller
  {
    // Routes
    // [HttpGet(")]
    // [HttpPost("")]
    [HttpGet("/item/new")]
    public ActionResult New()
    {
      return View();
    }
    
    [HttpPost("/item")]
    public ActionResult Create(string description)
    {
      Item newItem = new Item(description);
      return RedirectToAction("Index");
    }

    [HttpGet("/item")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("item/{id}")]
    public ActionResult Show(int id)
    {
      Item foundItem = Item.Find(id);
      return View(foundItem);
    }

    [HttpGet("item/check")]
    public ActionResult CheckAll()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("item/{id}/edit")]
    public ActionResult Edit(int id)
    {
      Item foundItem = Item.Find(id);
      return View(foundItem);
    }

    [HttpPost("item/{id}")]
    public ActionResult Update(int id, string description)
    {
      Item foundItem = Item.Find(id);
      foundItem.Description = description;
      return RedirectToAction("Index");
    }
  }
}