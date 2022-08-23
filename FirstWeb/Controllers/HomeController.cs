using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstWeb.Models;

namespace FirstWeb.Controllers;

public class HomeController : Controller
{
      public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

 
}
