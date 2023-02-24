using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Cellar.Models;

namespace Cellar.Controllers
{
  public class HomeController : Controller
  {

    private readonly CellarContext _db;
    public HomeController(CellarContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Wine> userItems = _db.Wines
                          .Where(wine => wine.Consumed == true)
                          .ToList();
      return View(userItems);
    }
  }
}