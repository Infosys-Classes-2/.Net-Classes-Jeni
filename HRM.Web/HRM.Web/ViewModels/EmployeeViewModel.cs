using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace HRM.Web.ViewModels;

public class EmployeeViewModel
{
    public int id { get; set; }
    //add attribute for custome  message -- data annodation

    [Required(ErrorMessage = "Please Insert First Name")]

    [Display(Name="Your First Name" )]

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public byte Level { get; set; }
    public DateTime JoinDate { get; set; }
    public IFormFile Avatar { get; set; }
    public string? ProfileImage { get; set; }
    public string DesignationId { get; set; }
    public string DesignationName { get; set; }
    public string DepartmentID { get; set; }
    public string DepartmentName { get; set; }
}


