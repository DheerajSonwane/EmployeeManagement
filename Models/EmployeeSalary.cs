using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class EmployeeSalary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime SalaryDate { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
