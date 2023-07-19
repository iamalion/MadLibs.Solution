using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Landing()
        {
            LandingPage myLandingPage = new LandingPage();
            return View(myLandingPage);
        }
        [HttpPost("/adventure-form")]
        public ActionResult AdventureForm() 
        {
            return View(); 
        }

        [HttpPost("/adventure-story")]
        public ActionResult AdventureStory(string animal, string animalName, string city, string adjectiveOne, string objectOne, string emotion, string pluralAnimal, string pluralNounOne, string pluralNounTwo, string numberOne, string occupation, string objectTwo, string numberTwo, string adjectiveTwo, string pluralNounThree)
        {
            MadLibsAdventure myMadLibsAdventure = new MadLibsAdventure();
            myMadLibsAdventure.Animal = animal;
            myMadLibsAdventure.AnimalName = animalName;
            myMadLibsAdventure.City = city;
            myMadLibsAdventure.AdjectiveOne = adjectiveOne;
            myMadLibsAdventure.ObjectOne = objectOne;
            myMadLibsAdventure.Emotion = emotion;
            myMadLibsAdventure.PluralAnimal = pluralAnimal;
            myMadLibsAdventure.PluralNounOne = pluralNounOne;
            myMadLibsAdventure.PluralNounTwo = pluralNounTwo;
            myMadLibsAdventure.NumberOne = numberOne;
            myMadLibsAdventure.Occupation = occupation;
            myMadLibsAdventure.ObjectTwo = objectTwo;
            myMadLibsAdventure.NumberTwo = numberTwo;
            myMadLibsAdventure.AdjectiveTwo = adjectiveTwo;
            myMadLibsAdventure.PluralNounThree = pluralNounThree;
            
            return View(myMadLibsAdventure);
        }

        [HttpPost("/magic-form")]
        public ActionResult MagicForm()
        {
            return View();
        }

        [HttpPost("/magic-story")]
        public ActionResult MagicStory(string animalName, string adjective, string animal, string talent, string residence, string objectOne, string creature, string pluralNoun, string element)
        {
            MadLibsMagic myMadLibsMagic = new MadLibsMagic();
            myMadLibsMagic.Adjective = adjective;
            myMadLibsMagic.Animal = animal;
            myMadLibsMagic.AnimalName = animalName;
            myMadLibsMagic.Talent = talent;
            myMadLibsMagic.Residence = residence;
            myMadLibsMagic.ObjectOne = objectOne;
            myMadLibsMagic.Creature = creature;
            myMadLibsMagic.PluralNoun = pluralNoun;
            myMadLibsMagic.Element = element;

            return View(myMadLibsMagic);
        }

            [HttpPost("/spooky-form")]
            public ActionResult SpookyForm()
        {
            return View();
        }
        [HttpPost("/spooky-story")]
        public ActionResult SpookyStory(string animalName, string timePeriod, string residence, string adjective, string creature, string color, string sound, string objectOne, string number, string hour, string emotion, string element ) 
    
        {
            MadLibsSpooky myMadLibsSpooky = new MadLibsSpooky();
            myMadLibsSpooky.AnimalName = animalName;
            myMadLibsSpooky.TimePeriod = timePeriod;
            myMadLibsSpooky.Residence = residence;
            myMadLibsSpooky.Adjective = adjective;
            myMadLibsSpooky.Creature = creature;
            myMadLibsSpooky.Color = color;
            myMadLibsSpooky.Sound = sound;
            myMadLibsSpooky.ObjectOne = objectOne;
            myMadLibsSpooky.Number = number;
            myMadLibsSpooky.Hour = hour;
            myMadLibsSpooky.Emotion = emotion;
            myMadLibsSpooky.Element = element;

            return View(myMadLibsSpooky);

        }
            
    }
}
