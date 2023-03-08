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
    public ActionResult Index(string searchBy, string search, bool sort)
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
                            .Where(wine => wine.Consumed == true && wine.Vintage.Contains(search))
                            .ToList();
        return View(userItems);
      }
      else if(searchBy == "Origin")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Origin.Contains(search))
                            .ToList();
        return View(userItems);
      }
      else if(searchBy == "Producer")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Producer.Contains(search))
                            .ToList();
        return View(userItems);
      }
      else if(searchBy == "Price")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Price.Contains(search))
                            .ToList();
        return View(userItems);
      }
      else if(searchBy == "Location")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Location.Contains(search))
                            .ToList();
        return View(userItems);
      }
      else if(searchBy == "Rating")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Rating.Contains(search))
                            .ToList();
        return View(userItems);
      }
      else if(searchBy == "Description")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Description.Contains(search))
                            .ToList();
        return View(userItems);
      }
      else if (sort) {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true)
                            .OrderByDescending(wine => wine.Price)
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