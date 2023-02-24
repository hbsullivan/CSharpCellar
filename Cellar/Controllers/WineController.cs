using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Cellar.Models;
using System.Collections.Generic;

namespace Cellar.Controllers
{
  public class WinesController : Controller
  {
    private readonly CellarContext _db;

    public WinesController(CellarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Wine> model = _db.Wines.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Wine wine)
    {
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