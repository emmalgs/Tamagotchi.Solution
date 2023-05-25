using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;
using System.Linq;

namespace Tamagotchi.Controllers
{
  public class PetsController : Controller
  {
    private readonly TamagotchiContext _db;
    public PetsController(TamagotchiContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Pets.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    // [HttpPost]
    // public ActionResult Index()
    // {
    //   return View();
    // }
    
    public ActionResult Details(int id)
    {
      return View();
    }

    // [HttpPost]
    // public ActionResult Details(Pet pet)
    // {
    //   Pet foundPet = Pet.Find(petId);
    //   if (action == "feed")
    //   {
    //     foundPet.Feed();
    //   }
    //   else if(action == "play")
    //   {
    //     foundPet.Play();
    //   }
    //   else
    //   {
    //     foundPet.Sleep();
    //   }
    //   return View();
    // }


    [HttpPost]
    public ActionResult DeleteAll()
    {
      return View();
    }
  }
}