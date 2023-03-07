using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Cellar.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

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
    public ActionResult Index(string searchBy, string search)
    {
      if (search == null)
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true)
                            .ToList();
        return View(userItems);
      }
      else if(searchBy == "Vintage")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Vintage == search)
                            .ToList();
        return View(userItems);
      }
      else if(searchBy == "Origin")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Origin == search)
                            .ToList();
        return View(userItems);
      }
      else if(searchBy == "Producer")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Producer == search)
                            .ToList();
        return View(userItems);
      }
      else if(searchBy == "Price")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Price == search)
                            .ToList();
        return View(userItems);
      }
      else if(searchBy == "Location")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Location == search)
                            .ToList();
        return View(userItems);
      }
      else if(searchBy == "Rating")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Rating == search)
                            .ToList();
        return View(userItems);
      }
      else
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true)
                            .ToList();
        return View(userItems);
      }

    }
  }
}