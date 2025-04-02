using Microsoft.EntityFrameworkCore;

namespace mystore.Models
{
    public class EmployeeDBContext :DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options)
        {
                
        }
        public DbSet<Employee> employees1 { get; set; }
    }
}
