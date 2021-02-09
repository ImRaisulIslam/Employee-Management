using System.Collections.Generic;

namespace EmployeeManagementPractice.Models
{
    public interface IEmployeeRepository
    {
        EmployeeModel GetEmployee(int Id);
        IEnumerable<EmployeeModel> GetAllEmployee();
        EmployeeModel AddEmployee(EmployeeModel addEmployee);
        EmployeeModel UpdateEmployee(EmployeeModel updateEmplyee);
        EmployeeModel DeleteEmployee(int Id);
    }
}