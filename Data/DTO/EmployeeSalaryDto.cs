using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;

namespace EmployeeManagement.Data.Repositories
{
    public class EmployeeSalaryDto
    {
        public int Id { get; set; }
        public DateTime SalaryDate { get; set; }
        public decimal Amount { get; set; }
    }
}
