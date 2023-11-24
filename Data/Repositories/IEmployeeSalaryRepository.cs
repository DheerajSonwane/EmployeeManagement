using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;

namespace EmployeeManagement.Data.Repositories
{
    public interface IEmployeeSalaryRepository
    {
        void AddSalary(EmployeeSalary salary);
        List<EmployeeSalary> GetEmployeeSalaries(int employeeId);
    }
}
