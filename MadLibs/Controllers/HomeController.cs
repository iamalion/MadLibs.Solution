using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Landing()
        {
            MadLibsVariable myMadLibsVariable = new MadLibsVariable();
            myMadLibsVariable.Noun = "cat";
            return View(myMadLibsVariable);
        }
        [Route("/form")]
        public ActionResult Form() 
        {
            return View(); 
        }

        [Route("/story")]
        public ActionResult Story(string noun)
        {
            MadLibsVariable myMadLibsVariable = new MadLibsVariable();
            myMadLibsVariable.Noun = noun;
            return View(myMadLibsVariable);
        }
    }
}