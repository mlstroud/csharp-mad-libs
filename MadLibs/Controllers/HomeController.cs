using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }

    [Route("/pirates")]
    public ActionResult Pirates()
    {
      return View();
    }

    [Route("/pirates/story")]
    public ActionResult PirateStory(string noun, string adjective, string verb, string pluralnoun)
    {

      Game pirate = new Game(new string[] { noun }, new string[] { verb }, new string[] { adjective }, new string[] { pluralnoun });
      return View(pirate);
    }
  }
}