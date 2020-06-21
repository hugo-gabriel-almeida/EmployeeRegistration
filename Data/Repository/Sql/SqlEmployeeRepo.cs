

using System;
using EmployeeRegistration.Models;

namespace EmployeeRegistration.Data
{
    public class SqlEmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeRegistrationContext _context;

        public SqlEmployeeRepo(EmployeeRegistrationContext context)
        {
            _context = context;
        }

        public void CreateEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            _context.Add(employee);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}