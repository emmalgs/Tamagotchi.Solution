using Microsoft.AspNetCore.Mvc;
// using Tamagotchi.Models;
// using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}