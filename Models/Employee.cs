using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(100, ErrorMessage = "First name must not exceed 100 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(100, ErrorMessage = "Last name must not exceed 100 characters.")]
        public string LastName { get; set; }

        [StringLength(100, ErrorMessage = "City must not exceed 100 characters.")]
        public string City { get; set; }

        [StringLength(10, ErrorMessage = "Zip must not exceed 10 characters.")]
        public string Zip { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<EmployeeSalary> Salaries { get; set; }
    }
}
