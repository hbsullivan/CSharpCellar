using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Cellar.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;


namespace Cellar.Controllers
{
  [Authorize]
  public class WinesController : Controller
  {
    private readonly CellarContext _db;
    private readonly UserManager<ApplicationUser> _userManager;


    public WinesController(UserManager<ApplicationUser> userManager,CellarContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index()
    {
      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      List<Wine> userItems = _db.Wines
                          .Where(entry => entry.User.Id == currentUser.Id)
                          .ToList();
      return View(userItems);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Wine wine)
    {
      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      wine.User = currentUser;
      _db.Wines.Add(wine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Wine thisWine = _db.Wines
                          .FirstOrDefault(wine => wine.WineId == id);
      return View(thisWine);
    }

    public ActionResult Edit(int id)
    {
      Wine thisWine = _db.Wines
                            .FirstOrDefault(wine => wine.WineId == id);
      return View(thisWine);
    }

    [HttpPost]
    public ActionResult Edit(Wine wine)
    {
      _db.Wines.Update(wine);
      _db.SaveChanges();
      return RedirectToAction("Index");
      
    }


    public ActionResult Delete(int id)
    {
      Wine thisWine = _db.Wines.FirstOrDefault(wines => wines.WineId == id);
      return View(thisWine);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Wine thisWine = _db.Wines.FirstOrDefault(wines => wines.WineId == id);
      _db.Wines.Remove(thisWine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Drink(int id)
    {
      Wine thisWine = _db.Wines
                            .FirstOrDefault(wines => wines.WineId == id);
      return View(thisWine);
    }

    [HttpPost]
    public ActionResult Drink(Wine wine)
    {
      _db.Wines.Update(wine);
      _db.SaveChanges();
      return RedirectToAction("Index");
      
    }
  }
}