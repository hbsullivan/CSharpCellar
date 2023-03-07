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
    public async Task<IActionResult> Index(string searchName)
    {
    var wines = from m in _db.Wines
          select m;
      if (!String.IsNullOrEmpty(searchName))
      {
        wines = wines.Where(s => s.Producer!.Contains(searchName));
        return View(await wines);
      }
      List<Wine> userItems = _db.Wines
                          .Where(wine => wine.Consumed == true)
                          .ToList();
      return View(userItems);
    }
  }
}