using Microsoft.EntityFrameworkCore;
using EmployeeRegistration.Models;

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