namespace WebAssignment.Models;

public class Employee
{
    public int id { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }
       public byte Level { get; set; }
    public DateTime JoinDate { get; set; }
    public int DesignationId { get; set; }
    public Designation Designation { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}


