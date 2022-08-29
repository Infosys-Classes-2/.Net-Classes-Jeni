using Microsoft.AspNetCore.Mvc;
using WebAssignment.Models;
using System.Data.OleDb;
using Microsoft.Data.SqlClient;

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
    }
}
