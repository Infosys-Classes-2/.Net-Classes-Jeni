using Microsoft.AspNetCore.Mvc;
using WebAssignment.Models;

namespace WebAssignment.Controllers;

public class EmployeeController : Controller
{
    //emploee/list
    //[Route("/list")] //to route index as list or you can directly use list instead of index
    // public IActionResult Index()
    //[HttpGet] //is default so dont have to write

    static List<Employee> employees = new()
        {
            new()
        {
            FirstName = "Ram",
            LastName = "Basnet",
            Designation = "Software Engineer",
            Level = 7,
            Department = "R&D1",
            JoinDate = DateTime.Now
        },

        new()
        {
            FirstName = "Jenny",
            LastName = "Maharjan",
            Designation = "Sr. Software Engineer",
            Level = 7,
            Department = "R&D1",
            JoinDate = DateTime.Now
        }
    };
    public IActionResult List()
    {
        /*    Employee employee1 = new()
            {
                FirstName = "Ram",
                LastName = "Basnet",
                Designation = "Software Engineer",
                Level = 7,
                Department = "R&D1",
                JoinDate = DateTime.Now
            };

            Employee employee2 = new()
            {
                FirstName = "Jenny",
                LastName = "Maharjan",
                Designation = "Sr. Software Engineer",
                Level = 7,
                Department = "R&D1",
                JoinDate = DateTime.Now
            };
            List<Employee> employee = new() { employee1, employee2 };*/
        return View(employees);
    }

        

   
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(Employee employee)
    {
        //Add to db
        // return RedirectToAction("List"); old method
        return RedirectToAction(nameof(List));  //it is inter-related to actionname if we change the action name it will show error in compile time
    }

    public IActionResult Edit(int ID)
    {
        var employee = employees.Where(x => x.id == ID).First();
        return View(employee);
    }
}
