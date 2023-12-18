using Getri_CFA_MVC_EntityFramework.Models;

namespace Getri_CFA_MVC_EntityFramework.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        bool DeleteEmployee(int id);
    }
}
