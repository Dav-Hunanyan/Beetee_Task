using Microsoft.EntityFrameworkCore;



namespace Beetee_Task.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
