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

    [Route("/unicorns")]
    public ActionResult Unicorns()
    {
      return View();
    }

    [Route("/unicorns/story")]
    public ActionResult UnicornStory(string pluralnoun, string adjective, string pluralnoun2, string pluralnoun3, string adjective2, string adjective3,
      string adjective4, string noun, string pluralnoun4, string adjective5, string verb, string pluralnoun5, string verb2, string verb3,
      string noun2, string adjective6)
    {
      string[] nouns = new string[] { noun, noun2 };
      string[] verbs = new string[] { verb, verb2, verb3 };
      string[] adjectives = new string[] { adjective, adjective2, adjective3, adjective4, adjective5, adjective6 };
      string[] pluralNouns = new string[] { pluralnoun, pluralnoun2, pluralnoun3, pluralnoun4, pluralnoun5 };
      Game unicorn = new Game(nouns, verbs, adjectives, pluralNouns);
      return View(unicorn);
    }
  }
}