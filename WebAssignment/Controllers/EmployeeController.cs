using Microsoft.AspNetCore.Mvc;
using WebAssignment.Models;
using System.Data.OleDb;
using Microsoft.Data.SqlClient;
using WebAssignment.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System.Data.Common;
using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebAssignment.Controllers;

public class EmployeeController : Controller
{
    //Tightly coupled code
    //EmployeContext db = new();

    //dependency injection(DI), built-in
    private readonly EmployeContext db;
    
    public EmployeeController(EmployeContext _db)
    {
        this.db = _db;
    }
    [HttpGet]
    public async Task<IActionResult>Add()
    {
        var departments= await db.Departments.ToListAsync();
        ViewData["Departments"] = departments.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString()
        });
        
        var designation = await db.Designations.ToListAsync();
        ViewData["Designations"] = designation.Select(x => new SelectListItem()
        {
            Text = x.title,
            Value = x.Id.ToString()
        });
        return View();

    }
    [HttpPost]
    public async Task<IActionResult>Add(Employee employee)
    {
        //Add to db
        //  EmployeContext db = new();
        await db.Employees.AddAsync(employee);
        await db.SaveChangesAsync();
              //db.Employees.Add(employee);
        //db.SaveChanges();
        return RedirectToAction(nameof(List));
        
    }

     public IActionResult Edit(int ID)
     {
        var employee = db.Employees.Find(ID);
     return View(employee);
      }

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
        var employee = db.Employees.Find(ID);
        return View(employee);
    }

    [HttpPost]
    public IActionResult Delete(Employee employee)
    {
        db.Employees.Remove(employee);
        db.SaveChanges();
        return RedirectToAction(nameof(List));

    }
    //using async wait
    public async Task<IActionResult> List()
    {
        //var employees = await db.Employees.ToListAsync();
        var employees = await db.Employees.Include(x => x.Department).ToListAsync();
       // var queryEmployees = from employee in employees
       //                      join dept in db.Departments on employee.DepartmentId equals dept.Id
        //                     select new
        //                     {
       //                          Name = employee.FirstName,
         //                        Department=dept.Name
//                             };
        return View(employees);
    }


    public void GetPeople()
    {
        //using ADO.NET
        string connectionString =
        @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=True";//Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Provide the query string with a parameter placeholder.
        string queryString =
            "SELECT * from Person ";

        // Create and open the connection in a using block. This
        // ensures that all resources will be closed and disposed
        // when the code exits.
        using (SqlConnection connection = new(connectionString))
        {

   
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

    [HttpPost]
    public IActionResult Edit(Employee employee)
    {
        //Add to db
        // return RedirectToAction("List"); old method
        return RedirectToAction(nameof(List));  //it is inter-related to actionname if we change the action name it will show error in compile time
    }
}
