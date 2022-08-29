using Microsoft.EntityFrameworkCore;
using WebAssignment.Models;

namespace WebAssignment.Data
{
    public class EmployeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmployeeDb;Integrated Security=True;");
        }
        public DbSet<Employee> Employees { get; set; } //table name will be created on db EmployeeContext
    }
}
