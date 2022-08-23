using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAssignment.Models;

namespace WebAssignment.Controllers
{
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
}