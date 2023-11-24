using System;
using System.Collections.Generic;
using EmployeeManagement.Data.Repositories;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IEmployeeSalaryRepository _employeeSalaryRepository;

        public EmployeeController(
            IEmployeeRepository employeeRepository,
            IEmployeeSalaryRepository employeeSalaryRepository)
        {
            _employeeRepository = employeeRepository;
            _employeeSalaryRepository = employeeSalaryRepository;
        }

        public IActionResult Index()
        {
            List<Employee> employees = _employeeRepository.GetAllEmployees();
            return View(employees);
        }
         
        public IActionResult Edit(int id)
        {
            Employee employee = _employeeRepository.GetEmployeeById(id);
            return PartialView("_EmployeeDetails", employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee model)
        {
            if (ModelState.IsValid)
            {
                // Perform any necessary validation and update the employee
                _employeeRepository.UpdateEmployee(model);

                return RedirectToAction("Index");
            }

            // If the model is not valid, return to the details view with validation errors
            return PartialView("_EmployeeDetails", model);
        }
        public IActionResult AddEmployee()
        {
            return PartialView("_AddEmployee");
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                // Perform any necessary validation and save the new employee
                _employeeRepository.AddEmployee(model);

                return RedirectToAction("Index");
            }

            // If the model is not valid, return to the add employee view with validation errors
            return View(model);
        }

        public IActionResult SalaryRecords(int id)
        {
            // Retrieve salary records for the employee by ID and pass it to the view
            List<EmployeeSalary> salaryRecords = _employeeSalaryRepository.GetEmployeeSalaries(id);
            return PartialView("_SalaryRecords", salaryRecords);
        }

        public IActionResult AddSalary(int id)
        {
            EmployeeSalary empSalary = new EmployeeSalary
            { 
                EmployeeId = id, 
                SalaryDate = DateTime.Now
            };
            return PartialView("_AddSalary", empSalary);
        }

        [HttpPost]
        public IActionResult AddSalary(EmployeeSalary model)
        {
            if (ModelState.IsValid)
            {
                // Add the monthly salary to the repository
                _employeeSalaryRepository.AddSalary(model);

                // Redirect to the employee listing page or another appropriate page
                return RedirectToAction("Index");
            }

            // If the model is not valid, return to the add salary view with validation errors
            return PartialView("_AddSalary");
        }


        public IActionResult Details(int id)
        {
            Employee employee = _employeeRepository.GetEmployeeById(id);
            return PartialView("_EmployeeDetails", employee);
        }
    }
}
