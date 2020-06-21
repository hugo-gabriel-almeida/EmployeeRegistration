using EmployeeRegistration.Models;
using Microsoft.EntityFrameworkCore;


namespace EmployeeRegistration.Data
{
    public class EmployeeRegistrationContext : DbContext
    {
        public EmployeeRegistrationContext(DbContextOptions<EmployeeRegistrationContext> opt) :base(opt)
        {

        }

        public DbSet<Employee> Employee {get; set;}
    }
}