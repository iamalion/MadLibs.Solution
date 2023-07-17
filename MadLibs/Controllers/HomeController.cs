using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Landing()
        {
            LandingPage myLandingPage = new LandingPage();
            return View(myLandingPage);
        }
        [Route("/adventure-form")]
        public ActionResult AdventureForm() 
        {
            return View(); 
        }

        [Route("/adventure-story")]
        public ActionResult Story(string noun)
        {
            MadLibsAdventure myMadLibsAdventure = new MadLibsAdventure();
            myMadLibsAdventure.Animal = animal;
            return View(myMadLibsAdventure);
        }
    }
}