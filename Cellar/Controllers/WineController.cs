using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Cellar.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using CellarClient.Models;


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

    public async Task<ActionResult> Index(string searchBy, string search)
    {
      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);

      if (search == null)
        {
          List<Wine> userItems = _db.Wines
                              .Where(entry => entry.User.Id == currentUser.Id)
                              .Where(wine => wine.Consumed == false)
                              .ToList();
          return View(userItems);
        } 
        else if(searchBy == "Vintage") 
        {
          List<Wine> userItems = _db.Wines
                              .Where(entry => entry.User.Id == currentUser.Id)
                              .Where(wine => wine.Consumed == false && wine.Vintage.Contains(search))
                              .ToList();
          return View(userItems);
        } 
        else if(searchBy == "Origin") 
        {
          List<Wine> userItems = _db.Wines
                              .Where(entry => entry.User.Id == currentUser.Id)
                              .Where(wine => wine.Consumed == false && wine.Origin.Contains(search))
                              .ToList();
          return View(userItems);
        } 
        else if(searchBy == "Producer") 
        {
          List<Wine> userItems = _db.Wines
                              .Where(entry => entry.User.Id == currentUser.Id)
                              .Where(wine => wine.Consumed == false && wine.Producer.Contains(search))
                              .ToList();
          return View(userItems);
        } 
        else if(searchBy == "Price") 
        {
          List<Wine> userItems = _db.Wines
                              .Where(entry => entry.User.Id == currentUser.Id)
                              .Where(wine => wine.Consumed == false && wine.Price.Contains(search))
                              .ToList();
          return View(userItems);
        } 
        else if(searchBy == "Location") 
        {
          List<Wine> userItems = _db.Wines
                              .Where(entry => entry.User.Id == currentUser.Id)
                              .Where(wine => wine.Consumed == false && wine.Location.Contains(search))
                              .ToList();
          return View(userItems);
        } 
        else if(searchBy == "Description") 
        {
          List<Wine> userItems = _db.Wines
                              .Where(entry => entry.User.Id == currentUser.Id)
                              .Where(wine => wine.Consumed == false && wine.Description.Contains(search))
                              .ToList();
          return View(userItems);
        } 
        else 
        {
          List<Wine> userItems = _db.Wines
                              .Where(entry => entry.User.Id == currentUser.Id)
                              .Where(wine => wine.Consumed == false)
                              .ToList();
          return View(userItems);
        }
    }
    public async Task<ActionResult> Consumed()
    {
      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      List<Wine> userItems = _db.Wines
                          .Where(entry => entry.User.Id == currentUser.Id)
                          .Where(wine => wine.Consumed == true)
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
    public ActionResult DetailsTwo(int id)
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

    public IActionResult Education() 
    {
      List<Region> regions = Region.GetRegions();
      return View(regions);
    }

  public IActionResult RegionDetails(int id)
  {
    Region region = Region.GetDetails(id);
    return View(region);
  }
  }
}