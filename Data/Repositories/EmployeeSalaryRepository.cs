using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;

namespace EmployeeManagement.Data.Repositories
{
    public class EmployeeSalaryRepository: IEmployeeSalaryRepository
    {
        private readonly DataDbContext _dbContext;

        public EmployeeSalaryRepository(DataDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddSalary(EmployeeSalary salary)
        {
            _dbContext.EmployeeSalaries.Add(salary);
            _dbContext.SaveChanges();
        }

        public List<EmployeeSalary> GetEmployeeSalaries(int employeeId)
        {
            return _dbContext.EmployeeSalaries
                .Where(s => s.EmployeeId == employeeId)
                .ToList();
        }
    }
}
