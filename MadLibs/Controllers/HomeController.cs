using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Game game = new Game("test", "test2");
      return View(game);
    }

    [Route("/pirates")]
    public ActionResult Pirates()
    {
      return View();
    }

    [Route("/pirates/story")]
    public ActionResult PirateStory()
    {
      return View();
    }
  }
}