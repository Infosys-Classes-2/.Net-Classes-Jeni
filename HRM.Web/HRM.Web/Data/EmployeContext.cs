using Microsoft.EntityFrameworkCore;
using HRM.Web.Models;

namespace HRM.Web.Data
{
    public class EmployeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRMDb;Integrated Security=True;");
        }
        public DbSet<EmployeeViewModel> Employees { get; set; } //table name will be created on db EmployeeContext
        public DbSet<Department>Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
    }
}
