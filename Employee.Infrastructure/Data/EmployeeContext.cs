using Microsoft.EntityFrameworkCore;

namespace Employee.Infrastructure.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base (options)
        {

        }

        public DbSet<Employee.Core.Entities.Employee> Employees { get; set; }
    }
}
