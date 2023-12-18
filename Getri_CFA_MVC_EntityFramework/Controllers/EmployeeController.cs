using Getri_CFA_MVC_EntityFramework.Models;
using Getri_CFA_MVC_EntityFramework.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Getri_CFA_MVC_EntityFramework.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }

        public IActionResult Index()
        {
            List<Employee> employees = employeeRepository.GetEmployees();
            return View(employees);            
        }

        public IActionResult Details(int id)
        {
            Employee employee = employeeRepository.GetEmployeeById(id);
            return View(employee);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("EmpName,EmpAddress,EmpGender,EmpContact")] Employee employee)
        {
           Employee employee1 = employeeRepository.AddEmployee(employee);
            return RedirectToAction("Index");            
        }

        public IActionResult Edit(int id)
        {
            return View("~/Views/Employee/Update.cshtml",employeeRepository.GetEmployeeById(id));
        }

        [HttpPost]
        public IActionResult Update([Bind("EmpId,EmpName,EmpAddress,EmpGender,EmpContact")] Employee employee)
        {
            Employee employee1 = employeeRepository.UpdateEmployee(employee);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            bool result = employeeRepository.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}
