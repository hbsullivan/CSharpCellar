using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Cellar.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System;
using PagedList;

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
    public ActionResult Index(string searchBy, string search, string sortBy, int? page)
    {

      int pageSize = 3;
      int pageNumber = (page ?? 1);
      if (search == null)
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true)
                            .ToList();
        return View(userItems.ToPagedList(pageNumber, pageSize));
      }
      else if(searchBy == "Vintage")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Vintage.Contains(search))
                            .ToList();
        return View(userItems.ToPagedList(pageNumber, pageSize));
      }
      else if(searchBy == "Origin")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Origin.Contains(search))
                            .ToList();
        return View(userItems.ToPagedList(pageNumber, pageSize));
      }
      else if(searchBy == "Producer")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Producer.Contains(search))
                            .ToList();
        return View(userItems.ToPagedList(pageNumber, pageSize));
      }
      else if(searchBy == "Price")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Price.Contains(search))
                            .ToList();
        return View(userItems.ToPagedList(pageNumber, pageSize));
      }
      else if(searchBy == "Location")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Location.Contains(search))
                            .ToList();
        return View(userItems.ToPagedList(pageNumber, pageSize));
      }
      else if(searchBy == "Rating")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Rating.Contains(search))
                            .ToList();
        return View(userItems.ToPagedList(pageNumber, pageSize));
      }
      else if(searchBy == "Description")
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true && wine.Description.Contains(search))
                            .ToList();
        return View(userItems.ToPagedList(pageNumber, pageSize));
      }
      // else if (sortBy == "LowToHigh") {
      //   List<Wine> userItems = _db.Wines
      //                       .Where(wine => wine.Consumed == true)                     
      //                       .OrderBy(wine => int.Parse(wine.Price))
      //                       .ToList();
      //   return View(userItems);
      // }
      // else if (sortBy == "HighToLow") {
      //   List<Wine> userItems = _db.Wines
      //                       .Where(wine => wine.Consumed == true)
      //                       .OrderByDescending(wine => int.Parse(wine.Price))
      //                       .ToList();
      //   return View(userItems);
      // }
      else
      {
        List<Wine> userItems = _db.Wines
                            .Where(wine => wine.Consumed == true)
                            .ToList();
        return View(userItems.ToPagedList(pageNumber, pageSize));
      }


    }
  }
}