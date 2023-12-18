using Getri_CFA_MVC_EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace Getri_CFA_MVC_EntityFramework.EntityFramework
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
