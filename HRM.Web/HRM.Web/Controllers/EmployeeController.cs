using Microsoft.AspNetCore.Mvc;
using HRM.Web.Models;
using System.Data.OleDb;
using Microsoft.Data.SqlClient;
using HRM.Web.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System.Data.Common;
using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HRM.Web.Controllers;

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
        var employees = await db.Employees.Include(x => x.Department).Include(y=>y.Designation).ToListAsync();
       // var queryEmployees = from employee in employees
       //                      join dept in db.Departments on employee.DepartmentId equals dept.Id
        //                     select new
        //                     {
       //                          Name = employee.FirstName,
         //                        Department=dept.Name
//                             };
        return View(employees);
    }

}
