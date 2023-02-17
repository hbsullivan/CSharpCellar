using Microsoft.AspNetCore.Mvc;

namespace Cellar.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}