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
  }
}