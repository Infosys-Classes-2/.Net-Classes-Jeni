using Microsoft.AspNetCore.Mvc;
using WebAssignment.Models;

namespace WebAssignment.Controllers;

public class EmploeesController : Controller
{
    //emploee/list
    //[Route("/list")] //to route index as list or you can directly use list instead of index
   // public IActionResult Index()
   public IActionResult List()
    {
        Employees employee1 = new()
        {
            FirstName = "Ram",
            LastName = "Basnet",
            Designation = "Software Engineer",
            Level = 7,
            Department = "R&D1",
            JoinDate = DateTime.Now
        };

        Employees employee2 = new()
        {
            FirstName = "Jenny",
            LastName = "Maharjan",
            Designation = "Sr. Software Engineer",
            Level = 7,
            Department = "R&D1",
            JoinDate = DateTime.Now
        };
        List<Employees> employees = new() { employee1, employee2 };

        return View(employees);

    }
}
