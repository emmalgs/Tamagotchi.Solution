using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class PetsController : Controller
  {
    [HttpGet("/pets")]
    public ActionResult Index()
    {
      return View(Pet.AllPets);
    }

    [HttpGet("/pets/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/pets")]
    public ActionResult Index(string[] info)
    {
      if (info[0] == "cat")
      {
        Cat newCat = new Cat(info[1]);
      }
      else if (info[0] == "dog")
      {
        Dog newDog = new Dog(info[1]);
      }
      else
      {
        Small newSmall = new Small(info[1]);
      }
      return View(Pet.AllPets);
    }
    
    [HttpGet("/pets/{id}")]
    public ActionResult Show(int id)
    {
      Pet foundPet = Pet.Find(id);
      return View(foundPet);
    }

    [HttpPost("/pets/{id}")]
    public ActionResult Show(int petId, string action)
    {
      Pet foundPet = Pet.Find(petId);
      if (action == "feed")
      {
        foundPet.Feed();
      }
      else if(action == "play")
      {
        foundPet.Play();
      }
      else
      {
        foundPet.Sleep();
      }
      return View(foundPet);
    }
  }
}