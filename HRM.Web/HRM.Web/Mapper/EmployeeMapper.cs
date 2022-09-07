using HRM.Web.Models;
using HRM.Web.ViewModels;

namespace HRM.Web.Mapper
{
    public static class EmployeeMapper
    {
        public static EmployeeViewModel ToViewModel(this Employee employee)
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();         

            employeeViewModel.FirstName = employee.FirstName;
            employeeViewModel.LastName = employee.LastName;
            employeeViewModel.Level = employee.Level;
            employeeViewModel.DepartmentName = employee.Department.Name;
            employeeViewModel.DesignationName = employee.Designation.title;
            employeeViewModel.ProfileImage = employee.ProfileImage;
            

            return employeeViewModel;
        }

        public List<EmployeeViewModel>ToViewModel(List<Employee> employees)
        { 
            var employeeViewModelList = new List<EmployeeViewModel>();
            return employeeViewModelList;
        }
    }

}
