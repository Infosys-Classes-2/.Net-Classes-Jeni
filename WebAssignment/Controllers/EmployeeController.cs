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

<<<<<<< HEAD
    //dependency injection(DI), built-in
    private readonly EmployeContext db;
    
    public EmployeeController(EmployeContext _db)
=======
    static List<Employee> employees = new()
        {
            new()
        {
            id = 1,
            FirstName = "Ram",
            LastName = "Basnet",
            Designation = "Software Engineer",
            Level = 7,
            Department = "R&D1",
            JoinDate = DateTime.Now
        },

        new()
        {
            id=2,
            FirstName = "Jenny",
            LastName = "Maharjan",
            Designation = "Sr. Software Engineer",
            Level = 7,
            Department = "R&D1",
            JoinDate = DateTime.Now
        }
    };
    public IActionResult List()
>>>>>>> ca00f4868214712eaccc817761d50009b5a89428
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

    [HttpPost]
    public IActionResult Edit(Employee employee)
    {
        //Add to db
        //  EmployeContext db = new();
        db.Employees.Update(employee);
        db.SaveChanges();
        return RedirectToAction(nameof(List));

    }
    [HttpGet]
    public IActionResult Delete(int ID)
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
<<<<<<< HEAD
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

            SqlCommand command = new(queryString, connection);

            // Open the connection i

            // Open the connection in a try/catch block.
            // Create and execute the DataReader, writing the result
            // set to the console window.
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}",
                        reader[0], reader[1], reader[2]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
=======
        return View();
    }
    [HttpPost]
    public IActionResult Add(Employee employee)
    {
        //Add to db
        // return RedirectToAction("List"); old method
       
        return RedirectToAction(nameof(List));  //it is inter-related to actionname if we change the action name it will show error in compile time
    }
    [HttpGet]
    public IActionResult Edit(int ID)
    {
        var employee = employees.Where(x => x.id == ID).First();
        return View(employee);
>>>>>>> ca00f4868214712eaccc817761d50009b5a89428
    }

    [HttpPost]
    public IActionResult Edit(Employee employee)
    {
        //Add to db
        // return RedirectToAction("List"); old method
        return RedirectToAction(nameof(List));  //it is inter-related to actionname if we change the action name it will show error in compile time
    }
}
