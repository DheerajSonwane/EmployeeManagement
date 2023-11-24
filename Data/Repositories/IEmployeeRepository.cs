using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;

namespace EmployeeManagement.Data.Repositories
{
    public interface IEmployeeRepository
    {
        void AddEmployee(Employee employee);
        Employee GetEmployeeById(int employeeId);
        List<Employee> GetAllEmployees();
        void UpdateEmployee(Employee updatedEmployee);
    }
}
