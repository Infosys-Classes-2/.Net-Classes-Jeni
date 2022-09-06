﻿using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace HRM.Web.Models;

public class Employee
{
    public int id { get; set; }
    //add attribute for custome  message -- data annodation
    [Required(ErrorMessage = "Please Insert First Name")]
    [Display(Name="Your First Name" )]

    public string FirstName { get; set; }
    public string LastName { get; set; }
       public byte Level { get; set; }
    public DateTime JoinDate { get; set; }

    public byte[] Avatar { get; set; }
    //One employee has only one designationsingle designation can be for multiple employees
    public int DesignationId { get; set; }
    public Designation Designation { get; set; }
    //one employee has only one department, department has multiple employees
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}

