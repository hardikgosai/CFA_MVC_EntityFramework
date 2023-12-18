using Getri_CFA_MVC_EntityFramework.EntityFramework;
using Getri_CFA_MVC_EntityFramework.Models;

namespace Getri_CFA_MVC_EntityFramework.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext employeeDbContext;
        
        public EmployeeRepository(EmployeeDbContext _employeeDbContext)
        {
            employeeDbContext = _employeeDbContext;
        }

        public Employee AddEmployee(Employee employee)
        {
            employeeDbContext.Employees.Add(employee);
            employeeDbContext.SaveChanges();
            return employee;
        }

        public bool DeleteEmployee(int id)
        {
            var employee = employeeDbContext.Employees.Find(id);
            if (employee != null)
            {
                employeeDbContext.Employees.Remove(employee);
                employeeDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = employeeDbContext.Employees.Find(id);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return employeeDbContext.Employees.ToList();
        }

        public Employee UpdateEmployee(Employee employee)
        {
            employeeDbContext.Employees.Update(employee);
            employeeDbContext.SaveChanges();
            return employee;
        }
    }
}
