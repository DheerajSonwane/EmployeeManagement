using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
// EmployeeRepository.cs
namespace EmployeeManagement.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataDbContext _dbContext;

        public EmployeeRepository(DataDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
        }

        public void UpdateEmployee(Employee updatedEmployee)
        {
            // Find the existing employee in the database and update its properties
            var existingEmployee = _dbContext.Employees.Find(updatedEmployee.Id);

            if (existingEmployee != null)
            {
                existingEmployee.FirstName = updatedEmployee.FirstName;
                existingEmployee.LastName = updatedEmployee.LastName;
                existingEmployee.City = updatedEmployee.City;
                existingEmployee.Zip = updatedEmployee.Zip;
                // Update other properties as needed

                _dbContext.SaveChanges(); // Save changes to the database
            }
            else
            {
                // Handle the case where the employee is not found
                throw new InvalidOperationException("Employee not found");
            }
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return _dbContext.Employees.Find(employeeId);
        }

        public List<Employee> GetAllEmployees()
        {
            return _dbContext.Employees.ToList();
        }
    }
}
